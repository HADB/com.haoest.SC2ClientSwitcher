using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace com.haoest.SC2ClientSwitcher
{
    public partial class EditClient : Form
    {
        private enum EditMode { Add, Edit };
        private EditMode editMode;
        private Client originalClient;

        public EditClient()
        {
            InitializeComponent();
            this.Text = "添加客户端";
            editMode = EditMode.Add;
        }

        public EditClient(Client client)
        {
            InitializeComponent();
            this.Text = "编辑客户端";
            editMode = EditMode.Edit;
            originalClient = client;
            for (int i = 0; i < Program.languageList.Length; i++)
            {
                if ((client.Region + " - " + client.Name + " - " + client.Locale) == Program.languageList[i])
                {
                    this.LanguageList.SelectedIndex = i;
                }
            }
            this.TextBox_GameFolder.Text = client.GameFolder;
        }

        private void Button_OpenGameFolder_Click(object sender, EventArgs e)
        {
            var result = SelectGameFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBox_GameFolder.Text = SelectGameFolder.SelectedPath;
            }
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            String folder = TextBox_GameFolder.Text;
            String path = folder + "\\StarCraft II.exe";

            //首先判断有没有选择语言
            if (LanguageList.SelectedIndex == -1)
            {
                MessageBox.Show("尚未选择语言！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Client client = new Client(LanguageList.SelectedItem.ToString(), TextBox_GameFolder.Text);
                try
                {
                    switch (editMode)
                    {
                        case EditMode.Add:

                            //再检查是不是已创建过该语言的客户端
                            if (Client.IsExsit(LanguageList.SelectedItem.ToString()))
                            {
                                MessageBox.Show("该语言的客户端已经创建过！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            //再检查有没有StarCraft II.exe文件
                            else if (!File.Exists(path))
                            {
                                MessageBox.Show("未找到" + path + "！请检查该目录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (ClientDAL.CreateClient(client))
                            {
                                MessageBox.Show("客户端编辑成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            break;
                        case EditMode.Edit:
                            //检查有没有StarCraft II.exe文件
                            if (!File.Exists(path))
                            {
                                MessageBox.Show("未找到" + path + "！请检查该目录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (ClientDAL.UpdateClient(client, originalClient.Locale))
                            {
                                MessageBox.Show("客户端编辑成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " \n\n" + ex.Source + "\n\n" + ex.StackTrace + "\n\n" + ex.Data, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
