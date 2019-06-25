namespace GF.BasicExample
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPositions = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.pOrderTicket = new System.Windows.Forms.FlowLayoutPanel();
            this.cbSide = new System.Windows.Forms.ComboBox();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pOrderTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.SuspendLayout();
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(494, 367);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            //
            // splitContainer2
            //
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            //
            // splitContainer2.Panel1
            //
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            //
            // splitContainer2.Panel2
            //
            this.splitContainer2.Panel2.Controls.Add(this.lbPositions);
            this.splitContainer2.Size = new System.Drawing.Size(494, 120);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDisconnect, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbStatus, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // label1
            //
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tbLogin
            //
            this.tbLogin.Location = new System.Drawing.Point(103, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(94, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "test";
            //
            // label2
            //
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tbPassword
            //
            this.tbPassword.Location = new System.Drawing.Point(103, 29);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(94, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            //
            // btnConnect
            //
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(3, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            //
            // btnDisconnect
            //
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Location = new System.Drawing.Point(103, 55);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            //
            // lbStatus
            //
            this.lbStatus.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbStatus, 2);
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Location = new System.Drawing.Point(3, 81);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(194, 33);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Idle";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lbPositions
            //
            this.lbPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPositions.FormattingEnabled = true;
            this.lbPositions.IntegralHeight = false;
            this.lbPositions.Location = new System.Drawing.Point(0, 0);
            this.lbPositions.Name = "lbPositions";
            this.lbPositions.Size = new System.Drawing.Size(283, 120);
            this.lbPositions.TabIndex = 0;
            this.lbPositions.DoubleClick += new System.EventHandler(this.lbPositions_DoubleClick);
            //
            // splitContainer3
            //
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer3.Panel1
            //
            this.splitContainer3.Panel1.Controls.Add(this.lbOrders);
            //
            // splitContainer3.Panel2
            //
            this.splitContainer3.Panel2.Controls.Add(this.pOrderTicket);
            this.splitContainer3.Size = new System.Drawing.Size(494, 243);
            this.splitContainer3.SplitterDistance = 189;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            //
            // lbOrders
            //
            this.lbOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.IntegralHeight = false;
            this.lbOrders.Location = new System.Drawing.Point(0, 0);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(494, 189);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.DoubleClick += new System.EventHandler(this.lbOrders_DoubleClick);
            //
            // pOrderTicket
            //
            this.pOrderTicket.AutoSize = true;
            this.pOrderTicket.Controls.Add(this.cbSide);
            this.pOrderTicket.Controls.Add(this.nQty);
            this.pOrderTicket.Controls.Add(this.cbContract);
            this.pOrderTicket.Controls.Add(this.cbType);
            this.pOrderTicket.Controls.Add(this.nPrice);
            this.pOrderTicket.Controls.Add(this.btnSubmit);
            this.pOrderTicket.Controls.Add(this.lbPrice);
            this.pOrderTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOrderTicket.Location = new System.Drawing.Point(0, 0);
            this.pOrderTicket.Name = "pOrderTicket";
            this.pOrderTicket.Size = new System.Drawing.Size(494, 50);
            this.pOrderTicket.TabIndex = 0;
            //
            // cbSide
            //
            this.cbSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSide.FormattingEnabled = true;
            this.cbSide.Location = new System.Drawing.Point(3, 3);
            this.cbSide.Name = "cbSide";
            this.cbSide.Size = new System.Drawing.Size(61, 21);
            this.cbSide.TabIndex = 0;
            //
            // nQty
            //
            this.nQty.Location = new System.Drawing.Point(70, 3);
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(56, 20);
            this.nQty.TabIndex = 1;
            //
            // cbContract
            //
            this.cbContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Location = new System.Drawing.Point(132, 3);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(96, 21);
            this.cbContract.TabIndex = 2;
            this.cbContract.SelectionChangeCommitted += new System.EventHandler(this.cbContract_SelectionChangeCommitted);
            //
            // cbType
            //
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(234, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(93, 21);
            this.cbType.TabIndex = 3;
            this.cbType.SelectionChangeCommitted += new System.EventHandler(this.cbType_SelectionChangeCommitted);
            //
            // nPrice
            //
            this.nPrice.DecimalPlaces = 2;
            this.nPrice.Enabled = false;
            this.nPrice.Location = new System.Drawing.Point(333, 3);
            this.nPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(75, 20);
            this.nPrice.TabIndex = 4;
            //
            // btnSubmit
            //
            this.btnSubmit.Location = new System.Drawing.Point(414, 2);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            //
            // lbPrice
            //
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(3, 28);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(67, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Market Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 367);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "GF API Example";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pOrderTicket.ResumeLayout(false);
            this.pOrderTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.ListBox lbPositions;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ListBox lbOrders;
		private System.Windows.Forms.FlowLayoutPanel pOrderTicket;
		private System.Windows.Forms.ComboBox cbSide;
		private System.Windows.Forms.NumericUpDown nQty;
		private System.Windows.Forms.ComboBox cbContract;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.NumericUpDown nPrice;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

