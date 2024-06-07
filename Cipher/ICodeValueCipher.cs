namespace Cipher
{
    public interface ICodeValueCipher
    {
        string Decrypt(string message, string key);

        string Encrypt(string message, string key);
    }
}