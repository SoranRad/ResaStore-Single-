using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Activator
{
	public static class CryptographyHelper
	{
		private static bool _optimalAsymmetricEncryptionPadding = false;

		#region Fields
		//These keys are of 2048byte
		public static string PublicKey = "PFJTQUtleVZhbHVlPjxNb2R1bHVzPnpvWnRYQnVQY0U2MXhUaW1YcklCQWFSckFNQ2xSVm1jODIrSXRyTS9TeHBqV01kaHRqNW5NQ3ZCUjVLT0cxbWk0eGk1U3ZaVWpyZDFmeVU4RjMyTGtoSXJPckJVdTJSR3QwN1dSTmVaU2w0NnpXYUpBSEZSSWtQeDVuZE96TGlCZG1CZ29ncnJqeDFiVVdsS0s1TUtqOTlDSDhiRWhFdjFLOWxsbmxrZFRnaz08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

		public static string PrivateKey = "PFJTQUtleVZhbHVlPjxNb2R1bHVzPnpvWnRYQnVQY0U2MXhUaW1YcklCQWFSckFNQ2xSVm1jODIrSXRyTS9TeHBqV01kaHRqNW5NQ3ZCUjVLT0cxbWk0eGk1U3ZaVWpyZDFmeVU4RjMyTGtoSXJPckJVdTJSR3QwN1dSTmVaU2w0NnpXYUpBSEZSSWtQeDVuZE96TGlCZG1CZ29ncnJqeDFiVVdsS0s1TUtqOTlDSDhiRWhFdjFLOWxsbmxrZFRnaz08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjxQPjUva2ZyNWJTSFdYYUZCMEQwdksvZFlFWEtpZE80ZzNBNWdKOW5sa0o3dmtQa1EzT0xVN1JiTkx5aG5sTC9WUzJWYmFSWjhXVWxoVGpGUFpmUXVkRkV3PT08L1A+PFE+NCtxSmN1bFVYWGRwdUZRMlhBamNEbXpuY2twZ25FbllNUXNGQUZzaW9qVmJQM0VvZVJYeE9QenZ3djlXMk5oQjRGbEJuZ1FtcXJEeTIxK0Y3cjd2OHc9PTwvUT48RFA+Y0xtUDJ6ellOKzd4cllwMy9EOTRLSHFscmhkUjd1bXVEbGV4Z1l4VkZtcXpWTkszbVM3TytDbitMcmlzNDVzUnk4OGZFNlZnMGhtdVM5WjVia0tDUHc9PTwvRFA+PERRPmdCbWJwWFdWa0c4RWdiRDdXS0UySmZsNTRKZ0RVdlNDU1paYStrYys0UkxDTlpkQlcwVkU3blhqd0tMSlNsbktOUEdWMnQyVWFnM0lnaHBmYWIveGx3PT08L0RRPjxJbnZlcnNlUT5HZGFJaDIxMS9rQXl5am5EWVBia0syTDFtT2owR3N1R3ZsUC83TGhLOGp6eGVCTkhNQVlGblJXVDhWQXJHMDliVmkzTitxNmFzTG9uZGRFcjZtOWxUdz09PC9JbnZlcnNlUT48RD5XR2kxY2dPZVVNNXhBNzl2Z1FRa2FDYVJZOTRVSWU3dHdFeFRzeHBpa3V6MThIQlJ4T2xMMVJRMkJrU1hydCtkV2lnZ1VoWEhOdDBVWUZ4NUwva2ZnS0NGVEtyeGdObTJ1YXJ0UkRYUVlxU3kwcWN5ZWdXNWl0NTcycjVEMnlGYWJJMm9abTEvUXhJOXoxRklxb2RuT09CR1Z4TVppR3pRVTYrVWVvZUpkVjA9PC9EPjwvUlNBS2V5VmFsdWU+";
		public static int KeySize = 1024;
		#endregion

		#region Methods
		public static string Encrypt(string plainText)
		{
			//int keySize = 0;
			//string publicKeyXml = "";

			//GetKeyFromEncryptionString(PublicKey, out keySize, out publicKeyXml);

			//var encrypted = Encrypt (Encoding.UTF8.GetBytes(plainText), keySize, publicKeyXml);
			var key = Encoding.UTF8.GetString(Convert.FromBase64String(PublicKey));
			var encrypted = Encrypt(Encoding.UTF8.GetBytes(plainText), KeySize, key);

			return Convert.ToBase64String(encrypted);
		}
		private static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
		{
			if (data == null || data.Length == 0)
				throw new ArgumentException(@"Data are empty", "data");

			int maxLength = GetMaxDataLength(keySize);

			if (data.Length > maxLength)
				throw new ArgumentException
					(String.Format(@"Maximum data length is {0}", maxLength), "data");

			if (!IsKeySizeValid(keySize))
				throw new ArgumentException("Key size is not valid", "keySize");

			if (String.IsNullOrEmpty(publicKeyXml))
				throw new ArgumentException("Key is null or empty", "publicKeyXml");

			using (var provider = new RSACryptoServiceProvider(keySize))
			{
				provider.FromXmlString(publicKeyXml);
				return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
			}
		}

		public static string Decrypt(string encryptedText)
		{
			//int keySize = 0;
			//string publicAndPrivateKeyXml = "";

			//GetKeyFromEncryptionString(PrivateKey, out keySize, out publicAndPrivateKeyXml);
			var key = Encoding.UTF8.GetString(Convert.FromBase64String(PrivateKey));
			var decrypted = Decrypt(Convert.FromBase64String(encryptedText), KeySize, key);

			return Encoding.UTF8.GetString(decrypted);
		}
		private static byte[] Decrypt(byte[] data, int keySize, string publicAndPrivateKeyXml)
		{
			if (data == null || data.Length == 0)
				throw new ArgumentException("Data are empty", "data");

			if (!IsKeySizeValid(keySize))
				throw new ArgumentException("Key size is not valid", "keySize");

			if (String.IsNullOrEmpty(publicAndPrivateKeyXml))
				throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");

			using (var provider = new RSACryptoServiceProvider(keySize))
			{
				provider.FromXmlString(publicAndPrivateKeyXml);
				return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
			}
		}

		private static int GetMaxDataLength(int keySize)
		{
			if (_optimalAsymmetricEncryptionPadding)
			{
				return ((keySize - 384) / 8) + 7;
			}
			return ((keySize - 384) / 8) + 37;
		}
		private static bool IsKeySizeValid(int keySize)
		{
			return keySize >= 384 && keySize <= 16384 && keySize % 8 == 0;
		}
		private static void GetKeyFromEncryptionString(string rawkey, out int keySize, out string xmlKey)
		{
			keySize = 0;
			xmlKey = "";

			if (!string.IsNullOrEmpty(rawkey))
			{
				byte[] keyBytes = Convert.FromBase64String(rawkey);
				var stringKey = Encoding.UTF8.GetString(keyBytes);
				xmlKey = stringKey;
				//if (stringKey.Contains("!"))
				//{
				//    var splittedValues = stringKey.Split(new char[] { '!' }, 2);

				//    try
				//    {
				//        keySize = int.Parse(splittedValues[0]);
				//        xmlKey  = splittedValues[1];
				//    }
				//    catch (Exception e) { }
				//}
			}
		}
		#endregion
	}
}
