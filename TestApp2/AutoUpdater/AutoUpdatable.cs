using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TestApp.AutoUpdater
{
	public interface AutoUpdatable
	{
		String ApplicationName { get; }
		String ApplicationID { get; }
		Assembly ApplicationAssembly { get; }
		Icon ApplicationIcon { get; }
		Uri UpdateXmlLocation { get; }
		Form Context { get; }
	}
}
