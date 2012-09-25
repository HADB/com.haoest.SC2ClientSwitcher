namespace com.haoest.SC2ClientSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用指南ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.检查更新UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_AddClient = new System.Windows.Forms.Button();
            this.Button_RunClient = new System.Windows.Forms.Button();
            this.Button_DeleteClient = new System.Windows.Forms.Button();
            this.Button_EditClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(499, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.菜单ToolStripMenuItem.Text = "菜单(&M)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用指南ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.检查更新UToolStripMenuItem,
            this.toolStripMenuItem2,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 使用指南ToolStripMenuItem
            // 
            this.使用指南ToolStripMenuItem.Name = "使用指南ToolStripMenuItem";
            this.使用指南ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.使用指南ToolStripMenuItem.Text = "使用指南(&G)";
            this.使用指南ToolStripMenuItem.Click += new System.EventHandler(this.使用指南ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // 检查更新UToolStripMenuItem
            // 
            this.检查更新UToolStripMenuItem.Name = "检查更新UToolStripMenuItem";
            this.检查更新UToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.检查更新UToolStripMenuItem.Text = "检查更新(&U)";
            this.检查更新UToolStripMenuItem.Click += new System.EventHandler(this.检查更新UToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // Button_AddClient
            // 
            this.Button_AddClient.AutoSize = true;
            this.Button_AddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_AddClient.Location = new System.Drawing.Point(20, 36);
            this.Button_AddClient.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.Button_AddClient.Name = "Button_AddClient";
            this.Button_AddClient.Size = new System.Drawing.Size(109, 30);
            this.Button_AddClient.TabIndex = 2;
            this.Button_AddClient.Text = "添加客户端";
            this.Button_AddClient.UseVisualStyleBackColor = true;
            this.Button_AddClient.Click += new System.EventHandler(this.Button_AddClient_Click);
            // 
            // Button_RunClient
            // 
            this.Button_RunClient.AutoSize = true;
            this.Button_RunClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_RunClient.Location = new System.Drawing.Point(20, 70);
            this.Button_RunClient.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.Button_RunClient.Name = "Button_RunClient";
            this.Button_RunClient.Size = new System.Drawing.Size(109, 30);
            this.Button_RunClient.TabIndex = 3;
            this.Button_RunClient.Text = "启动客户端";
            this.Button_RunClient.UseVisualStyleBackColor = true;
            this.Button_RunClient.Click += new System.EventHandler(this.Button_RunClient_Click);
            // 
            // Button_DeleteClient
            // 
            this.Button_DeleteClient.AutoSize = true;
            this.Button_DeleteClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_DeleteClient.Location = new System.Drawing.Point(20, 138);
            this.Button_DeleteClient.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.Button_DeleteClient.Name = "Button_DeleteClient";
            this.Button_DeleteClient.Size = new System.Drawing.Size(109, 30);
            this.Button_DeleteClient.TabIndex = 3;
            this.Button_DeleteClient.Text = "移除客户端";
            this.Button_DeleteClient.UseVisualStyleBackColor = true;
            this.Button_DeleteClient.Click += new System.EventHandler(this.Button_DeleteClient_Click);
            // 
            // Button_EditClient
            // 
            this.Button_EditClient.AutoSize = true;
            this.Button_EditClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_EditClient.Location = new System.Drawing.Point(20, 104);
            this.Button_EditClient.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.Button_EditClient.Name = "Button_EditClient";
            this.Button_EditClient.Size = new System.Drawing.Size(109, 30);
            this.Button_EditClient.TabIndex = 3;
            this.Button_EditClient.Text = "编辑客户端";
            this.Button_EditClient.UseVisualStyleBackColor = true;
            this.Button_EditClient.Click += new System.EventHandler(this.Button_EditClient_Click);
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "简要说明：手动添加客户端，设置客户端文件夹和语言即可";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabel3, 2);
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(18, 14);
            this.linkLabel3.Location = new System.Drawing.Point(10, 240);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(479, 33);
            this.linkLabel3.TabIndex = 10;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "更多精彩请访问星际争霸2战术资源站：sc2.haoest.com";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel3.UseCompatibleTextRendering = true;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::com.haoest.SC2ClientSwitcher.Properties.Resources.sc2站点logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ClientList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Button_AddClient, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_DeleteClient, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button_EditClient, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_RunClient, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 275);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // ClientList
            // 
            this.ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 17;
            this.ClientList.Location = new System.Drawing.Point(154, 39);
            this.ClientList.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.ClientList.Name = "ClientList";
            this.tableLayoutPanel1.SetRowSpan(this.ClientList, 4);
            this.ClientList.Size = new System.Drawing.Size(325, 126);
            this.ClientList.TabIndex = 13;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            this.ClientList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClientList_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(152, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "客户端列表：（双击可直接启动）";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "星际2客户端切换器 For 1.5.0+";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Button Button_AddClient;
        private System.Windows.Forms.Button Button_RunClient;
        private System.Windows.Forms.Button Button_DeleteClient;
        private System.Windows.Forms.Button Button_EditClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用指南ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 检查更新UToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

