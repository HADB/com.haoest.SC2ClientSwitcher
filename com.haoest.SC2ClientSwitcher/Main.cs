using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.haoest.SC2ClientSwitcher.Modules;
using System.IO;

namespace com.haoest.SC2ClientSwitcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = "星际2客户端切换器 For 1.5.0+   " + String.Format("版本号：{0}", About.AssemblyVersion);
        }

        private void Button_AddClient_Click(object sender, EventArgs e)
        {
            EditClient open = new EditClient();
            open.ShowDialog();
        }

        private void Button_EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                EditClient open = new EditClient(Client.GetClientByClientListItem(ClientList.SelectedItem.ToString()));
                open.ShowDialog();
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message + " \n\n" + ex.Source + "\n\n" + ex.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 启动客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_RunClient_Click(object sender, EventArgs e)
        {
            String locale = Client.GetLocaleFromClientListItem(this.ClientList.SelectedItem.ToString());
            LocaleChanger.ChangeVarTXT(locale, locale);
            Client client = Client.GetClientByClientListItem(this.ClientList.SelectedItem.ToString());
            String path = client.GameFolder + "\\StarCraft II.exe";
            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
                Application.Exit();
            }
            else
            {
                MessageBox.Show(path + "\n指定位置找不到客户端，请重新编辑游戏所在目录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {
                    EditClient open = new EditClient(client);
                    open.ShowDialog();
                }
                catch (Exception ex)
                {
                    //Do　any　logging　operation　here　if　necessary  
                    MessageBox.Show(ex.Message + " \n\n" + ex.Source + "\n\n" + ex.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                String locale = Client.GetLocaleFromClientListItem(ClientList.SelectedItem.ToString());
                ClientDAL.DeleteClient(locale);
                MessageBox.Show("移除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Do　any　logging　operation　here　if　necessary  
                MessageBox.Show(ex.Message + " \n\n" + ex.Source + "\n\n" + ex.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            Button_EditClient.Enabled = false;
            Button_DeleteClient.Enabled = false;
            Button_RunClient.Enabled = false;
            ClientList.Items.Clear();
            DataTable dt = ClientDAL.GetAllClient();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClientList.Items.Add(dt.Rows[i]["region"] + " - " + dt.Rows[i]["name"] + " - " + dt.Rows[i]["locale"]);
                //if (i % 2==0) ClientList.Items[i]
            }

            if (ClientList.Items.Count == 0)
            {
                ClientList.Items.Add("尚未添加客户端，请添加！");
                ClientList.Enabled = false;
            }
            else
            {
                ClientList.Enabled = true;
            }
        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientList.SelectedIndex != -1)
            {
                Button_EditClient.Enabled = true;
                Button_DeleteClient.Enabled = true;
                Button_RunClient.Enabled = true;
            }
        }

        /// <summary>
        /// ClientList双击启动对应客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Button_RunClient.PerformClick();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sc2.haoest.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.haoest.com");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 使用指南ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sc2.haoest.com/archives/184");
        }

        private void 检查更新UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sc2.haoest.com/archives/184");
        }


    }
}
