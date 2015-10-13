using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;
//using System.Array;


namespace PassManager
{
    //****************************************************************
    //***       Account File Format Description 
    //****************************************************************
    //
    // File Header:
    //                  accountname:  Account Name: 250 bytes
    //                  username:  Account username: 250 bytes
    //                  numPasswords: Number of Passwords: 4 bytes (up to 4 billion passwords muhahaha!)
    //                                NOTE: Will exposing the number of passwords in the list expose 
    //                                      a vulnerability? If so, encrypt the number of passwords as 
    //                                      the first value in the bulk list.

    //                  listSize:     Size, in bytes, of Bulk Encrypted Data (not sure neccessary)
    // File Data:
    //                  bulkList: Encrypted data with list of null terminated Username/Password
    //                            pairs.
    //
    //                  Unencrypted Password List Format:
    //                      
    //                          TaylorDeiaco [null] 27 [null][null] JeffFoxworth [null] bluecollar1234 [null][null]
    //

    public class UserPassPair
    {

        string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public UserPassPair()
        {
            _username = "Uninitialized";
            _password = "Uninitialized";
        }

        public UserPassPair(string username, string password)
        {
            //if (this == null)
            //{
            //    this = new UserPassPair(username, password);
            //}
            _username = username;
            _password = password;
        }

    }


    public class Safe
    {
        string m_accountName;
        string m_username;

        private string m_filepath;
        public string Filepath
        {
            get { return m_filepath; }
            set { m_filepath = value; }
        }

        int m_numPasswords;


        List<UserPassPair> pwBank;

        string mKey = "password";
        public string data;
        string encryptedData;
        string decryptedData;

        // List<string>
        //Master k 


        public Safe()
        {
            pwBank = new List<UserPassPair>();

        }


        public Safe(string masterKey)
        {
            pwBank = new List<UserPassPair>();
            mKey = masterKey;


        }

        ~Safe()
        { }

        public void LoadAccount(string username, string password)
        {
            //FileStream accountFileStream = new FileStream(username.ToString() + ".pmf", FileMode.Open, FileAccess.Read);

            //byte[] wDataAccountName;
            //byte[] wDataAccountNameLength;
            //byte[] wDataUsername;
            //byte[] wDataUsernameLength;

            if (!File.Exists(username.ToString() + ".pmf"))
            {
                MessageBox.Show("Account does not exist!", "Warning!");
                return;
            }

            //Debug.WriteLine("\n\n"+ username.ToString() + ".pmf");

            m_username = username.ToString() + ".pmf";

            byte[] pmf = ReadPMFIntoBuffer(username.ToString() + ".pmf");

            Debug.WriteLine(System.Text.Encoding.UTF8.GetString(pmf));


        }

        public void SaveAccount()
        {
            //  byte[] accountRaw = LoadPMF(m_filepath);

            //Load account values from raw file data


        }


        public void LoadPMFFile(string filepath)
        {
            ////Load entire .pmf file into a byte array buffer
            //byte[] pmfBuffer = ReadPMFIntoBuffer(filepath);

            ////Analyze .pmf file byte by byte.
            //foreach(byte b in pmfBuffer)
            //{
            //    //************************************************************************************************************
            //    //***       PassManager File (.pmf) Format Description 
            //    //************************************************************************************************************
            //    //
            //    // File Header:
            //    //                  accountname:  Account Name: 250 bytes
            //    //                  username:  Account username: 250 bytes
            //    //                  numPasswords: Number of Passwords: 4 bytes (up to 4 billion passwords muhahaha!)
            //    //                                numPasswords == 0  //Indicates a new account.
            //    //                                NOTE: Will exposing the number of passwords in the list expose 
            //    //                                      a vulnerability? If so, encrypt the number of passwords as 
            //    //                                      the first value in the bulk list.
            //    //                  listSize:     Size, in bytes, of Bulk Encrypted Data (not sure neccessary)
            //    // File Data:
            //    //                  bulkList: Encrypted data with list of null terminated Username/Password
            //    //                            pairs.
            //    //
            //    //                  Unencrypted Password List Format:
            //    //                      
            //    //                  TaylorDeiaco [null] 27 [null][null] JeffFoxworth [null] bluecollar1234 [null][null]
            //    //
            //    //
            //    //
            //    //***********************************************************************************************************

            //    //Check for numbers..
            //    //if(b >= 48 && b <= 57)
            //    //{
            //    //    byte[] numberBuffer  = {0,0,0,0,0,0,0,0};
            //    //    int count = 8;
            //    //    numberBuffer[0] = pmfBuffer[b.

            //    //}
            using (FileStream accountFileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(accountFileStream))
                {
                    uint accountNameLength = 0, usernameLength = 0;
                    accountNameLength = reader.ReadUInt32();
                    string accountName = reader.ReadString();
                    usernameLength = reader.ReadUInt32();
                    string userName = reader.ReadString();

                    MessageBox.Show("Account Name: " + accountName + " and Username: " + userName);



                }
            }
        }
        public void CreateAccount(string accountName, string username, string password)
        {
            m_accountName = accountName;
            m_username = username;

            WritePMFFile(accountName, username);

        }

        public void WritePMFFile(string accountName, string username)
        {

            if (File.Exists(username.ToString() + ".pmf"))
            {
                File.Delete(username.ToString() + ".pmf");
            }
            using (FileStream accountFileStream = new FileStream(username.ToString() + ".pmf", FileMode.CreateNew, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(accountFileStream))
                {
                    m_filepath = username.ToString() + ".pmf";
                    //************************************************************************************************************
                    //***       PassManager File (.pmf) Format Description 
                    //************************************************************************************************************
                    //
                    // File Header:
                    //                  accountname:  Account Name: 250 bytes
                    //                  username:  Account username: 250 bytes
                    //                  numPasswords: Number of Passwords: 4 bytes (up to 4 billion passwords muhahaha!)
                    //                                numPasswords == 0  //Indicates a new account.
                    //                                NOTE: Will exposing the number of passwords in the list expose 
                    //                                      a vulnerability? If so, encrypt the number of passwords as 
                    //                                      the first value in the bulk list.
                    //                  listSize:     Size, in bytes, of Bulk Encrypted Data (not sure neccessary)
                    // File Data:
                    //                  bulkList: Encrypted data with list of null terminated Username/Password
                    //                            pairs.
                    //
                    //                  Unencrypted Password List Format:
                    //                      
                    //                  TaylorDeiaco [null] 27 [null][null] JeffFoxworth [null] bluecollar1234 [null][null]
                    //
                    //
                    //
                    //***********************************************************************************************************

                    //Will want to use UNICODE for a more inclusive Username and Password set but for now just basic ASCII
                    //A UNICODE conversion will inset the first character with another 0 due to UNICODE being 16-bit, and 
                    //displaying that will not work being WriteLine will end when it sees the NULL terminator.

                    //byte[] wDataAccountName = System.Text.Encoding.Unicode.GetBytes(accountName);
                    //byte[] wDataAccountNameLength = System.Text.Encoding.Unicode.GetBytes(accountName.Length.ToString());
                    //byte[] wDataUsername = System.Text.Encoding.Unicode.GetBytes(username);
                    //byte[] wDataUsernameLength = System.Text.Encoding.Unicode.GetBytes(username.Length.ToString());

                    //byte[] wZero = System.Text.Encoding.Unicode.GetBytes("00000000");

                    byte[] wDataAccountName = System.Text.Encoding.ASCII.GetBytes(accountName);
                    //   byte[] wDataAccountNameLength = (byte)accountName.Length;//System.Text.Encoding.ASCII.GetBytes(accountName.Length.ToString());
                    byte[] wDataUsername = System.Text.Encoding.ASCII.GetBytes(username);
                    //   byte[] wDataUsernameLength = System.Text.Encoding.ASCII.GetBytes(username.Length.ToString());

                    byte[] wZero = System.Text.Encoding.ASCII.GetBytes("00000000");



                    // writer.Write(wDataAccountNameLength, 0, wDataAccountNameLength.Length);
                    writer.Write((uint)accountName.Length);
                    //writer.Write(wDataAccountName, 0, wDataAccountName.Length);
                    writer.Write(accountName);
                    // writer.Write(wDataUsernameLength, 0, wDataUsernameLength.Length);
                    writer.Write((uint)username.Length);
                    writer.Write(username);
                    //New account write numPasswords = 0

                    //writer.Close();

                    if (pwBank.Count == 0)
                    {
                        int zero = 0;
                        writer.Write(zero);
                        writer.Close();
                        return;
                    }





                    if (pwBank.Count > 99999999)
                    {
                        MessageBox.Show("Too many passwords, will only write first 99,999,999 passwords!");
                    }

                    //If passwords, write number of passwords 
                    byte[] numPasswords = System.Text.Encoding.ASCII.GetBytes(pwBank.Count.ToString("D8"));
                    writer.Write(numPasswords, 0, numPasswords.Length);

                    //Create password list segment
                    //Write all username/password pairs into one buffer, and then encrypt that buffer and 
                    //append the result to the .pmf file.
                    //                  Unencrypted Password List Format:
                    //                      
                    //                  TaylorDeiaco [null] 27 [null][null] JeffFoxworth [null] bluecollar1234 [null][null]

                    byte[] oneNull = { 0 };
                    byte[] twoNull = { 0, 0 };
                    int mainBufferSize = 0;

                    //Calculate mainBuffer size:
                    //size = Sum(Password[].Size) + Sum(Username[].Size)
                    foreach (UserPassPair pair in pwBank)
                    {
                        mainBufferSize += pair.Username.Length + pair.Password.Length + 3; //3 accounts for NULL delimiters
                    }

                    //Create main password/username buffer
                    using (MemoryStream mainBufferStream = new MemoryStream(mainBufferSize))
                    {

                        foreach (UserPassPair pair in pwBank)
                        {
                            byte[] writeUsername = System.Text.Encoding.ASCII.GetBytes(pair.Username);
                            byte[] writePassword = System.Text.Encoding.ASCII.GetBytes(pair.Password);

                            // Write the username 
                            mainBufferStream.Write(writeUsername, 0, writeUsername.Length);
                            //Insert single NULL delimiter
                            mainBufferStream.Write(oneNull, 0, 1);
                            //Write password
                            mainBufferStream.Write(writePassword, 0, writePassword.Length);
                            //Insert double NULL delimiter
                            mainBufferStream.Write(twoNull, 0, 2);
                        }

                        // Set the position to the beginning of the stream.
                        mainBufferStream.Seek(0, SeekOrigin.Begin);

                        //Write password list memory stream buffer into the mainListBuffer byte array
                        byte[] mainListBuffer = new byte[mainBufferSize];
                        mainBufferStream.Read(mainListBuffer, 0, mainBufferSize);

                        //Encrypt main list buffer array
                        byte[] encryptedList = Encrypt(mainListBuffer, mKey);

                        //write encrypted list buffer to the .pmf file
                        writer.Write(encryptedList, 0, encryptedList.Length);

                    }
                }
            }
        }




        public byte[] ReadPMFIntoBuffer(string filepath)
        {
            try
            {

                using (FileStream fsSource = new FileStream(filepath,
                    FileMode.Open, FileAccess.Read))
                {
                    Debug.WriteLine("Loading :" + fsSource.Length + " number of bytes from PMF file.");


                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    // Return buffer
                    return bytes;
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                return null;
            }
        }

        public void AddPassword(string username, string password)
        {
            pwBank.Add(new UserPassPair(username, password));
        }

        public void AddPassword(UserPassPair userpass)
        {
            pwBank.Add(userpass);
        }

        #region Encryption

        //Performs encryption on the key array
        //using "mKey"
        public void EncryptSafe()
        {
            //Create hash table with Master key
            //Encrypt hash table 
            //foreach (string pass in pwBank)
            //{
            //    data += pass;
            //}
            ////data = pwBank[0].ToString() + pwBank[1].ToString();
            //MessageBox.Show("Encrypting: \n" + data, "Securing");
            //encryptedData = Encrypt(data, mKey);
            //MessageBox.Show("Encrypted: \n" + encryptedData, "Securing");

            //FileStream fs = new FileStream("cryptoData.txt", FileMode.Create, FileAccess.ReadWrite);
            //fs.Write(Encoding.ASCII.GetBytes(data.ToString()), 0, Encoding.ASCII.GetByteCount(data.ToString()));
        }

        //Performs encryption on the key array
        //using "mKey"
        public void EncryptSafe(string password)
        {
            //Create hash table with Master key
            //Encrypt hash table 
            //foreach (string pass in pwBank)
            //{
            //    data += pass;
            //}
            ////data = pwBank[0].ToString() + pwBank[1].ToString();
            //MessageBox.Show("Encrypting: \n" + data, "Securing");
            //encryptedData = Encrypt(data, password);
            //MessageBox.Show("Encrypted: \n" + encryptedData, "Securing");
        }

        //Performs encryption on the key array
        public void DecryptSafe()
        {
            //Create hash table with Master key
            //Encrypt hash table \
            decryptedData = Decrypt(encryptedData, mKey);
            MessageBox.Show(decryptedData, "Decrypted Data:");
        }

        //Performs encryption on the key array
        public void DecryptSafe(string password)
        {
            //Create hash table with Master key
            //Encrypt hash table \
            decryptedData = Decrypt(encryptedData, password);
            MessageBox.Show(decryptedData, "Decrypted Data:");
        }




        // Encrypt a byte array into a byte array using a key and an IV 
        public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            // Create a MemoryStream to accept the encrypted bytes 
            MemoryStream ms = new MemoryStream();

            // Create a symmetric algorithm. 
            // We are going to use Rijndael because it is strong and
            // available on all platforms. 
            // You can use other algorithms, to do so substitute the
            // next line with something like 
            //      TripleDES alg = TripleDES.Create(); 
            Rijndael alg = Rijndael.Create();

            // Now set the key and the IV. 
            // We need the IV (Initialization Vector) because
            // the algorithm is operating in its default 
            // mode called CBC (Cipher Block Chaining).
            // The IV is XORed with the first block (8 byte) 
            // of the data before it is encrypted, and then each
            // encrypted block is XORed with the 
            // following block of plaintext.
            // This is done to make encryption more secure. 

            // There is also a mode called ECB which does not need an IV,
            // but it is much less secure. 
            alg.Key = Key;
            alg.IV = IV;

            // Create a CryptoStream through which we are going to be
            // pumping our data. 
            // CryptoStreamMode.Write means that we are going to be
            // writing data to the stream and the output will be written
            // in the MemoryStream we have provided. 
            CryptoStream cs = new CryptoStream(ms,
               alg.CreateEncryptor(), CryptoStreamMode.Write);

            // Write the data and make it do the encryption 
            cs.Write(clearData, 0, clearData.Length);

            // Close the crypto stream (or do FlushFinalBlock). 
            // This will tell it that we have done our encryption and
            // there is no more data coming in, 
            // and it is now a good time to apply the padding and
            // finalize the encryption process. 
            cs.Close();

            // Now get the encrypted data from the MemoryStream.
            // Some people make a mistake of using GetBuffer() here,
            // which is not the right way. 
            byte[] encryptedData = ms.ToArray();

            return encryptedData;
        }

        // Encrypt a string into a string using a password 
        //    Uses Encrypt(byte[], byte[], byte[]) 

        public static string Encrypt(string clearText, string Password)
        {
            // First we need to turn the input string into a byte array. 
            byte[] clearBytes =
              System.Text.Encoding.Unicode.GetBytes(clearText);

            // Then, we need to turn the password into Key and IV 
            // We are using salt to make it harder to guess our key
            // using a dictionary attack - 
            // trying to guess a password by enumerating all possible words. 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            // Now get the key/IV and do the encryption using the
            // function that accepts byte arrays. 
            // Using PasswordDeriveBytes object we are first getting
            // 32 bytes for the Key 
            // (the default Rijndael key length is 256bit = 32bytes)
            // and then 16 bytes for the IV. 
            // IV should always be the block size, which is by default
            // 16 bytes (128 bit) for Rijndael. 
            // If you are using DES/TripleDES/RC2 the block size is
            // 8 bytes and so should be the IV size. 
            // You can also read KeySize/BlockSize properties off
            // the algorithm to find out the sizes. 
            byte[] encryptedData = Encrypt(clearBytes,
                     pdb.GetBytes(32), pdb.GetBytes(16));

            // Now we need to turn the resulting byte array into a string. 
            // A common mistake would be to use an Encoding class for that.
            //It does not work because not all byte values can be
            // represented by characters. 
            // We are going to be using Base64 encoding that is designed
            //exactly for what we are trying to do. 
            return Convert.ToBase64String(encryptedData);

        }

        // Encrypt bytes into bytes using a password 
        //    Uses Encrypt(byte[], byte[], byte[]) 

        public static byte[] Encrypt(byte[] clearData, string Password)
        {
            // We need to turn the password into Key and IV. 
            // We are using salt to make it harder to guess our key
            // using a dictionary attack - 
            // trying to guess a password by enumerating all possible words. 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            // Now get the key/IV and do the encryption using the function
            // that accepts byte arrays. 
            // Using PasswordDeriveBytes object we are first getting
            // 32 bytes for the Key 
            // (the default Rijndael key length is 256bit = 32bytes)
            // and then 16 bytes for the IV. 
            // IV should always be the block size, which is by default
            // 16 bytes (128 bit) for Rijndael. 
            // If you are using DES/TripleDES/RC2 the block size is 8
            // bytes and so should be the IV size. 
            // You can also read KeySize/BlockSize properties off the
            // algorithm to find out the sizes. 
            return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));

        }

        // Encrypt a file into another file using a password 
        public static void Encrypt(string fileIn,
                    string fileOut, string Password)
        {

            // First we are going to open the file streams 
            FileStream fsIn = new FileStream(fileIn,
                FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut,
                FileMode.OpenOrCreate, FileAccess.Write);

            // Then we are going to derive a Key and an IV from the
            // Password and create an algorithm 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            Rijndael alg = Rijndael.Create();
            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            // Now create a crypto stream through which we are going
            // to be pumping data. 
            // Our fileOut is going to be receiving the encrypted bytes. 
            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateEncryptor(), CryptoStreamMode.Write);

            // Now will will initialize a buffer and will be processing
            // the input file in chunks. 
            // This is done to avoid reading the whole file (which can
            // be huge) into memory. 
            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                // read a chunk of data from the input file 
                bytesRead = fsIn.Read(buffer, 0, bufferLen);

                // encrypt it 
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            // close everything 

            // this will also close the unrelying fsOut stream
            cs.Close();
            fsIn.Close();
        }

        // Decrypt a byte array into a byte array using a key and an IV 
        public static byte[] Decrypt(byte[] cipherData,
                                    byte[] Key, byte[] IV)
        {
            // Create a MemoryStream that is going to accept the
            // decrypted bytes 
            MemoryStream ms = new MemoryStream();

            // Create a symmetric algorithm. 
            // We are going to use Rijndael because it is strong and
            // available on all platforms. 
            // You can use other algorithms, to do so substitute the next
            // line with something like 
            //     TripleDES alg = TripleDES.Create(); 
            Rijndael alg = Rijndael.Create();

            // Now set the key and the IV. 
            // We need the IV (Initialization Vector) because the algorithm
            // is operating in its default 
            // mode called CBC (Cipher Block Chaining). The IV is XORed with
            // the first block (8 byte) 
            // of the data after it is decrypted, and then each decrypted
            // block is XORed with the previous 
            // cipher block. This is done to make encryption more secure. 
            // There is also a mode called ECB which does not need an IV,
            // but it is much less secure. 
            alg.Key = Key;
            alg.IV = IV;

            // Create a CryptoStream through which we are going to be
            // pumping our data. 
            // CryptoStreamMode.Write means that we are going to be
            // writing data to the stream 
            // and the output will be written in the MemoryStream
            // we have provided. 
            CryptoStream cs = new CryptoStream(ms,
                alg.CreateDecryptor(), CryptoStreamMode.Write);

            // Write the data and make it do the decryption 
            cs.Write(cipherData, 0, cipherData.Length);

            // Close the crypto stream (or do FlushFinalBlock). 
            // This will tell it that we have done our decryption
            // and there is no more data coming in, 
            // and it is now a good time to remove the padding
            // and finalize the decryption process. 
            cs.Close();

            // Now get the decrypted data from the MemoryStream. 
            // Some people make a mistake of using GetBuffer() here,
            // which is not the right way. 
            byte[] decryptedData = ms.ToArray();

            return decryptedData;
        }

        // Decrypt a string into a string using a password 
        //    Uses Decrypt(byte[], byte[], byte[]) 

        public static string Decrypt(string cipherText, string Password)
        {
            // First we need to turn the input string into a byte array. 
            // We presume that Base64 encoding was used 
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            // Then, we need to turn the password into Key and IV 
            // We are using salt to make it harder to guess our key
            // using a dictionary attack - 
            // trying to guess a password by enumerating all possible words. 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            // Now get the key/IV and do the decryption using
            // the function that accepts byte arrays. 
            // Using PasswordDeriveBytes object we are first
            // getting 32 bytes for the Key 
            // (the default Rijndael key length is 256bit = 32bytes)
            // and then 16 bytes for the IV. 
            // IV should always be the block size, which is by
            // default 16 bytes (128 bit) for Rijndael. 
            // If you are using DES/TripleDES/RC2 the block size is
            // 8 bytes and so should be the IV size. 
            // You can also read KeySize/BlockSize properties off
            // the algorithm to find out the sizes. 
            byte[] decryptedData = Decrypt(cipherBytes,
                pdb.GetBytes(32), pdb.GetBytes(16));

            // Now we need to turn the resulting byte array into a string. 
            // A common mistake would be to use an Encoding class for that.
            // It does not work 
            // because not all byte values can be represented by characters. 
            // We are going to be using Base64 encoding that is 
            // designed exactly for what we are trying to do. 
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }

        // Decrypt bytes into bytes using a password 
        //    Uses Decrypt(byte[], byte[], byte[]) 

        public static byte[] Decrypt(byte[] cipherData, string Password)
        {
            // We need to turn the password into Key and IV. 
            // We are using salt to make it harder to guess our key
            // using a dictionary attack - 
            // trying to guess a password by enumerating all possible words. 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            // Now get the key/IV and do the Decryption using the 
            //function that accepts byte arrays. 
            // Using PasswordDeriveBytes object we are first getting
            // 32 bytes for the Key 
            // (the default Rijndael key length is 256bit = 32bytes)
            // and then 16 bytes for the IV. 
            // IV should always be the block size, which is by default
            // 16 bytes (128 bit) for Rijndael. 
            // If you are using DES/TripleDES/RC2 the block size is
            // 8 bytes and so should be the IV size. 

            // You can also read KeySize/BlockSize properties off the
            // algorithm to find out the sizes. 
            return Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16));
        }

        // Decrypt a file into another file using a password 
        public static void Decrypt(string fileIn,
                    string fileOut, string Password)
        {

            // First we are going to open the file streams 
            FileStream fsIn = new FileStream(fileIn,
                        FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut,
                        FileMode.OpenOrCreate, FileAccess.Write);

            // Then we are going to derive a Key and an IV from
            // the Password and create an algorithm 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            Rijndael alg = Rijndael.Create();

            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            // Now create a crypto stream through which we are going
            // to be pumping data. 
            // Our fileOut is going to be receiving the Decrypted bytes. 
            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateDecryptor(), CryptoStreamMode.Write);

            // Now will will initialize a buffer and will be 
            // processing the input file in chunks. 
            // This is done to avoid reading the whole file (which can be
            // huge) into memory. 
            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                // read a chunk of data from the input file 
                bytesRead = fsIn.Read(buffer, 0, bufferLen);

                // Decrypt it 
                cs.Write(buffer, 0, bytesRead);

            } while (bytesRead != 0);

            // close everything 
            cs.Close(); // this will also close the unrelying fsOut stream 
            fsIn.Close();
        }


        private static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, 100);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        private static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, 100);

                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
    }
        #endregion

}

