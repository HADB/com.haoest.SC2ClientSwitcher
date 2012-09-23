namespace com.haoest.SC2ClientSwitcher
{
    partial class EditClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LanguageList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_OpenGameFolder = new System.Windows.Forms.Button();
            this.TextBox_GameFolder = new System.Windows.Forms.TextBox();
            this.SelectGameFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LanguageList
            // 
            this.LanguageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageList.FormattingEnabled = true;
            this.LanguageList.Items.AddRange(new object[] {
            "AM - English (US) - enUS",
            "AM - Español (Latin America) - esMX",
            "AM - Português (Brazil) - ptBR",
            "CN - 简体中文 (PR China, simplified) - zhCN",
            "EU - English (UK) - enGB",
            "EU - Français - frFR",
            "EU - Deutsch - deDE",
            "EU - Italiano - itIT",
            "EU - Polski - plPL",
            "EU - Русский - ruRU",
            "EU - Español (Spain) - esES",
            "KR/TW - 한국어 - koKR",
            "KR/TW - 繁體中文 (Taiwan, tranditional) - zhTW",
            "SEA - English (Singapore) - enSG"});
            this.LanguageList.Location = new System.Drawing.Point(19, 44);
            this.LanguageList.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.LanguageList.Name = "LanguageList";
            this.LanguageList.Size = new System.Drawing.Size(296, 25);
            this.LanguageList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "语言：";
            // 
            // Button_OpenGameFolder
            // 
            this.Button_OpenGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OpenGameFolder.AutoSize = true;
            this.Button_OpenGameFolder.Location = new System.Drawing.Point(286, 108);
            this.Button_OpenGameFolder.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Button_OpenGameFolder.Name = "Button_OpenGameFolder";
            this.Button_OpenGameFolder.Size = new System.Drawing.Size(29, 27);
            this.Button_OpenGameFolder.TabIndex = 2;
            this.Button_OpenGameFolder.Text = "...";
            this.Button_OpenGameFolder.UseVisualStyleBackColor = true;
            this.Button_OpenGameFolder.Click += new System.EventHandler(this.Button_OpenGameFolder_Click);
            // 
            // TextBox_GameFolder
            // 
            this.TextBox_GameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_GameFolder.Location = new System.Drawing.Point(19, 110);
            this.TextBox_GameFolder.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.TextBox_GameFolder.Name = "TextBox_GameFolder";
            this.TextBox_GameFolder.Size = new System.Drawing.Size(261, 23);
            this.TextBox_GameFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "游戏目录：";
            // 
            // Button_Submit
            // 
            this.Button_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Submit.AutoSize = true;
            this.Button_Submit.Location = new System.Drawing.Point(131, 188);
            this.Button_Submit.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(72, 27);
            this.Button_Submit.TabIndex = 4;
            this.Button_Submit.Text = "确定";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 230);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.TextBox_GameFolder);
            this.Controls.Add(this.Button_OpenGameFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LanguageList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LanguageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_OpenGameFolder;
        private System.Windows.Forms.TextBox TextBox_GameFolder;
        private System.Windows.Forms.FolderBrowserDialog SelectGameFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Submit;
    }
}