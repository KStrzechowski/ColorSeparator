using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSeparator
{
    public partial class mainForm : Form
    {
        private Image _image;
        public mainForm()
        {
            InitializeComponent();
        }

        private void loadImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Picture files|*.png;*.jpg;*.bmp";
            loadFileDialog.FilterIndex = 1;
            loadFileDialog.RestoreDirectory = true;
  
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = loadFileDialog.FileName;
                var image = Image.FromFile(fileName);
                mainPictureBox.Image = image;
                var bitmap = new Bitmap(image);
                var graphics = Graphics.FromImage(image);
            }
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void separateChannelsButton_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void greyscaleButton_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
