using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }
        #region Methods, paths and files
        string[] paths = new string[100000];//string array wich contains the paths for the songs
        string[] files = new string[100000];//string array wich contains the names of the songs
        public int n = 1;
        public void AddSongMethod()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add songs to playlist";
            ofd.Multiselect = true;
            ofd.Filter = "MP3 File|*.mp3|MP4 File|*.mp4|WAV File|*.wav";

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (listBoxPlaylist.Items.Count == 0)
                    {
                        for (int i = 0; i < ofd.SafeFileNames.Length; i++)
                        {
                            files[i] = ofd.SafeFileNames[i];
                            paths[i] = ofd.FileNames[i];
                        }
                        foreach (var item in files)
                        {
                            if (item != null)
                                listBoxPlaylist.Items.Add(item);
                            else
                                break;
                        }

                    }
                    else
                    {

                        int m = listBoxPlaylist.Items.Count;
                        foreach (var item in ofd.SafeFileNames)
                        {
                            if (item != null)
                                listBoxPlaylist.Items.Add(item);
                        }
                        foreach (var item in ofd.FileNames)
                        {
                            paths[m] = item;
                            m++;
                        }
                    }

                }
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message, "Error");
            }
        }
        public void SavePlaylistMethod()
        {
            try
            {
                StreamWriter Write;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "ZBMusic playlist file|*.zbmpl";
                sfd.ShowDialog();
                Write = new StreamWriter(sfd.FileName);
                for (int i = 0; i < listBoxPlaylist.Items.Count; i++)
                {
                    Write.WriteLine(listBoxPlaylist.Items[i]);
                    Write.WriteLine(paths[i].ToString());
                }
                Write.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("The playlist was not saved", "O, No!");
            }
        }
        public void LoadPlaylistMethod()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ZBMusic playlist file|*.zbmpl";
            ofd.Multiselect = false;
            ofd.FileName = "";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    if (listBoxPlaylist.Items.Count == 0)
                    {
                        while (sr.Peek() >= 0)
                        {
                            listBoxPlaylist.Items.Add(sr.ReadLine());
                        }
                        for (int i = 0; i < listBoxPlaylist.Items.Count; i++)
                        {
                            //listBoxPlaylist.SelectedIndex.Equals(i);
                            if (listBoxPlaylist.Items[i].ToString().Contains("C:"))
                            {
                                paths[i - 1] = listBoxPlaylist.Items[i].ToString();
                                listBoxPlaylist.Items.RemoveAt(i);
                            }
                        }
                    }
                    else
                    {
                        int n = listBoxPlaylist.Items.Count;
                        while (sr.Peek() >= 0)
                        {
                            listBoxPlaylist.Items.Add(sr.ReadLine());
                        }
                        int t = listBoxPlaylist.Items.Count - n;
                        for (int i = 0; i < t; i++)
                        {
                            try
                            {
                                if (listBoxPlaylist.Items[n + 1].ToString().Contains("C:"))
                                {
                                    paths[n] = listBoxPlaylist.Items[n + 1].ToString();
                                    listBoxPlaylist.Items.RemoveAt(n + 1);
                                }
                                n++;

                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                return;
                            }


                        }
                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error", "Super Error");
            }
        }
        #endregion
//Disable MediaPlayer Visibility and setting the volume of the media same as the value of the trackbar
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            
            axWindowsMediaPlayer1.settings.volume = trackBarVolume.Value;
            
        }
//Timer Tick method(progress bar, song timer)
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
             
            }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && radioButtonRandom.Checked)
            {
                listBoxPlaylist.SelectedIndex = rnd.Next(listBoxPlaylist.Items.Count);
                axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex];
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && radioButtonOrdered.Checked)
            {
                try
                {
                    listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex + 1;
                    axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex];
                    timer1.Start();
                }
                catch (ArgumentOutOfRangeException)
                {
                    radioButtonOrdered.Checked = false;
                    MessageBox.Show("Your playlist has reached its end, you shall load some more music...", "O, No!");
                    lblsongtime.Text = "00:00";
                    progressBar.Value = 0;


                }



            }
        
            lblsongtime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString; 
        }
//TrackBar scroll
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBarVolume.Value;
            lblVolume.Text = trackBarVolume.Value.ToString();
        }
//ProgressBar mouse position
        private void progressBar_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBar.Bounds.X);
            float calcFactor = progressBar.Width / (float)progressBar.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;
            progressBar.Value = Convert.ToInt32(relativeMouse);
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = progressBar.Value;
        }
        #region Buttons
        //Stop button
        private void buttonStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            listBoxPlaylist.ClearSelected();
            timer1.Stop();
            lblsongtime.Text = "00:00";
            progressBar.Value = 0;
        }
//Previous song button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex>0)
            {
                axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex - 1];
            }
            else
            {
                return;
            }

            axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex - 1];

            listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex - 1;


        }// има още работа
//Next song button
        private void buttonForward_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonRandom.Checked == false)
                {
                    axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex + 1];
                    listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex + 1;
                }

                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying && radioButtonRandom.Checked)
                {
                    Random rnd = new Random();
                    listBoxPlaylist.SelectedIndex = rnd.Next(listBoxPlaylist.Items.Count);
                    axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex];
                    timer1.Start();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There are no more songs man, load some more...", "O, No!");
            }
            
        }// има още работа
//Pause button
        private void buttonPause_Click(object sender, EventArgs e)
        {    
            
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            
        }
//Play button
        private void buttonPlay_Click(object sender, EventArgs e)
        {
              try
              {
                axWindowsMediaPlayer1.URL = paths[listBoxPlaylist.SelectedIndex];
                timer1.Start();
              }
              catch (IndexOutOfRangeException)
              {
                MessageBox.Show("Make sure you select the song brother not the empty space...", "O, No!");
              }
        }
        #endregion
        #region Tool Strip Menu (File) Options
        //About 
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout();
            newForm.Show();
            
            newForm.Visible = true;

        }
//Add songs
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddSongMethod(); 
        }
//SavePlaylist
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SavePlaylistMethod();   
        }
//Open playlist
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LoadPlaylistMethod();
        }
        #endregion
        #region Tool Strip Menu (Extras) Options
        //Extras speed

        private void SlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 0.5;
        }

        private void SlowertoolStripMenuItem07_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 0.7;
        }

        private void SlowertoolStripMenuItem09_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 0.9;
        }

        private void NormaltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 1.0;
        }

        private void FastertoolStripMenuItem11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 1.1;
        }

        private void FastertoolStripMenuItem13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 1.3;
        }

        private void FastertoolStripMenuItem15_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 1.5;
        }
        #endregion
        #region Close, Minimize
        //Aplication Close
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//Aplication Min
        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Context Menu Options
        //Context Strip menu Add Song
        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSongMethod();
        }
//Context Strip menu Save Playlist
        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePlaylistMethod();
        }
//Context Strip menu Load Playlist
        private void loadPlaylistStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadPlaylistMethod();
        }
//Change color of the progressBar
        private void toolStripMenuItemChangeColor_Click(object sender, EventArgs e)
        {            
            Random rnd = new Random();
            progressBar.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            progressBar.Style = ProgressBarStyle.Continuous;
        }
        #endregion
    }
}
