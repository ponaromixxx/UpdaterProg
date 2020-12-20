using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm, AutoUpdater.AutoUpdatable
    {
		private static String NAMESPACE = "TestApp";
		private static Assembly a = Assembly.Load(NAMESPACE);

		#region AutoUpdate
		private AutoUpdater.AutoUpdater updater;

		public string ApplicationName
		{
			get { return NAMESPACE; }
		}

		public string ApplicationID
		{
			get { return NAMESPACE; }
		}

		public Assembly ApplicationAssembly
		{
			get { return Assembly.GetExecutingAssembly(); }
		}

		public Icon ApplicationIcon
		{
			get { return this.Icon; }
		}

		public Uri UpdateXmlLocation
		{
			get { return new Uri("https://raw.githubusercontent.com/ponaromixxx/UpdaterProg/master/project.xml"); }
		}

		public Form Context
		{
			get { return this; }
		}
		#endregion

		public Form1()
        {
            InitializeComponent();
            updater = new AutoUpdater.AutoUpdater(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}
