using INI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestApp
{
	internal class SettingsObject
	{
		protected internal Boolean autoUpdate;


		public SettingsObject(String path)
		{
			autoUpdate = true;
		}

		public void loadFromSettings(Settings sts)
		{
			autoUpdate = sts.pg4.settings4_4_chkupd.Value;
		}

		public void writeToSettings(Settings sts)
		{
			sts.pg4.settings4_4_chkupd.Value = autoUpdate;
		}

		public void loadFromIni()
		{
			autoUpdate = Convert.ToBoolean(Convert.ToInt32(ini.INIReadValue("Tab_4", "Auto_Update")));
		}

		public void writeToIni()
		{
			ini.INIWriteValue("Tab_4", "Auto_Update", (Convert.ToInt32(autoUpdate)).ToString());
		}
	}
}
