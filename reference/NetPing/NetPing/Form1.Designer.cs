namespace NetPing
{
	partial class Form1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPing = new System.Windows.Forms.Button();
			this.txtPing = new System.Windows.Forms.TextBox();
			this.listData = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnPing);
			this.panel1.Controls.Add(this.txtPing);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(539, 35);
			this.panel1.TabIndex = 0;
			// 
			// btnPing
			// 
			this.btnPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPing.Location = new System.Drawing.Point(453, 3);
			this.btnPing.Name = "btnPing";
			this.btnPing.Size = new System.Drawing.Size(80, 28);
			this.btnPing.TabIndex = 1;
			this.btnPing.Text = "Ping";
			this.btnPing.UseVisualStyleBackColor = true;
			this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
			// 
			// txtPing
			// 
			this.txtPing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPing.Location = new System.Drawing.Point(4, 4);
			this.txtPing.Margin = new System.Windows.Forms.Padding(4);
			this.txtPing.Name = "txtPing";
			this.txtPing.Size = new System.Drawing.Size(442, 26);
			this.txtPing.TabIndex = 0;
			// 
			// listData
			// 
			this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.listData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listData.FullRowSelect = true;
			this.listData.GridLines = true;
			this.listData.HideSelection = false;
			this.listData.Location = new System.Drawing.Point(0, 35);
			this.listData.Name = "listData";
			this.listData.Size = new System.Drawing.Size(539, 392);
			this.listData.TabIndex = 1;
			this.listData.UseCompatibleStateImageBehavior = false;
			this.listData.View = System.Windows.Forms.View.Details;
			this.listData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listData_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "网址";
			this.columnHeader1.Width = 119;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "IP";
			this.columnHeader2.Width = 122;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "PING值";
			this.columnHeader3.Width = 69;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "平均值";
			this.columnHeader4.Width = 69;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "错误率";
			this.columnHeader5.Width = 146;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnPing;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 427);
			this.Controls.Add(this.listData);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PING工具";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPing;
		private System.Windows.Forms.Button btnPing;
		private System.Windows.Forms.ListView listData;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;

	}
}

