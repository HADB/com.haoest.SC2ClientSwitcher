using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
using System.IO;

namespace NetPing
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private AutoResetEvent waiter = new AutoResetEvent(false);
		private Ping ping = new Ping();
		private int pingIndex = 0;
		private string curUrl = "";
		private string MyIp = "";

		private void Form1_Load(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
			ImageList l = new ImageList();
			l.ImageSize = new Size(1, 23);
			listData.SmallImageList = l;
			ping.PingCompleted += new PingCompletedEventHandler(ping_PingCompleted);
			string strUrl = Properties.Settings.Default.strUrl;
			string[] strs = strUrl.Split(',');
			foreach (string r in strs)
			{
				AddPing(r);
			}
		}

		private void btnPing_Click(object sender, EventArgs e)
		{
			txtPing.Text = txtPing.Text.Trim().ToLower();
			if (txtPing.Text == "")
			{
				txtPing.Focus();
				return;
			}

			AddPing(txtPing.Text);

			txtPing.Text = "";
			txtPing.Focus();
		}

		private void AddPing(string url)
		{
			if (url == "")
			{
				return;
			}
			foreach (ListViewItem r in listData.Items)
			{
				if (r.Text == url)
				{
					return;
				}
			}
			ListViewItem item = new ListViewItem();
			item.Tag = "0|0";
			item.UseItemStyleForSubItems = false;
			item.Text = url;
			item.SubItems.Add("-");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0/0 100%");
			listData.Items.Add(item);

			if (listData.Items.Count == 1)
			{
				runPing();
			}
			SaveUrl();
		}

		private void SaveUrl()
		{
			string strUrl = "";
			foreach (ListViewItem r in listData.Items)
			{
				strUrl += r.Text + ",";
			}
			Properties.Settings.Default.strUrl = strUrl.Trim(',');
			Properties.Settings.Default.Save();
		}

		private void runPing()
		{
			if (listData.Items.Count == 0)
			{
				return;
			}
				
			pingIndex++;
			if (pingIndex >= listData.Items.Count)
			{
				pingIndex = 0;
			}
			if (listData.Items.Count < 5)
			{
				Thread.Sleep(100);
			}
			curUrl = listData.Items[pingIndex].Text;
			ping.SendAsync(curUrl, waiter);
		}

		private void ping_PingCompleted(object sender, PingCompletedEventArgs e)
		{
			ListViewItem item = null;
			foreach (ListViewItem r in listData.Items)
			{
				if (r.Text == curUrl)
				{
					item = r;
					break;
				}
			}
			if (item != null)
			{
				long l = 10000;
				bool isError = true;
				if (!e.Cancelled && e.Error == null && e.Reply.Status == IPStatus.Success)
				{
					item.SubItems[1].Text = e.Reply.Address.ToString();
					l = e.Reply.RoundtripTime;
					isError = false;
				}
				if (l > 9999)
				{
					item.SubItems[2].Text = "连接失败";
					item.SubItems[2].ForeColor = Color.Red;
				}
				else
				{
					item.SubItems[2].Text = l.ToString();
					item.SubItems[2].ForeColor = Color.Blue;

					string[] strs = item.Tag.ToString().Split('|');
					l = long.Parse(strs[0]) + l;
					long num = long.Parse(strs[1]) + 1;
					item.Tag = l.ToString() + "|" + num.ToString();
					long ave = l / num;
					item.SubItems[3].Text = ave.ToString();
				}

				string[] strPer = item.SubItems[4].Text.Split(' ');
				string[] strNums = strPer[0].Split('/');
				long numError = long.Parse(strNums[0]) + (isError ? 1 : 0);
				long numSum = long.Parse(strNums[1]) + 1;
				double per = 1.0 * numError / numSum * 100;
				item.SubItems[4].Text = string.Format("{0}/{1} {2:F2}%", numError, numSum, per);
			}

			((AutoResetEvent)e.UserState).Set();
			runPing();
		}

		private void listData_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				while (listData.SelectedItems.Count > 0)
				{
					listData.Items.Remove(listData.SelectedItems[0]);
				}
				SaveUrl();
			}
			else if (e.Control && e.KeyCode == Keys.C)
			{
				string strData = "";
				foreach (ListViewItem r in listData.SelectedItems)
				{
					strData += string.Format("{0}\t[{1}]\tping:{2}\tavePing:{3}\terror:{4} \r\n", r.Text, r.SubItems[1].Text, r.SubItems[2].Text, r.SubItems[3].Text, r.SubItems[4].Text);
				}
				if (strData != "")
				{
					if (MyIp != "")
					{
						strData = string.Format("外网IP：{0} 时间：{1} \r\n", MyIp, DateTime.Now) + strData;
					}

					Clipboard.SetText(strData);
				}
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				WebRequest w = WebRequest.Create("http://www.ip138.com/ip2city.asp");
				Stream s = w.GetResponse().GetResponseStream();
				StreamReader r = new StreamReader(s, Encoding.Default);
				string ip = r.ReadToEnd();
				r.Close();
				s.Close();
				MyIp = ip.Substring(ip.LastIndexOf('['), ip.LastIndexOf(']') - ip.LastIndexOf('[') + 1);
			}
			catch
			{
				MyIp = "";
			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Text += " " + MyIp;
		}
	}
}