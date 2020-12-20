using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TestApp.AutoUpdater
{
	internal enum HashType
	{
		MD5,
		SHA1,
		SHA512
	}

	internal static class Hash
	{
		internal static String HashFile(String filePath, HashType algo)
		{
			switch (algo)
			{
				case HashType.MD5:
					return MakeHashString(MD5.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
				case HashType.SHA1:
					return MakeHashString(SHA1.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
				case HashType.SHA512:
					return MakeHashString(SHA512.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
				default:
					return "";
			}
		}

		private static string MakeHashString(Byte[] hash)
		{
			StringBuilder s = new StringBuilder();

			foreach (Byte b in hash)
				s.Append(b.ToString("x2").ToLower());

			return s.ToString();
		}
	}
}
