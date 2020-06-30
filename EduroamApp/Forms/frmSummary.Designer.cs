namespace EduroamApp
{
	partial class frmSummary
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
			this.lblWebTitle = new System.Windows.Forms.Label();
			this.lblEmailTitle = new System.Windows.Forms.Label();
			this.lblPhoneTitle = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.tblContactInfo = new System.Windows.Forms.TableLayoutPanel();
			this.lblWeb = new System.Windows.Forms.LinkLabel();
			this.lblEmail = new System.Windows.Forms.LinkLabel();
			this.gboContactInfo = new System.Windows.Forms.GroupBox();
			this.lblAlternate = new System.Windows.Forms.Label();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblDesc = new System.Windows.Forms.Label();
			this.pnlInstName = new System.Windows.Forms.Panel();
			this.lnkToU = new System.Windows.Forms.LinkLabel();
			this.lblToU = new System.Windows.Forms.Label();
			this.lblTerms2 = new System.Windows.Forms.Label();
			this.pnlContactInfo = new System.Windows.Forms.Panel();
			this.pnlTerms = new System.Windows.Forms.Panel();
			this.tblSelectInst = new System.Windows.Forms.TableLayoutPanel();
			this.btnSelectInst = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblInstName = new System.Windows.Forms.Label();
			this.lblYourinst = new System.Windows.Forms.Label();
			this.tblContactInfo.SuspendLayout();
			this.gboContactInfo.SuspendLayout();
			this.pnlTop.SuspendLayout();
			this.pnlContactInfo.SuspendLayout();
			this.pnlTerms.SuspendLayout();
			this.tblSelectInst.SuspendLayout();
			this.SuspendLayout();
			//
			// lblWebTitle
			//
			this.lblWebTitle.AutoSize = true;
			this.lblWebTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblWebTitle.Location = new System.Drawing.Point(4, 5);
			this.lblWebTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
			this.lblWebTitle.Name = "lblWebTitle";
			this.lblWebTitle.Size = new System.Drawing.Size(68, 25);
			this.lblWebTitle.TabIndex = 7;
			this.lblWebTitle.Text = "Web:";
			//
			// lblEmailTitle
			//
			this.lblEmailTitle.AutoSize = true;
			this.lblEmailTitle.Location = new System.Drawing.Point(4, 35);
			this.lblEmailTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
			this.lblEmailTitle.Name = "lblEmailTitle";
			this.lblEmailTitle.Size = new System.Drawing.Size(52, 20);
			this.lblEmailTitle.TabIndex = 8;
			this.lblEmailTitle.Text = "Email:";
			//
			// lblPhoneTitle
			//
			this.lblPhoneTitle.AutoSize = true;
			this.lblPhoneTitle.Location = new System.Drawing.Point(4, 65);
			this.lblPhoneTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
			this.lblPhoneTitle.Name = "lblPhoneTitle";
			this.lblPhoneTitle.Size = new System.Drawing.Size(59, 20);
			this.lblPhoneTitle.TabIndex = 9;
			this.lblPhoneTitle.Text = "Phone:";
			//
			// lblPhone
			//
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(80, 65);
			this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
			this.lblPhone.MinimumSize = new System.Drawing.Size(0, 25);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(117, 25);
			this.lblPhone.TabIndex = 9;
			this.lblPhone.Text = "001234567890";
			//
			// tblContactInfo
			//
			this.tblContactInfo.AutoSize = true;
			this.tblContactInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tblContactInfo.ColumnCount = 2;
			this.tblContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.61539F));
			this.tblContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.38461F));
			this.tblContactInfo.Controls.Add(this.lblWeb, 1, 0);
			this.tblContactInfo.Controls.Add(this.lblEmail, 1, 1);
			this.tblContactInfo.Controls.Add(this.lblWebTitle, 0, 0);
			this.tblContactInfo.Controls.Add(this.lblPhone, 1, 2);
			this.tblContactInfo.Controls.Add(this.lblPhoneTitle, 0, 2);
			this.tblContactInfo.Controls.Add(this.lblEmailTitle, 0, 1);
			this.tblContactInfo.Location = new System.Drawing.Point(13, 29);
			this.tblContactInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tblContactInfo.Name = "tblContactInfo";
			this.tblContactInfo.RowCount = 3;
			this.tblContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tblContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tblContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tblContactInfo.Size = new System.Drawing.Size(388, 90);
			this.tblContactInfo.TabIndex = 10;
			//
			// lblWeb
			//
			this.lblWeb.AutoEllipsis = true;
			this.lblWeb.Location = new System.Drawing.Point(80, 5);
			this.lblWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
			this.lblWeb.MaximumSize = new System.Drawing.Size(345, 0);
			this.lblWeb.MinimumSize = new System.Drawing.Size(0, 25);
			this.lblWeb.Name = "lblWeb";
			this.lblWeb.Size = new System.Drawing.Size(304, 25);
			this.lblWeb.TabIndex = 12;
			this.lblWeb.TabStop = true;
			this.lblWeb.Text = "https://www.institution.com";
			this.lblWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWeb_LinkClicked);
			//
			// lblEmail
			//
			this.lblEmail.AutoEllipsis = true;
			this.lblEmail.Location = new System.Drawing.Point(80, 35);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
			this.lblEmail.MaximumSize = new System.Drawing.Size(345, 0);
			this.lblEmail.MinimumSize = new System.Drawing.Size(0, 25);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(304, 25);
			this.lblEmail.TabIndex = 12;
			this.lblEmail.TabStop = true;
			this.lblEmail.Text = "email@institution.com";
			this.lblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEmail_LinkClicked);
			//
			// gboContactInfo
			//
			this.gboContactInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.gboContactInfo.Controls.Add(this.tblContactInfo);
			this.gboContactInfo.Location = new System.Drawing.Point(30, 12);
			this.gboContactInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gboContactInfo.Name = "gboContactInfo";
			this.gboContactInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gboContactInfo.Size = new System.Drawing.Size(414, 124);
			this.gboContactInfo.TabIndex = 11;
			this.gboContactInfo.TabStop = false;
			this.gboContactInfo.Text = "Contact info";
			//
			// lblAlternate
			//
			this.lblAlternate.AutoSize = true;
			this.lblAlternate.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblAlternate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblAlternate.Location = new System.Drawing.Point(4, 0);
			this.lblAlternate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAlternate.MaximumSize = new System.Drawing.Size(360, 0);
			this.lblAlternate.Name = "lblAlternate";
			this.lblAlternate.Size = new System.Drawing.Size(215, 126);
			this.lblAlternate.TabIndex = 12;
			this.lblAlternate.Text = "Not connecting to institution?";
			//
			// pnlTop
			//
			this.pnlTop.Controls.Add(this.lblYourinst);
			this.pnlTop.Controls.Add(this.lblInstName);
			this.pnlTop.Controls.Add(this.panel1);
			this.pnlTop.Controls.Add(this.lblDesc);
			this.pnlTop.Controls.Add(this.pnlInstName);
			this.pnlTop.Controls.Add(this.tblSelectInst);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(513, 160);
			this.pnlTop.TabIndex = 13;
			//
			// panel1
			//
			this.panel1.AutoSize = true;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(513, 0);
			this.panel1.TabIndex = 9;
			//
			// lblDesc
			//
			this.lblDesc.Location = new System.Drawing.Point(43, 79);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(425, 85);
			this.lblDesc.TabIndex = 19;
			this.lblDesc.Text = "Description: ";
			this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			// pnlInstName
			//
			this.pnlInstName.AutoSize = true;
			this.pnlInstName.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlInstName.Location = new System.Drawing.Point(0, 0);
			this.pnlInstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlInstName.Name = "pnlInstName";
			this.pnlInstName.Size = new System.Drawing.Size(513, 0);
			this.pnlInstName.TabIndex = 8;
			//
			// lnkToU
			//
			this.lnkToU.AutoSize = true;
			this.lnkToU.Location = new System.Drawing.Point(5, 43);
			this.lnkToU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lnkToU.Name = "lnkToU";
			this.lnkToU.Size = new System.Drawing.Size(104, 20);
			this.lnkToU.TabIndex = 9;
			this.lnkToU.TabStop = true;
			this.lnkToU.Text = "Terms of Use";
			this.lnkToU.Visible = false;
			this.lnkToU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkToU_LinkClicked);
			//
			// lblToU
			//
			this.lblToU.AutoSize = true;
			this.lblToU.Location = new System.Drawing.Point(13, 14);
			this.lblToU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblToU.MaximumSize = new System.Drawing.Size(562, 0);
			this.lblToU.Name = "lblToU";
			this.lblToU.Size = new System.Drawing.Size(243, 20);
			this.lblToU.TabIndex = 7;
			this.lblToU.Text = "By clicking \'Next\' you agree to the\r\n";
			//
			// lblTerms2
			//
			this.lblTerms2.AutoSize = true;
			this.lblTerms2.Location = new System.Drawing.Point(116, 43);
			this.lblTerms2.Name = "lblTerms2";
			this.lblTerms2.Size = new System.Drawing.Size(124, 20);
			this.lblTerms2.TabIndex = 13;
			this.lblTerms2.Text = "of the Institution";
			//
			// pnlContactInfo
			//
			this.pnlContactInfo.Controls.Add(this.gboContactInfo);
			this.pnlContactInfo.Controls.Add(this.pnlTerms);
			this.pnlContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlContactInfo.Location = new System.Drawing.Point(0, 160);
			this.pnlContactInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlContactInfo.Name = "pnlContactInfo";
			this.pnlContactInfo.Size = new System.Drawing.Size(513, 204);
			this.pnlContactInfo.TabIndex = 14;
			//
			// pnlTerms
			//
			this.pnlTerms.Controls.Add(this.lnkToU);
			this.pnlTerms.Controls.Add(this.lblToU);
			this.pnlTerms.Controls.Add(this.lblTerms2);
			this.pnlTerms.Location = new System.Drawing.Point(64, 132);
			this.pnlTerms.Name = "pnlTerms";
			this.pnlTerms.Size = new System.Drawing.Size(384, 72);
			this.pnlTerms.TabIndex = 20;
			//
			// tblSelectInst
			//
			this.tblSelectInst.AutoSize = true;
			this.tblSelectInst.ColumnCount = 2;
			this.tblSelectInst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tblSelectInst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
			this.tblSelectInst.Controls.Add(this.btnSelectInst, 1, 0);
			this.tblSelectInst.Controls.Add(this.lblAlternate, 0, 0);
			this.tblSelectInst.Location = new System.Drawing.Point(12, 104);
			this.tblSelectInst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tblSelectInst.Name = "tblSelectInst";
			this.tblSelectInst.RowCount = 1;
			this.tblSelectInst.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tblSelectInst.Size = new System.Drawing.Size(731, 126);
			this.tblSelectInst.TabIndex = 16;
			//
			// btnSelectInst
			//
			this.btnSelectInst.AutoSize = true;
			this.btnSelectInst.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnSelectInst.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSelectInst.Location = new System.Drawing.Point(227, 5);
			this.btnSelectInst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSelectInst.Name = "btnSelectInst";
			this.btnSelectInst.Size = new System.Drawing.Size(292, 74);
			this.btnSelectInst.TabIndex = 17;
			this.btnSelectInst.Text = "Select another institution";
			this.btnSelectInst.UseVisualStyleBackColor = false;
			this.btnSelectInst.Click += new System.EventHandler(this.btnSelectInst_Click);
			//
			// panel4
			//
			this.panel4.AutoSize = true;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 430);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(513, 0);
			this.panel4.TabIndex = 18;
			//
			// lblInstName
			//
			this.lblInstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstName.Location = new System.Drawing.Point(8, 44);
			this.lblInstName.Name = "lblInstName";
			this.lblInstName.Size = new System.Drawing.Size(493, 23);
			this.lblInstName.TabIndex = 22;
			this.lblInstName.Text = "Instname";
			this.lblInstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// lblYourinst
			//
			this.lblYourinst.Location = new System.Drawing.Point(13, 9);
			this.lblYourinst.Name = "lblYourinst";
			this.lblYourinst.Size = new System.Drawing.Size(489, 23);
			this.lblYourinst.TabIndex = 23;
			this.lblYourinst.Text = "Your institution is:";
			this.lblYourinst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			//
			// frmSummary
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(513, 430);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlContactInfo);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmSummary";
			this.Text = "frm1";
			this.Load += new System.EventHandler(this.frmSummary_Load);
			this.tblContactInfo.ResumeLayout(false);
			this.tblContactInfo.PerformLayout();
			this.gboContactInfo.ResumeLayout(false);
			this.gboContactInfo.PerformLayout();
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.pnlContactInfo.ResumeLayout(false);
			this.pnlTerms.ResumeLayout(false);
			this.pnlTerms.PerformLayout();
			this.tblSelectInst.ResumeLayout(false);
			this.tblSelectInst.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblWebTitle;
		private System.Windows.Forms.Label lblEmailTitle;
		private System.Windows.Forms.Label lblPhoneTitle;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.TableLayoutPanel tblContactInfo;
		private System.Windows.Forms.GroupBox gboContactInfo;
		private System.Windows.Forms.LinkLabel lblEmail;
		private System.Windows.Forms.LinkLabel lblWeb;
		private System.Windows.Forms.Label lblAlternate;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlContactInfo;
		private System.Windows.Forms.TableLayoutPanel tblSelectInst;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblToU;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlInstName;
		private System.Windows.Forms.Button btnSelectInst;
		private System.Windows.Forms.LinkLabel lnkToU;
		private System.Windows.Forms.Label lblTerms2;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Panel pnlTerms;
		private System.Windows.Forms.Label lblInstName;
		private System.Windows.Forms.Label lblYourinst;
	}
}