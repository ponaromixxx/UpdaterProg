﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestApp.AutoUpdater
{
	internal partial class AutoUpdateAcceptForm : DevComponents.DotNetBar.Metro.MetroForm
	{
		private AutoUpdatable applicationInfo;

		private AutoUpdateXml updateInfo;

//        private Language lang;

		internal AutoUpdateAcceptForm(AutoUpdatable applicationInfo, AutoUpdateXml updateInfo)
		{
			InitializeComponent();

			this.applicationInfo = applicationInfo;
			this.updateInfo = updateInfo;
//            this.lang = applicationInfo.Lang;

//			  this.Text = lang.getString("update_found_title");

//            this.lblAppName.Text = lang.getString("app_name");
//            this.lblUpdateAvail.Text = lang.getString("update_found");
//            this.lblNewVersion_label.Text = lang.getString("update_new");
//            this.lblCurVersion_label.Text = lang.getString("update_cur");
//            this.lblDescription.Text = lang.getString("update_description");

//            this.btnYes.Text = lang.getString("button_ok");
//            this.btnNo.Text = lang.getString("button_cancel");

			this.Text = ("Update found");

			this.lblAppName.Text = ("TestApp");
			this.lblUpdateAvail.Text = ("Update found");
			this.lblNewVersion_label.Text = ("New Version");
			this.lblCurVersion_label.Text = ("Cur Version");
			this.lblDescription.Text = ("Update Description");

			this.btnYes.Text = ("OK");
			this.btnNo.Text = ("Cancel");

			// Assigns the icon if it isn't null
			if (this.applicationInfo.ApplicationIcon != null)
				this.Icon = this.applicationInfo.ApplicationIcon;

			// Adds the current version # to the form
			this.lblCurVersion.Text = applicationInfo.ApplicationAssembly.GetName().Version.ToString();

			// Adds the update version # to the form
			this.lblNewVersion.Text = this.updateInfo.Version.ToString();

			// Fill in update info
			this.txtDescription.Text = updateInfo.Description;
            //this.txtDescription.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll;
            //Size txtDescription_size = this.txtDescription.Size;
            //this.txtDescription.Size = new Size(txtDescription_size.Width /3, txtDescription_size.Height /3);
            
            // DotNetBar richTextBoxEx doesn't appear correctly under high DPI
            // Use normal richTextBox instead!
            this.richTextBox1.Text = updateInfo.Description;

            // DPI settings
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;

            // Set UI Font according to language
//            lang.setFont(this.Controls);
//            Font = new Font(lang.getFont(), Font.Size, Font.Style);
        }

		private void btnYes_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
			this.Close();
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		private void txtDescription_KeyDown(object sender, KeyEventArgs e)
		{
			// Only allow Cntrl - C to copy text
			if (!(e.Control && e.KeyCode == Keys.C))
				e.SuppressKeyPress = true;
		}
	}
}
