using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Class2
/// </summary>
public class Class2
{
    string strhash;
    public void encrypt(string inputFilePath, string outputfilePath)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (FileStream fs = new FileStream(outputfilePath, FileMode.Create))
            {
                using (CryptoStream cs = new CryptoStream(fs, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    FileStream fsIn = new FileStream(inputFilePath, FileMode.Open);
                    int data;
                    while ((data = fsIn.ReadByte()) != -1)
                    {
                        cs.WriteByte((byte)data);
                    }
                }

            }
        }

    }
    public void decrypt(string inputFilePath, string outputfilePath)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (FileStream fs = new FileStream(inputFilePath, FileMode.Open))
            {
                using (CryptoStream cs = new CryptoStream(fs, encryptor.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (FileStream fsOut = new FileStream(outputfilePath, FileMode.Create))
                    {
                        int data;
                        while ((data = cs.ReadByte()) != -1)
                        {
                            fsOut.WriteByte((byte)data);
                        }
                    }
                }
            }
        }
    }
   public void encrypt2(string inputFilePath, string outputfilePath)
    {

        try
        {
            string password = @"myKey123"; // Your Key Here
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            string cryptFile = outputfilePath;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFilePath, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);


            fsIn.Close();
            cs.Close();
            fsCrypt.Close();
        }
        catch
        {
          
        }
    }
    ///<summary>
    /// Steve Lydford - 12/05/2008.
    ///
    /// Decrypts a file using Rijndael algorithm.
    ///</summary>
    ///<param name="inputFile"></param>
    ///<param name="outputFile"></param>
   public void decrypt2(string inputFilePath, string outputfilePath)
    {

        {
            string password = @"myKey123"; // Your Key Here

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            FileStream fsCrypt = new FileStream(inputFilePath, FileMode.Open);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputfilePath, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();

        }
    }
  public void encrypt1(string inputFilePath, string outputfilePath)
    {
        strhash ="WtechgartbjaWFSh";
        FileStream instream, outstream;
        CryptoStream crystream;
        TripleDESCryptoServiceProvider tdc = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        byte[] bytehash, bytetext;
        instream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
        outstream = new FileStream(outputfilePath, FileMode.Create, FileAccess.Write);

        bytehash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strhash));
        bytetext = File.ReadAllBytes(inputFilePath);
        md5.Clear();

        tdc.Key = bytehash;
        tdc.Mode = CipherMode.ECB;
        crystream = new CryptoStream(outstream, tdc.CreateEncryptor(), CryptoStreamMode.Write);
        int bytesread;
        long length, position = 0;
        length = instream.Length;

        bytetext = File.ReadAllBytes(inputFilePath);
        while (position < length)
        {
            bytesread = instream.Read(bytetext, 0, bytetext.Length);
            position += bytesread;
            crystream.Write(bytetext, 0, bytesread);
        }
        instream.Close();
        outstream.Close();
    }
    public void decrypt1(string inputFilePath, string outputfilePath)
    {
        strhash = "WtechgartbjaWFSh";
        FileStream instream, outstream;
        CryptoStream crystream;
        TripleDESCryptoServiceProvider tdc = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        byte[] bytehash, bytetext;
        instream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
        outstream = new FileStream(outputfilePath, FileMode.Create, FileAccess.Write);

        bytehash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strhash));
        bytetext = File.ReadAllBytes(inputFilePath);
        md5.Clear();

        tdc.Key = bytehash;
        tdc.Mode = CipherMode.ECB;
        crystream = new CryptoStream(outstream, tdc.CreateDecryptor(), CryptoStreamMode.Write);
        int bytesread;
        long length, position = 0;
        length = instream.Length;

        bytetext = File.ReadAllBytes(inputFilePath);
        while (position < length)
        {
            bytesread = instream.Read(bytetext, 0, bytetext.Length);
            position += bytesread;
            crystream.Write(bytetext, 0, bytesread);
        }
        instream.Close();
        outstream.Close();
    }
 

	}
   
