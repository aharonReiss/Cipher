using System;

namespace Cipher
{
    public class CodeValueCipher : ICodeValueCipher
    {
        string charcters = "abcdefghijklmnopqrstuvwxyz";
        public string Encrypt(string message, string key)
        {
            try
            {   
                string newMessage = "";
                for (int i = 0; i < message.Length; i++)
                {
                    int indexOfCharcter = charcters.IndexOf(char.ToLower(message[i]));
                    char charToReplace = key[indexOfCharcter];
                    if (char.IsLower(message[i]))
                        newMessage += char.ToLower(charToReplace);
                    else
                        newMessage += charToReplace;
                }
                return newMessage;
            }
            catch 
            {
                throw new Exception("failed to encrypt");
            }
        }

        public string Decrypt(string message, string key)
        {
            try
            {   
                string realMessage = "";
                for (int i = 0; i < message.Length; i++)
                {
                    int indexOfCharcter = key.IndexOf(char.ToUpper(message[i]));
                    char charToReplace = charcters[indexOfCharcter];
                    if (char.IsUpper(message[i]))
                        realMessage += char.ToUpper(charToReplace);
                    else
                        realMessage += charToReplace;
                }
                return realMessage;
            }
            catch
            {
                throw new Exception("failed to dycrypt");
            }
        }
    }
}
