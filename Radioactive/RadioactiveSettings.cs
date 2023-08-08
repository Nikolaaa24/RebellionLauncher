using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Radioactive
{
    public partial class RadioactiveSettings : Form
    {
        public RadioactiveSettings()
        {
            InitializeComponent();
        }

        //drag panel code
        private bool isDragging = false;
        private Point dragStartPoint;
        string settingsFilePath = Path.Combine(Application.StartupPath, "settings.txt");


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
            this.Hide();
        }

        private void RadioactiveSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
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
                                    // Pronađemo odgovarajući checkbox po ključu i primenimo stanje
                                    switch (key)
                                    {
                                        case "Option1State":
                                            inseclaunchcb.Checked = state;
                                            break;
                                        case "Option2State":
                                            potatopccb.Checked = state;
                                            break;
                                        case "Option3State":
                                            btndisablecb.Checked = state;
                                            break;
                                        case "Option4State":
                                            bonlycb.Checked = state;
                                            break;
                                        case "Option5State":
                                            autostartcb.Checked = state;
                                            break;
                                        case "Option6State":
                                            nasapccb.Checked = state;
                                            break;
                                        case "Option7State":
                                            musicdisablecb.Checked = state;
                                            break;
                                             //add more options
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


        }

        private void SaveSettings()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(settingsFilePath))
                {
                    writer.WriteLine("Option1State=" + inseclaunchcb.Checked);
                    writer.WriteLine("Option2State=" + potatopccb.Checked);
                    writer.WriteLine("Option3State=" + btndisablecb.Checked);
                    writer.WriteLine("Option4State=" + bonlycb.Checked);
                    writer.WriteLine("Option5State=" + autostartcb.Checked);
                    writer.WriteLine("Option6State=" + nasapccb.Checked);
                    writer.WriteLine("Option7State=" + musicdisablecb.Checked);
                    //add more options

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom čuvanja postavki: " + ex.Message);
            }
        }

        private void RadioactiveSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
