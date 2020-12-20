using DevComponents.DotNetBar;
using TestApp.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TestApp.AutoUpdater
{
	public class AutoUpdater
	{
		private AutoUpdatable applicationInfo;

//        private Language lang;

		private BackgroundWorker bgWorker;

//		private Boolean autoCheck;

		public AutoUpdater(AutoUpdatable applicationInfo)
		{
			this.applicationInfo = applicationInfo;
//            this.lang = applicationInfo.Lang;

			// Set up backgroundworker
			this.bgWorker = new BackgroundWorker();
			this.bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
			this.bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
		}

		public void DoUpdate()
		{
//			autoCheck = auto;

			if (!this.bgWorker.IsBusy)
				this.bgWorker.RunWorkerAsync(this.applicationInfo);
		}

		private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			AutoUpdatable application = (AutoUpdatable)e.Argument;

			// Check for update on server
			if (!AutoUpdateXml.ExistsOnServer(application.UpdateXmlLocation))
				e.Cancel = true;
			else // Parse update xml
				e.Result = AutoUpdateXml.Parse(application.UpdateXmlLocation, application.ApplicationID);
		}

		private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// If there is a file on the server
			if (!e.Cancelled)
			{
				AutoUpdateXml update = (AutoUpdateXml)e.Result;

				// Check if the update is not null and is a newer version than the current application
				if (update != null && update.IsNewerThan(this.applicationInfo.ApplicationAssembly.GetName().Version))
				{
					// Ask to accept the update
					if (new AutoUpdateAcceptForm(this.applicationInfo, update).ShowDialog(this.applicationInfo.Context) == DialogResult.Yes)
						this.DownloadUpdate(update); // Do the update
				}
				else
				{
//					if (!autoCheck)
//						MessageBoxEx.Show(this.applicationInfo.Context, lang.getString("autoUpdater_result_latest"));
						MessageBoxEx.Show(this.applicationInfo.Context, ("Latest version already!"));
				}
			}
			else
//				MessageBoxEx.Show(this.applicationInfo.Context, lang.getString("autoUpdater_result_none"));
				MessageBoxEx.Show(this.applicationInfo.Context, ("No update info found!"));
		}

		private void DownloadUpdate(AutoUpdateXml update)
		{
            AutoUpdateDownloadForm form = new AutoUpdateDownloadForm(this.applicationInfo, update.Uri, update.MD5, this.applicationInfo.ApplicationIcon);
			DialogResult result = form.ShowDialog(this.applicationInfo.Context);

			// Download update
			if (result == DialogResult.OK)
			{
				String currentPath = this.applicationInfo.ApplicationAssembly.Location;
				String newPath = Path.GetDirectoryName(currentPath) + "\\" + update.FileName;

				// "Install" it
                AutoClosingMessageBox.Show(this.applicationInfo.Context,
//                                          lang.getString("autoUpdater_msg_success"),
//                                          lang.getString("autoUpdater_msg_success_title"),
                                            ("Success!\n\nApplication restarts in 5 seconds!"),
                                            ("Success"),
                                            5000);
				UpdateApplication(form.TempFilePath, currentPath, newPath, update.LaunchArgs);

				Application.Exit();
			}
			else if (result == DialogResult.Abort)
			{
                MessageBoxEx.Show(this.applicationInfo.Context,
//									lang.getString("autoUpdater_msg_terminated"),
//									lang.getString("autoUpdater_msg_terminated_title"),
									("Update terminated!\n\nCannot complete update!"),
                                    ("Terminated"),
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
                MessageBoxEx.Show(this.applicationInfo.Context,
//                                  lang.getString("autoUpdater_msg_failed"),
//                                  lang.getString("autoUpdater_msg_failed_title"),
									("Update failed!\n\nPlease try again later!"),
									("Failed"),
									MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void UpdateApplication(String tempFilePath, String currentPath, String newPath, String launchArgs)
		{
			String argument = "/C choice /C Y /N /D Y /T 4 & Del /F /Q \"{0}\" & choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";

			ProcessStartInfo Info = new ProcessStartInfo();
			Info.Arguments = String.Format(argument, currentPath, tempFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath), launchArgs);
			Info.WindowStyle = ProcessWindowStyle.Hidden;
			Info.CreateNoWindow = true;
			Info.FileName = "cmd.exe";
			Process.Start(Info);
		}
	}
}
