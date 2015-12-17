﻿namespace WinAuth
{
	partial class ShowSteamTradesForm
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
			this.loginButton = new MetroFramework.Controls.MetroButton();
			this.loginTabLabel = new MetroFramework.Controls.MetroLabel();
			this.captchaButton = new MetroFramework.Controls.MetroButton();
			this.captchacodeField = new MetroFramework.Controls.MetroTextBox();
			this.usernameField = new MetroFramework.Controls.MetroTextBox();
			this.captchaTabLabel = new MetroFramework.Controls.MetroLabel();
			this.cancelButton = new MetroFramework.Controls.MetroButton();
			this.tabs = new MetroFramework.Controls.MetroTabControl();
			this.loginTab = new MetroFramework.Controls.MetroTabPage();
			this.rememberBox = new MetroFramework.Controls.MetroCheckBox();
			this.captchaGroup = new System.Windows.Forms.Panel();
			this.captchaBox = new System.Windows.Forms.PictureBox();
			this.passwordField = new MetroFramework.Controls.MetroTextBox();
			this.passwordLabel = new MetroFramework.Controls.MetroLabel();
			this.usernameLabel = new MetroFramework.Controls.MetroLabel();
			this.tradesTab = new MetroFramework.Controls.MetroTabPage();
			this.tradesContainer = new System.Windows.Forms.Panel();
			this.tradePanelMaster = new System.Windows.Forms.Panel();
			this.tradeSep = new System.Windows.Forms.PictureBox();
			this.tradeLabel = new MetroFramework.Controls.MetroLabel();
			this.tradeImage = new System.Windows.Forms.PictureBox();
			this.tradeReject = new MetroFramework.Controls.MetroButton();
			this.tradeAccept = new MetroFramework.Controls.MetroButton();
			this.tradeStatus = new MetroFramework.Controls.MetroLabel();
			this.tradesEmptyLabel = new MetroFramework.Controls.MetroLabel();
			this.browserContainer = new System.Windows.Forms.Panel();
			this.closeButton = new MetroFramework.Controls.MetroButton();
			this.tabs.SuspendLayout();
			this.loginTab.SuspendLayout();
			this.captchaGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.captchaBox)).BeginInit();
			this.tradesTab.SuspendLayout();
			this.tradesContainer.SuspendLayout();
			this.tradePanelMaster.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tradeSep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tradeImage)).BeginInit();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(104, 126);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(110, 24);
			this.loginButton.TabIndex = 3;
			this.loginButton.Text = "Login";
			this.loginButton.UseSelectable = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// loginTabLabel
			// 
			this.loginTabLabel.Location = new System.Drawing.Point(7, 10);
			this.loginTabLabel.Name = "loginTabLabel";
			this.loginTabLabel.Size = new System.Drawing.Size(431, 29);
			this.loginTabLabel.TabIndex = 0;
			this.loginTabLabel.Text = "Enter your steam username and password.";
			// 
			// captchaButton
			// 
			this.captchaButton.Location = new System.Drawing.Point(97, 118);
			this.captchaButton.Name = "captchaButton";
			this.captchaButton.Size = new System.Drawing.Size(110, 23);
			this.captchaButton.TabIndex = 4;
			this.captchaButton.Text = "Login";
			this.captchaButton.UseSelectable = true;
			this.captchaButton.Click += new System.EventHandler(this.captchaButton_Click);
			// 
			// captchacodeField
			// 
			this.captchacodeField.Location = new System.Drawing.Point(97, 78);
			this.captchacodeField.MaxLength = 32767;
			this.captchacodeField.Name = "captchacodeField";
			this.captchacodeField.PasswordChar = '\0';
			this.captchacodeField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.captchacodeField.SelectedText = "";
			this.captchacodeField.Size = new System.Drawing.Size(206, 22);
			this.captchacodeField.TabIndex = 3;
			this.captchacodeField.UseSelectable = true;
			// 
			// usernameField
			// 
			this.usernameField.Location = new System.Drawing.Point(104, 41);
			this.usernameField.MaxLength = 32767;
			this.usernameField.Name = "usernameField";
			this.usernameField.PasswordChar = '\0';
			this.usernameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.usernameField.SelectedText = "";
			this.usernameField.Size = new System.Drawing.Size(177, 22);
			this.usernameField.TabIndex = 0;
			this.usernameField.UseSelectable = true;
			// 
			// captchaTabLabel
			// 
			this.captchaTabLabel.AutoSize = true;
			this.captchaTabLabel.Location = new System.Drawing.Point(97, 10);
			this.captchaTabLabel.Name = "captchaTabLabel";
			this.captchaTabLabel.Size = new System.Drawing.Size(249, 19);
			this.captchaTabLabel.TabIndex = 0;
			this.captchaTabLabel.Text = "Enter the characters you see in the image";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(403, 489);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 0;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseSelectable = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.loginTab);
			this.tabs.Controls.Add(this.tradesTab);
			this.tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabs.ItemSize = new System.Drawing.Size(120, 18);
			this.tabs.Location = new System.Drawing.Point(15, 63);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 1;
			this.tabs.Size = new System.Drawing.Size(464, 406);
			this.tabs.TabIndex = 0;
			this.tabs.UseSelectable = true;
			this.tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
			// 
			// loginTab
			// 
			this.loginTab.BackColor = System.Drawing.SystemColors.Control;
			this.loginTab.Controls.Add(this.rememberBox);
			this.loginTab.Controls.Add(this.captchaGroup);
			this.loginTab.Controls.Add(this.loginButton);
			this.loginTab.Controls.Add(this.passwordField);
			this.loginTab.Controls.Add(this.usernameField);
			this.loginTab.Controls.Add(this.passwordLabel);
			this.loginTab.Controls.Add(this.usernameLabel);
			this.loginTab.Controls.Add(this.loginTabLabel);
			this.loginTab.ForeColor = System.Drawing.SystemColors.ControlText;
			this.loginTab.HorizontalScrollbarBarColor = true;
			this.loginTab.HorizontalScrollbarHighlightOnWheel = false;
			this.loginTab.HorizontalScrollbarSize = 10;
			this.loginTab.Location = new System.Drawing.Point(4, 22);
			this.loginTab.Name = "loginTab";
			this.loginTab.Padding = new System.Windows.Forms.Padding(3);
			this.loginTab.Size = new System.Drawing.Size(456, 380);
			this.loginTab.TabIndex = 0;
			this.loginTab.Tag = "";
			this.loginTab.Text = "Login";
			this.loginTab.VerticalScrollbarBarColor = true;
			this.loginTab.VerticalScrollbarHighlightOnWheel = false;
			this.loginTab.VerticalScrollbarSize = 10;
			// 
			// rememberBox
			// 
			this.rememberBox.AutoSize = true;
			this.rememberBox.Location = new System.Drawing.Point(104, 97);
			this.rememberBox.Name = "rememberBox";
			this.rememberBox.Size = new System.Drawing.Size(103, 15);
			this.rememberBox.TabIndex = 2;
			this.rememberBox.Text = "remember me?";
			this.rememberBox.UseSelectable = true;
			// 
			// captchaGroup
			// 
			this.captchaGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.captchaGroup.Controls.Add(this.captchaBox);
			this.captchaGroup.Controls.Add(this.captchaTabLabel);
			this.captchaGroup.Controls.Add(this.captchacodeField);
			this.captchaGroup.Controls.Add(this.captchaButton);
			this.captchaGroup.Location = new System.Drawing.Point(7, 120);
			this.captchaGroup.Name = "captchaGroup";
			this.captchaGroup.Size = new System.Drawing.Size(431, 167);
			this.captchaGroup.TabIndex = 4;
			this.captchaGroup.Visible = false;
			// 
			// captchaBox
			// 
			this.captchaBox.Location = new System.Drawing.Point(97, 32);
			this.captchaBox.Name = "captchaBox";
			this.captchaBox.Size = new System.Drawing.Size(206, 40);
			this.captchaBox.TabIndex = 3;
			this.captchaBox.TabStop = false;
			// 
			// passwordField
			// 
			this.passwordField.Location = new System.Drawing.Point(104, 69);
			this.passwordField.MaxLength = 32767;
			this.passwordField.Name = "passwordField";
			this.passwordField.PasswordChar = '●';
			this.passwordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordField.SelectedText = "";
			this.passwordField.Size = new System.Drawing.Size(177, 22);
			this.passwordField.TabIndex = 1;
			this.passwordField.UseSelectable = true;
			this.passwordField.UseSystemPasswordChar = true;
			// 
			// passwordLabel
			// 
			this.passwordLabel.Location = new System.Drawing.Point(18, 69);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(80, 25);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password";
			// 
			// usernameLabel
			// 
			this.usernameLabel.Location = new System.Drawing.Point(18, 42);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(80, 25);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "Username";
			// 
			// tradesTab
			// 
			this.tradesTab.AutoScroll = true;
			this.tradesTab.Controls.Add(this.tradesContainer);
			this.tradesTab.Controls.Add(this.browserContainer);
			this.tradesTab.HorizontalScrollbar = true;
			this.tradesTab.HorizontalScrollbarBarColor = true;
			this.tradesTab.HorizontalScrollbarHighlightOnWheel = false;
			this.tradesTab.HorizontalScrollbarSize = 10;
			this.tradesTab.Location = new System.Drawing.Point(4, 22);
			this.tradesTab.Name = "tradesTab";
			this.tradesTab.Size = new System.Drawing.Size(456, 380);
			this.tradesTab.TabIndex = 2;
			this.tradesTab.Tag = "";
			this.tradesTab.Text = "Confirmations";
			this.tradesTab.VerticalScrollbar = true;
			this.tradesTab.VerticalScrollbarBarColor = true;
			this.tradesTab.VerticalScrollbarHighlightOnWheel = false;
			this.tradesTab.VerticalScrollbarSize = 10;
			// 
			// tradesContainer
			// 
			this.tradesContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tradesContainer.AutoScroll = true;
			this.tradesContainer.BackColor = System.Drawing.SystemColors.Window;
			this.tradesContainer.Controls.Add(this.tradePanelMaster);
			this.tradesContainer.Controls.Add(this.tradesEmptyLabel);
			this.tradesContainer.Location = new System.Drawing.Point(5, 5);
			this.tradesContainer.Name = "tradesContainer";
			this.tradesContainer.Size = new System.Drawing.Size(440, 230);
			this.tradesContainer.TabIndex = 5;
			// 
			// tradePanelMaster
			// 
			this.tradePanelMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tradePanelMaster.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tradePanelMaster.Controls.Add(this.tradeSep);
			this.tradePanelMaster.Controls.Add(this.tradeLabel);
			this.tradePanelMaster.Controls.Add(this.tradeImage);
			this.tradePanelMaster.Controls.Add(this.tradeReject);
			this.tradePanelMaster.Controls.Add(this.tradeAccept);
			this.tradePanelMaster.Controls.Add(this.tradeStatus);
			this.tradePanelMaster.Location = new System.Drawing.Point(0, 0);
			this.tradePanelMaster.Name = "tradePanelMaster";
			this.tradePanelMaster.Size = new System.Drawing.Size(440, 79);
			this.tradePanelMaster.TabIndex = 0;
			// 
			// tradeSep
			// 
			this.tradeSep.Image = global::WinAuth.Properties.Resources.BluePixel;
			this.tradeSep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tradeSep.Location = new System.Drawing.Point(0, 76);
			this.tradeSep.Name = "tradeSep";
			this.tradeSep.Size = new System.Drawing.Size(448, 1);
			this.tradeSep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tradeSep.TabIndex = 6;
			this.tradeSep.TabStop = false;
			// 
			// tradeLabel
			// 
			this.tradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tradeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tradeLabel.Location = new System.Drawing.Point(46, 10);
			this.tradeLabel.Name = "tradeLabel";
			this.tradeLabel.Size = new System.Drawing.Size(271, 61);
			this.tradeLabel.TabIndex = 4;
			this.tradeLabel.Text = "metroLabel1";
			// 
			// tradeImage
			// 
			this.tradeImage.Location = new System.Drawing.Point(4, 12);
			this.tradeImage.Name = "tradeImage";
			this.tradeImage.Size = new System.Drawing.Size(36, 36);
			this.tradeImage.TabIndex = 3;
			this.tradeImage.TabStop = false;
			// 
			// tradeReject
			// 
			this.tradeReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tradeReject.BackColor = System.Drawing.SystemColors.Control;
			this.tradeReject.Location = new System.Drawing.Point(348, 39);
			this.tradeReject.Name = "tradeReject";
			this.tradeReject.Size = new System.Drawing.Size(75, 23);
			this.tradeReject.TabIndex = 1;
			this.tradeReject.Text = "Reject";
			this.tradeReject.UseSelectable = true;
			this.tradeReject.Click += new System.EventHandler(this.tradeReject_Click);
			// 
			// tradeAccept
			// 
			this.tradeAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tradeAccept.BackColor = System.Drawing.SystemColors.Control;
			this.tradeAccept.Location = new System.Drawing.Point(348, 10);
			this.tradeAccept.Name = "tradeAccept";
			this.tradeAccept.Size = new System.Drawing.Size(75, 23);
			this.tradeAccept.TabIndex = 0;
			this.tradeAccept.Text = "Accept";
			this.tradeAccept.UseSelectable = true;
			this.tradeAccept.Click += new System.EventHandler(this.tradeAccept_Click);
			// 
			// tradeStatus
			// 
			this.tradeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tradeStatus.Location = new System.Drawing.Point(323, 11);
			this.tradeStatus.Name = "tradeStatus";
			this.tradeStatus.Size = new System.Drawing.Size(99, 28);
			this.tradeStatus.TabIndex = 4;
			this.tradeStatus.Text = "tradeStatus";
			this.tradeStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.tradeStatus.Visible = false;
			// 
			// tradesEmptyLabel
			// 
			this.tradesEmptyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tradesEmptyLabel.Location = new System.Drawing.Point(0, 0);
			this.tradesEmptyLabel.Name = "tradesEmptyLabel";
			this.tradesEmptyLabel.Size = new System.Drawing.Size(383, 29);
			this.tradesEmptyLabel.TabIndex = 4;
			this.tradesEmptyLabel.Text = "You have no trade confirmations";
			this.tradesEmptyLabel.Visible = false;
			// 
			// browserContainer
			// 
			this.browserContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.browserContainer.BackColor = System.Drawing.SystemColors.Window;
			this.browserContainer.Location = new System.Drawing.Point(5, 241);
			this.browserContainer.Name = "browserContainer";
			this.browserContainer.Size = new System.Drawing.Size(440, 145);
			this.browserContainer.TabIndex = 5;
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.closeButton.Location = new System.Drawing.Point(324, 489);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "Close";
			this.closeButton.UseSelectable = true;
			this.closeButton.Visible = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// ShowSteamTradesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(501, 535);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.cancelButton);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "ShowSteamTradesForm";
			this.ShowIcon = false;
			this.Text = "Steam Confirmations";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowSteamTradesForm_FormClosing);
			this.Load += new System.EventHandler(this.ShowSteamTradesForm_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowSteamTradesForm_KeyPress);
			this.tabs.ResumeLayout(false);
			this.loginTab.ResumeLayout(false);
			this.loginTab.PerformLayout();
			this.captchaGroup.ResumeLayout(false);
			this.captchaGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.captchaBox)).EndInit();
			this.tradesTab.ResumeLayout(false);
			this.tradesContainer.ResumeLayout(false);
			this.tradePanelMaster.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tradeSep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tradeImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel loginTabLabel;
		private MetroFramework.Controls.MetroButton loginButton;
		private MetroFramework.Controls.MetroLabel captchaTabLabel;
		private MetroFramework.Controls.MetroButton cancelButton;
		private MetroFramework.Controls.MetroTextBox captchacodeField;
		private MetroFramework.Controls.MetroTextBox usernameField;
		private MetroFramework.Controls.MetroButton captchaButton;
		private MetroFramework.Controls.MetroTabControl tabs;
		private MetroFramework.Controls.MetroTabPage loginTab;
		private MetroFramework.Controls.MetroLabel passwordLabel;
		private MetroFramework.Controls.MetroLabel usernameLabel;
		private MetroFramework.Controls.MetroTextBox passwordField;
		private MetroFramework.Controls.MetroTabPage tradesTab;
		private System.Windows.Forms.PictureBox captchaBox;
		private System.Windows.Forms.Panel captchaGroup;
		private MetroFramework.Controls.MetroButton closeButton;
		private System.Windows.Forms.Panel tradePanelMaster;
		private System.Windows.Forms.PictureBox tradeImage;
		private MetroFramework.Controls.MetroButton tradeReject;
		private MetroFramework.Controls.MetroButton tradeAccept;
		private MetroFramework.Controls.MetroLabel tradeLabel;
		private System.Windows.Forms.PictureBox tradeSep;
		private MetroFramework.Controls.MetroLabel tradeStatus;
		private MetroFramework.Controls.MetroLabel tradesEmptyLabel;
		private System.Windows.Forms.Panel browserContainer;
		private System.Windows.Forms.Panel tradesContainer;
		private MetroFramework.Controls.MetroCheckBox rememberBox;
	}
}