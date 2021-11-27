using ColorSeparator.Enums;
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
    public partial class MainForm : Form
    {
        private Image _image;
        private ToneModel _toneModel;
        public MainForm()
        {
            InitializeComponent();
            _toneModel = ToneModel.None;
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
                _image = Image.FromFile(fileName);
                mainPictureBox.Image = _image;
            }
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modelComboBox.Items[modelComboBox.SelectedIndex].ToString())
            {
                case "YCbCr":
                    {
                        _toneModel = ToneModel.YCbCr;
                        break;
                    }
                case "HSV":
                    {
                        _toneModel = ToneModel.HSV;
                        break;
                    }
            }
        }

        private void separateChannelsButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_toneModel != ToneModel.None && _image != null)
            {
                var resultForm = new ResultForm(_toneModel, _image);
                DialogResult dialogResult = resultForm.ShowDialog();
            }
        }

        private void greyscaleButton_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
