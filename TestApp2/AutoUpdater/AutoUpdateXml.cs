using System;
using System.Net;
using System.Xml;

namespace TestApp.AutoUpdater
{
	internal class AutoUpdateXml
	{
		private Version version;
		private Uri uri;
		private String fileName;
		private String md5;
		private String description;
		private String launchArgs;

		internal Version Version
		{
			get { return this.version; }
		}

		internal Uri Uri
		{
			get { return this.uri; }
		}

		internal String FileName
		{
			get { return this.fileName; }
		}

		internal String MD5
		{
			get { return this.md5; }
		}

		internal String Description
		{
			get { return this.description; }
		}

		internal String LaunchArgs
		{
			get { return this.launchArgs; }
		}

		internal AutoUpdateXml(Version version, Uri uri, String fileName, String md5, String description, String launchArgs)
		{
			this.version = version;
			this.uri = uri;
			this.fileName = fileName;
			this.md5 = md5;
			this.description = description;
			this.launchArgs = launchArgs;
		}

		internal Boolean IsNewerThan(Version version)
		{
			return this.version > version;
		}

		internal static Boolean ExistsOnServer(Uri location)
		{
			try
			{
				// Request the update.xml
				HttpWebRequest req = (HttpWebRequest)WebRequest.Create(location.AbsoluteUri);
				// Read for response
				HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
				resp.Close();

				return resp.StatusCode == HttpStatusCode.OK;
			}
			catch { return false; }
		}

		internal static AutoUpdateXml Parse(Uri location, String appID)
		{
			Version version = null;
			String url = "", fileName = "", md5 = "", description = "", launchArgs = "";

			try
			{
				// Load the document
				ServicePointManager.ServerCertificateValidationCallback = (s, ce, ch, ssl) => true;
				XmlDocument doc = new XmlDocument();
				doc.Load(location.AbsoluteUri);

				// Gets the appId's node with the update info
				// This allows you to store all program's update nodes in one file
				XmlNode updateNode = doc.DocumentElement.SelectSingleNode("//update[@appID='" + appID + "']");

				// If the node doesn't exist, there is no update
				if (updateNode == null)
					return null;

				// Parse data
				version = Version.Parse(updateNode["version"].InnerText);
				url = updateNode["url"].InnerText;
				fileName = updateNode["fileName"].InnerText;
				md5 = updateNode["md5"].InnerText;
				description = updateNode["description"].InnerText;
				launchArgs = updateNode["launchArgs"].InnerText;

				return new AutoUpdateXml(version, new Uri(url), fileName, md5, description, launchArgs);
			}
			catch { return null; }
		}
	}
}
