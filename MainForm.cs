﻿using ColorSeparator.Enums;
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
                        YCbCrModel();
                        break;
                    }
                case "HSV":
                    {
                        HSVModel();
                        break;
                    }
                case "Custom":
                    {
                        CustomModel();
                        break;
                    }
            }
        }

        private void YCbCrModel()
        {
            _toneModel = ToneModel.YCbCr;
            labSettingsGroupBox.Enabled = false;
        }

        private void HSVModel()
        {
            _toneModel = ToneModel.HSV;
            labSettingsGroupBox.Enabled = false;
        }

        private void CustomModel()
        {
            _toneModel = ToneModel.Custom;
            labSettingsGroupBox.Enabled = true;
        }

        private void separateChannelsButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_toneModel != ToneModel.None && _image != null)
            {
                var resultImages = Seperate();
                if (resultImages != null)
                {
                    var resultForm = new ResultForm(_toneModel, resultImages);
                    resultForm.ShowDialog();
                }
            }
        }

        private Image[] Seperate()
        {
            switch (modelComboBox.Items[modelComboBox.SelectedIndex].ToString())
            {
                case "YCbCr":
                    {
                        return useYCbCr();
                    }
                case "HSV":
                    {
                        return useHsv();
                    }
                case "Custom":
                    {
                        return useCustom();
                    }
            }
            return null;
        }

        private Image[] useYCbCr()
        {
            var bitmap = new Bitmap(_image);
            int width = bitmap.Width, height = bitmap.Height;

            var resultImages = new Bitmap[3];
            resultImages[0] = new Bitmap(_image);
            resultImages[1] = new Bitmap(_image);
            resultImages[2] = new Bitmap(_image);

            double Kb = 0.114;
            double Kr = 0.299;
            double Kg = 0.587;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    var Y = (int)((Kr * color.R) + (Kg * color.G) + (Kb * color.B));
                    var Cb = (int)((color.B - Y) / 1.772 + 128);
                    //var Cb = (int)(-37.797 * color.R / 255 - 74.203 * color.G / 255 + 112 * color.B / 255) + 128;
                    var Cr = (int)((color.R - Y) / 1.402 + 128);
                    //var Cr = (int)(0.5 * color.R - 0.419 * color.G - 0.0081 * color.B) + 128;

                    resultImages[0].SetPixel(x, y, Color.FromArgb(Y, Y, Y));
                    resultImages[1].SetPixel(x, y, Color.FromArgb(Y, Y, Cb));
                    resultImages[2].SetPixel(x, y, Color.FromArgb(Cr, Y, Y));
                }
            }

            return resultImages;
        }

        private Image[] useHsv()
        {
            var resultImages = new Bitmap[3];
            resultImages[0] = new Bitmap(_image);
            resultImages[1] = new Bitmap(_image);
            resultImages[2] = new Bitmap(_image);
            return resultImages;
        }

        private Image[] useCustom()
        {
            var resultImages = new Bitmap[3];
            resultImages[0] = new Bitmap(_image);
            resultImages[1] = new Bitmap(_image);
            resultImages[2] = new Bitmap(_image);
            return resultImages;
        }

        private void greyscaleButton_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
