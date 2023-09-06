using DiscordRPC;
using DiscordRPC.Logging;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Button = DiscordRPC.Button;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;

namespace Radioactive
{
    public partial class Radioactive : Form
    {
        //bool init
        bool stopmusic = false;
        bool disablemusic = false;
        bool hideserverbtn = false;




        public Radioactive()
        {
            InitializeComponent();
        }


        private IWavePlayer wavePlayer;
        private List<string> mp3Files = new List<string>
        {     
            "BoulevardofBrokenDreams.mp3",
            "25ScratchReminder.mp3",
            "LeanOn.mp3",
            "9PM.mp3",
            "GooseBumps.mp3"
        };

        //drag panel code
        private bool isDragging = false;
        private Point dragStartPoint;
        private string rustPath = "";
        string settingsFilePath = Path.Combine(Application.StartupPath, "settings.txt");

        private DiscordRpcClient client;

        private void LoadResources()
        {

        }


        private string ReadPathFromConfigFile()
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "path.txt");
                if (File.Exists(configPath))
                {
                    return File.ReadAllText(configPath).Replace("\\\\", "\\");
                }
                else
                {
                    configPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\Rust.exe";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom čitanja putanje iz konfiguracijske datoteke: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }

        private void SavePathToConfigFile(string path)
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "path.txt");
                File.WriteAllText(configPath, path.Replace("\\", "\\\\"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom snimanja putanje u konfiguracijsku datoteku: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dragpanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void dragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = PointToScreen(e.Location);
                Location = new Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }

        private void dragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void UpdatePresence()
        {
            if (client != null && client.IsInitialized)
            {
                var presence = new RichPresence()
                {

                    State = "In the Launcher",
                    Details = "Download the launcher from my github page:---",
                    Timestamps = new Timestamps()
                    {
                        Start = DateTime.UtcNow
                    },
                    Assets = new Assets()
                    {
                        //LargeImageKey = "radioactivelogolighted",
                        //LargeImageText = "Opis velike slike",
                        SmallImageKey = "radioactive_logo",
                        //SmallImageText = "yes"
                    },
                    Buttons = new Button[]
                    {
                        new Button() { Label = "Join Today!", Url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" }
                    }
                };

                //presence update
                client.SetPresence(presence);
            }
        }


        private void Radioactive_Load(object sender, EventArgs e)
        {

            try
            {
                if (File.Exists(settingsFilePath))
                {
                    using (StreamReader reader = new StreamReader(settingsFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] parts = line.Split('=');
                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();

                                if (bool.TryParse(value, out bool state))
                                {
                                    //checking for checkboxes
                                    switch (key)
                                    {
                                        case "Option7State":
                                            if (state == false)
                                            {
                                                disablemusic = false;
                                            }
                                            else if (state == true)
                                            {
                                                disablemusic = true;
                                            }
                                            break;
                                        case "Option3State":
                                            if (state == false)
                                            {
                                                hideserverbtn = false;
                                            }
                                            else if (state == true)
                                            {
                                                hideserverbtn = true;
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom učitavanja postavki: " + ex.Message);
            }


            wavePlayer = new WaveOutEvent();
            wavePlayer.PlaybackStopped += WavePlayer_PlaybackStopped;
            Random random = new Random();
            mp3Files = mp3Files.OrderBy(x => random.Next()).ToList();

            string musicFolder = Path.Combine(Application.StartupPath, "sounds");
            for (int i = 0; i < mp3Files.Count; i++)
            {
                mp3Files[i] = Path.Combine(musicFolder, mp3Files[i]);
            }

            RandomizePlaylist();

            Play();


            rustPath = ReadPathFromConfigFile();


            // DRPC init
            client = new DiscordRpcClient("1118282039058251776");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            // Event handling
            client.OnReady += (s, args) =>
            {
                MessageBox.Show("Rich Pressence online!");
            };

            // DiscordRPC startup
            client.Initialize();

            UpdatePresence();

            if (hideserverbtn == true)
            {
                launchserver.Visible = false;
            }
            else if (hideserverbtn == false)
            {
                launchserver.Visible = true;
            }

        }

        private void WavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (mp3Files.Count > 0)
            {
                string currentFile = mp3Files[0];
                mp3Files.RemoveAt(0);
                PlayMP3(currentFile);
            }
            else
            {
                wavePlayer.Stop();
                wavePlayer.Dispose();
            }
        }

        private void Play()
        {
            if (mp3Files.Count > 0)
            {
                if (mp3Files.Count > 0)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(mp3Files.Count);
                    string selectedFile = mp3Files[randomIndex];
                    mp3Files.RemoveAt(randomIndex);
                    PlayMP3(selectedFile);

                }
            }
        }

        private void RandomizePlaylist()
        {
            Random random = new Random();
            mp3Files = mp3Files.OrderBy(x => random.Next()).ToList();
        }

        private void PlayMP3(string filePath)
        {
            if (stopmusic == false)
            {
                try
                {
                    AudioFileReader audioFileReader = new AudioFileReader(filePath);
                    wavePlayer.Init(audioFileReader);
                    if (disablemusic == false)
                    {
                        wavePlayer.Play();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom reprodukcije MP3 fajla: " + ex.Message);
                }
            }

        }


        private void startbtn_Click(object sender, EventArgs e)
        {

            rustPath = ReadPathFromConfigFile();

            if (rustPath == "" || !File.Exists(rustPath))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Rust.exe (Rust Executable)|*.exe";
                openFileDialog.Title = "Select the Rust.exe executable";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rustPath = openFileDialog.FileName;
                    SavePathToConfigFile(rustPath);
                }
                else
                {
                    // exit
                    return;
                }
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = rustPath;
            startInfo.WorkingDirectory = Path.GetDirectoryName(rustPath);

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom pokretanja Rust igre: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            RadioactiveSettings settingsForm = new RadioactiveSettings();

            settingsForm.ShowDialog();


        }

        private void Radioactive_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }

        private void launchserver_Click(object sender, EventArgs e)
        {
            string serverIP = "141.11.197.96";
            int serverPort = 30067;

            string connectLink = $"steam://connect/{serverIP}:{serverPort}";

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(connectLink);
                startInfo.UseShellExecute = true;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom povezivanja s Rust serverom: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopMP3()
        {
            if (wavePlayer != null && wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                wavePlayer.Stop();
                wavePlayer.Dispose();
            }
        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            wavePlayer.Pause();
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            stopmusic = true;
            wavePlayer.Stop();
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            stopmusic = false;
            wavePlayer.Play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void SetVolume(float volume)
        {
            wavePlayer.Volume = volume;
        }

        private float MapToNAudioValue(int trackBarValue)
        {
            float minTrackBarValue = volumebar.Minimum;
            float maxTrackBarValue = volumebar.Maximum;
            float minNAudioValue = 0.0f;
            float maxNAudioValue = 1.0f;

            float normalizedValue = (trackBarValue - minTrackBarValue) / (maxTrackBarValue - minTrackBarValue);

            float mappedValue = minNAudioValue + (maxNAudioValue - minNAudioValue) * normalizedValue;

            return mappedValue;
        }

        private void volumebar_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = volumebar.Value;
            float volume = MapToNAudioValue(trackBarValue);
            SetVolume(volume);
        }
    }
}