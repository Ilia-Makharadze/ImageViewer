using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace assignment4
{
    public partial class Form1 : Form
    {
        private string[] _photos;
        private int _currentIndex;
        //private string _baseDirectory = @"C:\Users\iliam\OneDrive\Desktop\testphotos";
        private string _baseDirectory = Directory.GetCurrentDirectory();
        private Timer _slideshowTimer;
        private bool _isPlaying;
        private string[] args;


        public Form1()
        {
            InitializeComponent();
            LoadDirectories(_baseDirectory);
            LoadPhotos();
            DisplayPhotos();
            InitializeSlideshowTimer();

        }
        public Form1(string filepath)
        {
            InitializeComponent();
            LoadDirectories(filepath);
            LoadPhotos();
            DisplayPhotos();
            InitializeSlideshowTimer();

        }
        private void LoadDirectories(string filepath = null)
        {
            DirectoryBox.Items.Clear();//delete all past elements in DirextoryBox thus to old elemenets deleted and do not inerfier to run code
            DirectoryBox.Items.Add(filepath);//add main directory in the clear 
            var directories = Directory.GetDirectories(filepath, "*", SearchOption.AllDirectories);
            foreach (var dir in directories)//all found folder will add in the DirectoryBox
            {
                DirectoryBox.Items.Add(dir);
            }
            DirectoryBox.SelectedIndex = 0;//in DirectoryBox the first element is automacally chosen
        }

        private void LoadPhotos()
        {
            string selectedDirectory = DirectoryBox.SelectedItem.ToString();//choose directory
            if (RecursiveSearch.Checked)
            {
                _photos = Directory.GetFiles(selectedDirectory, "*.jpg", SearchOption.AllDirectories);
            }
            else
            {
                _photos = Directory.GetFiles(selectedDirectory, "*.jpg");
            }

            if (_photos.Length > 0)
            {
                _currentIndex = 0;
            }
            else
            {
                MessageBox.Show("No photos found");
            }
        }

        private void DisplayPhotos()
        {
            if (_photos.Length > 0)//check if it empty
            {
                MainPhoto.Image = Image.FromFile(_photos[_currentIndex]);

                if (CheckLoop.Checked)//check loop is selected or not
                {
                    PreviousPhoto.Image = Image.FromFile(_photos[(_currentIndex - 1 + _photos.Length) % _photos.Length]);
                    NextPhoto.Image = Image.FromFile(_photos[(_currentIndex + 1) % _photos.Length]);
                }
                else
                {
                    if (_currentIndex > 0)//check loop logic
                    {
                        PreviousPhoto.Image = Image.FromFile(_photos[_currentIndex - 1]);
                        PreviousPhoto.Enabled = true;
                    }
                    else
                    {
                        PreviousPhoto.Image = null;//check loop logic
                        PreviousPhoto.Enabled = false;
                    }

                    if (_currentIndex < _photos.Length - 1)
                    {
                        NextPhoto.Image = Image.FromFile(_photos[_currentIndex + 1]);
                        NextPhoto.Enabled = true;
                    }
                    else
                    {//if is not photo this button is off
                        NextPhoto.Image = null;
                        NextPhoto.Enabled = false;
                    }
                }
            }
        }

        private void MainPhoto_Click(object sender, EventArgs e)
        {
        }

        private void PreviousPhoto_Click(object sender, EventArgs e)
        {
            if (CheckLoop.Checked || _currentIndex > 0)
            {
                _currentIndex = (_currentIndex - 1 + _photos.Length) % _photos.Length;
                DisplayPhotos();
            }
        }

        private void NextPhoto_Click(object sender, EventArgs e)
        {
            if (CheckLoop.Checked || _currentIndex < _photos.Length - 1)
            {
                _currentIndex = (_currentIndex + 1) % _photos.Length;
                DisplayPhotos();
            }
        }

        private void CheckLoop_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPhotos();
        }

        private void RecursiveSearch_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhotos();
            DisplayPhotos();
        }

        private void DirectoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhotos();
            DisplayPhotos();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (CheckLoop.Checked || _currentIndex > 0)
            {
                _currentIndex = (_currentIndex - 1 + _photos.Length) % _photos.Length;
                DisplayPhotos();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CheckLoop.Checked || _currentIndex < _photos.Length - 1)
            {
                _currentIndex = (_currentIndex + 1) % _photos.Length;
                DisplayPhotos();
            }
        }

        private void InitializeSlideshowTimer()//timer control function
        {
            _slideshowTimer = new Timer();
            _slideshowTimer.Interval = 1000; // Set the interval to 1 second
            _slideshowTimer.Tick += SlideshowTimer_Tick;
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e)//function which defines what happens on each tick of the Timer
        {
            if (_photos.Length > 0)//same next function 
            {
                _currentIndex = (_currentIndex + 1) % _photos.Length;
                DisplayPhotos();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!_isPlaying)
            {
                _slideshowTimer.Start();
                _isPlaying = true;
                PlayButton.Text = "Stop";
            }
            else
            {
                _slideshowTimer.Stop();
                _isPlaying = false;
                PlayButton.Text = "Play";
                _currentIndex = 0; // Reset to the first photo
                DisplayPhotos();
            }
        }


        private void CheckSratup() {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int value))
            {
                if(value < 0) { MessageBox.Show("interval must be positive", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.BackColor= Color.Red;
                    return;
                }
                _slideshowTimer.Interval = value;
               
            }
            else { 
                MessageBox.Show("if do not happend float parse", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                textBox1.BackColor= Color.Red;
                return;
            }
        }

    }
}
