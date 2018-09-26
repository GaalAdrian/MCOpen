using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net.Sockets;

//=======================================\\
//                                        \\              
//               MCOPEN                    \\
//      github.com/Edwikehh/MCOpen          \\
//         discord.gg/582wZQJ [HU]           \\   
//                                            \\
//=============================================\\

namespace MCOpen
{
    public partial class MCOPENLauncher : Form
    {
        #region IP,PORT - EDIT HERE
        // 1. SERVER
        String serverOIP = "localhost";
        int serverOPort = 25565;

        // 2. SERVER
        String serverSIP = "localhost";
        int serverSPort = 25565;

        // 3. SERVER
        String serverTIP = "localhost";
        int serverTPort = 25565;
        #endregion

        string fmap; // your folder name (do not edit here)
        string appd; // appdata

        string folder
        {
            get {
                return Path.Combine(appd, fmap);
                }
        }

        public MCOPENLauncher()
        {
            appd = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            InitializeComponent();

            #region setup your launcher here [name, version, etc]
            fmap = ".MCOpen"; // enter your folder name
            labelUsername.Text = "USERNAME";
            launcherText.Text = "MCOPEN"; //launchername
            versionText.Text = "0.8v"; // launcher version
            btnLogin.Text = "START MINECRAFT";

            labelInfo.Hide();

            serverO.Text = "HUB";  // FIRST SERVER
            serverBtnO.Enabled = true; // PLAY BUTTON 
            serverOText.Text = "Lorem ipsum dolor sit \namet,consectetur adipiscin \nelit. Aliquam vestibulum \npurus at est \naccumsan bibendum.";
            serverOText.Enabled = true;

            serverS.Text = "SKYPVP";  // SECOND SERVER
            serverBtnS.Enabled = true; // PLAY BUTTON 
            serverSText.Text = "Lorem ipsum dolor sit \namet,consectetur adipiscin \nelit. Aliquam vestibulum \npurus at est \naccumsan bibendum.";
            serverSText.Enabled = true;

            serverT.Text = "MINIGAMES";  // THIRD SERVER
            serverBtnT.Enabled = true; // PLAY BUTTON 
            serverTText.Text = "Lorem ipsum dolor sit \namet,consectetur adipiscin \nelit. Aliquam vestibulum \npurus at est \naccumsan bibendum.";
            serverSText.Enabled = true;
            #endregion
        
        }

        #region do not edit
        // close
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // minimize
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // movable form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        // downloading minecraft & servers.dat updater
        private void Form1_Load(object sender, EventArgs e)
        {
            #region ping
            if (true) //ping:true
            {


                try
                {
                    using (var client = new TcpClient(serverOIP, serverOPort)) ;

                }
                catch (SocketException ex)
                {
                    serverBtnO.Enabled = false;
                    serverBtnO.Text = "OFFLINE";
                    //MessageBox.Show("Hiba a pingelesnel:'" + serverOIP + ":" + serverOPort.ToString() + "'");

                }

                try
                {
                    using (var client = new TcpClient(serverSIP, serverSPort)) ;

                }
                catch (SocketException ex)
                {
                    serverBtnS.Enabled = false;
                    serverBtnS.Text = "OFFLINE";
                    //MessageBox.Show("Hiba a pingelesnel:'" + serverOIP + ":" + serverOPort.ToString() + "'");

                }

                try
                {
                    using (var client = new TcpClient(serverTIP, serverTPort)) ;

                }
                catch (SocketException ex)
                {
                    serverBtnT.Enabled = false;
                    serverBtnT.Text = "OFFLINE";
                    //MessageBox.Show("Hiba a pingelesnel:'" + serverOIP + ":" + serverOPort.ToString() + "'");

                }
            }
            #endregion

            WebClient wc = new WebClient();
            Uri surl = new Uri("https://www.dropbox.com/s/1lhv8dqrafu58tb/servers.dat?dl=1"); 
            try {
                wc.DownloadFileAsync(surl, folder + "\\servers.dat");

                // creating new folder if does not exist
                bool exists = Directory.Exists(folder);
                if (!exists)
                {
                    labelInfo.Text = "Letöltés folyamatban..."; //downloading isin progress
                    labelInfo.Show();
                    btnLogin.Enabled = false;
                    serverBtnO.Enabled = false;
                    serverBtnS.Enabled = false;
                    serverBtnT.Enabled = false;
                    MessageBox.Show("Letöltés megkezdődött! Ez eltarthat néhány percig is..."); // downloading is started! 
                    Directory.CreateDirectory(folder);

                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                    Uri durl = new Uri("https://www.dropbox.com/s/uhpsm7pfj04nbp8/mcopen.zip?dl=1");
                    wc.DownloadFileAsync(durl, folder + "\\mcopen.zip");
                }
                else {
                    // ¯\_(ツ)_/¯
                }
            }
            catch {
                MessageBox.Show("Valamilyen hálózati hiba történt. Ellenőrizd az internetkapcsolatod."); //connection/network problem
            }
        }

        //unzipping
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            labelInfo.Text = "Fájlok kicsomagolása..."; // unzipping msg
            string zipPath = folder + @"\mcopen.zip";
            string extractPath = folder + @"";

            ZipFile.ExtractToDirectory(zipPath, extractPath);
            labelInfo.Hide();
            MessageBox.Show("A letöltés befejeződött! Most már elindíthatod a játékot!"); // downloading is complete
            btnLogin.Enabled = true; //login button enable
            serverBtnO.Enabled = true;
            serverBtnS.Enabled = true;
            serverBtnT.Enabled = true;
        }

        // start minecraft
        private void button1_Click(object sender, EventArgs e)
        {
            // START MINECRAFT
            string dirr = Environment.GetEnvironmentVariable("APPDATA") + "\\" + @""+fmap+"";
            if (txtBoxUsername.Text.Length == 0 ) // if username box empty
            {
                MessageBox.Show("Írd be a felhasználóneved!"); //enter your username
            }
            else
            {
                try 
                {
                    #region starter
                    string name = txtBoxUsername.Text;
                    string launch = @"java.exe" + " -Xmx" + 1024 + "M" + " -Djava.library.path=" + dirr + @"\versions\1.13\natives" + @" -cp " + 
                        dirr + @"\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;" +
                        dirr + @"\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" +
                        dirr + @"\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" +
                        dirr + @"\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" +
                        dirr + @"\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" +
                        dirr + @"\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" +
                        dirr + @"\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;" +
                        dirr + @"\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" +
                        dirr + @"\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" +
                        dirr + @"\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" +
                        dirr + @"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" +
                        dirr + @"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" +
                        dirr + @"\libraries\com\mojang\brigadier\0.1.27\brigadier-0.1.27.jar;" +
                        dirr + @"\libraries\com\mojang\datafixerupper\1.0.16\datafixerupper-1.0.16.jar;" +
                        dirr + @"\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" +
                        dirr + @"\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" +
                        dirr + @"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" +
                        dirr + @"\libraries\it\unimi\dsi\fastutil\7.1.0\fastutil-7.1.0.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl\3.1.6\lwjgl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-jemalloc\3.1.6\lwjgl-jemalloc-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-openal\3.1.6\lwjgl-openal-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-opengl\3.1.6\lwjgl-opengl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-glfw\3.1.6\lwjgl-glfw-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-stb\3.1.6\lwjgl-stb-3.1.6.jar;" +
                        dirr + @"\libraries\com\mojang\realms\1.13.3\realms-1.13.3.jar;" +
                        dirr + @"\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;" +
                        dirr + @"\versions\1.13\1.13.jar net.minecraft.client.main.Main" +
                        @" --username " + name + @" --version 1.13" + @" --gameDir " + dirr + @" --assetsDir " + dirr + @"\assets\ --assetIndex 1.13 --uuid 00000000-0000-0000-0000-000000000000 --accessToken null --userProperties [] --userType legacy --width 925 --height 530";
                    // --server YOURSERVERIP --port SERVERPORT
                    #endregion
                    Process.Start("cmd.exe", "/C" + launch);
                }
                catch
                {
                MessageBox.Show("Nem sikerült elindítani a Minecraftot. A leggyakoribb ok az, hogy a java nincs installálva, vagy nincs benne a PATH-ban. Esetleg még megpróbálkozhatsz több memória adásával."); //java not found or something
                }

            }
        }

        #region servers [ip,port]

        // 1. SERVER 
        public void button1_Click_1(object sender, EventArgs e)
        {
            #region ServerO
            string dirr = Environment.GetEnvironmentVariable("APPDATA") + "\\" + @"" + fmap + "";
            if (txtBoxUsername.Text.Length == 0) // if username box empty
            {
                MessageBox.Show("Írd be a felhasználóneved!"); //enter your username
            }
            else 
            {
                try
                {
                    #region starter
                    string name = txtBoxUsername.Text;
                    string launch = @"java.exe" + " -Xmx" + 1024 + "M" + " -Djava.library.path=" + dirr + @"\versions\1.13\natives" + @" -cp " +
                        dirr + @"\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;" +
                        dirr + @"\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" +
                        dirr + @"\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" +
                        dirr + @"\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" +
                        dirr + @"\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" +
                        dirr + @"\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" +
                        dirr + @"\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;" +
                        dirr + @"\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" +
                        dirr + @"\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" +
                        dirr + @"\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" +
                        dirr + @"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" +
                        dirr + @"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" +
                        dirr + @"\libraries\com\mojang\brigadier\0.1.27\brigadier-0.1.27.jar;" +
                        dirr + @"\libraries\com\mojang\datafixerupper\1.0.16\datafixerupper-1.0.16.jar;" +
                        dirr + @"\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" +
                        dirr + @"\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" +
                        dirr + @"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" +
                        dirr + @"\libraries\it\unimi\dsi\fastutil\7.1.0\fastutil-7.1.0.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl\3.1.6\lwjgl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-jemalloc\3.1.6\lwjgl-jemalloc-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-openal\3.1.6\lwjgl-openal-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-opengl\3.1.6\lwjgl-opengl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-glfw\3.1.6\lwjgl-glfw-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-stb\3.1.6\lwjgl-stb-3.1.6.jar;" +
                        dirr + @"\libraries\com\mojang\realms\1.13.3\realms-1.13.3.jar;" +
                        dirr + @"\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;" +
                        dirr + @"\versions\1.13\1.13.jar net.minecraft.client.main.Main" +
                        @" --username " + name + @" --version 1.13"  + @" --gameDir " + dirr + @" --assetsDir " + dirr + @"\assets\ --assetIndex 1.13 --server "+serverOIP+" --port "+ serverOPort +" --uuid 00000000-0000-0000-0000-000000000000 --accessToken null --userProperties [] --userType legacy --width 925 --height 530";
                    #endregion
                    Process.Start("cmd.exe", "/C" + launch);
                }
                catch
                {
                    MessageBox.Show("Nem sikerült elindítani a Minecraftot. A leggyakoribb ok az, hogy a java nincs installálva, vagy nincs benne a PATH-ban. Esetleg még megpróbálkozhatsz több memória adásával."); //java not found or something
                }

            }
            #endregion
        }

        // 2. SERVER
        private void serverBtnT_Click(object sender, EventArgs e)
        {
            #region ServerS
            string dirr = Environment.GetEnvironmentVariable("APPDATA") + "\\" + @"" + fmap + "";
            if (txtBoxUsername.Text.Length == 0) // if username box empty
            {
                MessageBox.Show("Írd be a felhasználóneved!"); //enter your username
            }
            else
            {
                try
                {
                    #region starter
                    string name = txtBoxUsername.Text;
                    string launch = @"java.exe" + " -Xmx" + 1024 + "M" + " -Djava.library.path=" + dirr + @"\versions\1.13\natives" + @" -cp " +
                        dirr + @"\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;" +
                        dirr + @"\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" +
                        dirr + @"\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" +
                        dirr + @"\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" +
                        dirr + @"\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" +
                        dirr + @"\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" +
                        dirr + @"\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;" +
                        dirr + @"\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" +
                        dirr + @"\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" +
                        dirr + @"\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" +
                        dirr + @"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" +
                        dirr + @"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" +
                        dirr + @"\libraries\com\mojang\brigadier\0.1.27\brigadier-0.1.27.jar;" +
                        dirr + @"\libraries\com\mojang\datafixerupper\1.0.16\datafixerupper-1.0.16.jar;" +
                        dirr + @"\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" +
                        dirr + @"\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" +
                        dirr + @"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" +
                        dirr + @"\libraries\it\unimi\dsi\fastutil\7.1.0\fastutil-7.1.0.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl\3.1.6\lwjgl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-jemalloc\3.1.6\lwjgl-jemalloc-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-openal\3.1.6\lwjgl-openal-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-opengl\3.1.6\lwjgl-opengl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-glfw\3.1.6\lwjgl-glfw-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-stb\3.1.6\lwjgl-stb-3.1.6.jar;" +
                        dirr + @"\libraries\com\mojang\realms\1.13.3\realms-1.13.3.jar;" +
                        dirr + @"\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;" +
                        dirr + @"\versions\1.13\1.13.jar net.minecraft.client.main.Main" +
                        @" --username " + name + @" --version 1.13" + @" --gameDir " + dirr + @" --assetsDir " + dirr + @"\assets\ --assetIndex 1.13 --server " + serverSIP + " --port "+ serverSPort +" --uuid 00000000-0000-0000-0000-000000000000 --accessToken null --userProperties [] --userType legacy --width 925 --height 530";
                    #endregion
                    Process.Start("cmd.exe", "/C" + launch);
                }
                catch
                {
                    MessageBox.Show("Nem sikerült elindítani a Minecraftot. A leggyakoribb ok az, hogy a java nincs installálva, vagy nincs benne a PATH-ban. Esetleg még megpróbálkozhatsz több memória adásával."); //java not found or something
                }

            }
            #endregion
        }

        // 3. SERVER
        private void serverBtnTT_Click(object sender, EventArgs e)
        {
            #region ServerT
            string dirr = Environment.GetEnvironmentVariable("APPDATA") + "\\" + @"" + fmap + "";
            if (txtBoxUsername.Text.Length == 0) // if username box empty
            {
                MessageBox.Show("Írd be a felhasználóneved!"); //enter your username
            }
            else
            {
                try
                {
                    #region starter
                    string name = txtBoxUsername.Text;
                    string launch = @"java.exe" + " -Xmx" + 1024 + "M" + " -Djava.library.path=" + dirr + @"\versions\1.13\natives" + @" -cp " +
                        dirr + @"\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;" +
                        dirr + @"\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" +
                        dirr + @"\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" +
                        dirr + @"\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" +
                        dirr + @"\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" +
                        dirr + @"\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" +
                        dirr + @"\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" +
                        dirr + @"\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" +
                        dirr + @"\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;" +
                        dirr + @"\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" +
                        dirr + @"\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" +
                        dirr + @"\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" +
                        dirr + @"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" +
                        dirr + @"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" +
                        dirr + @"\libraries\com\mojang\brigadier\0.1.27\brigadier-0.1.27.jar;" +
                        dirr + @"\libraries\com\mojang\datafixerupper\1.0.16\datafixerupper-1.0.16.jar;" +
                        dirr + @"\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" +
                        dirr + @"\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;" +
                        dirr + @"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" +
                        dirr + @"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" +
                        dirr + @"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" +
                        dirr + @"\libraries\it\unimi\dsi\fastutil\7.1.0\fastutil-7.1.0.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" +
                        dirr + @"\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl\3.1.6\lwjgl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-jemalloc\3.1.6\lwjgl-jemalloc-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-openal\3.1.6\lwjgl-openal-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-opengl\3.1.6\lwjgl-opengl-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-glfw\3.1.6\lwjgl-glfw-3.1.6.jar;" +
                        dirr + @"\libraries\org\lwjgl\lwjgl-stb\3.1.6\lwjgl-stb-3.1.6.jar;" +
                        dirr + @"\libraries\com\mojang\realms\1.13.3\realms-1.13.3.jar;" +
                        dirr + @"\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;" +
                        dirr + @"\versions\1.13\1.13.jar net.minecraft.client.main.Main" +
                        @" --username " + name + @" --version 1.13" + @" --gameDir " + dirr + @" --assetsDir " + dirr + @"\assets\ --assetIndex 1.13 --server " + serverTIP + " --port " + serverTPort + " --uuid 00000000-0000-0000-0000-000000000000 --accessToken null --userProperties [] --userType legacy --width 925 --height 530";
                    #endregion
                    Process.Start("cmd.exe", "/C" + launch);
                }
                catch
                {
                    MessageBox.Show("Nem sikerült elindítani a Minecraftot. A leggyakoribb ok az, hogy a java nincs installálva, vagy nincs benne a PATH-ban. Esetleg még megpróbálkozhatsz több memória adásával."); //java not found or something
                }

            }
            #endregion
        }
        #endregion
    }
}