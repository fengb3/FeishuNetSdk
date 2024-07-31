using System.Security.Cryptography;
using System.Text;

namespace FeishuNetSdk.FeishuEvent;

/// <summary>
/// AES 加密解密
/// https://open.feishu.cn/document/server-docs/event-subscription-guide/event-subscription-configure-/encrypt-key-encryption-configuration-case#bc6a8146-1
/// </summary>
public class AESCipher
{
	const   int    BlockSize = 16;
	private byte[] key;

	public AESCipher(string key)
	{
		this.key = SHA256Hash(key);
	}

	public string DecryptString(string enc)
	{
		byte[] encBytes        = Convert.FromBase64String(enc);
		Aes    rijndaelManaged = Aes.Create();
		rijndaelManaged.Key  = this.key;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.IV   = encBytes.Take(BlockSize).ToArray();
		ICryptoTransform transform  = rijndaelManaged.CreateDecryptor();
		byte[]           blockBytes = transform.TransformFinalBlock(encBytes, BlockSize, encBytes.Length - BlockSize);
		return Encoding.UTF8.GetString(blockBytes);
	}

	public static byte[] SHA256Hash(string str)
	{
		byte[] bytes      = Encoding.UTF8.GetBytes(str);
		SHA256 shaManaged = SHA256.Create(); // var gg=  new SHA256Managed();
		return shaManaged.ComputeHash(bytes);
	}
}