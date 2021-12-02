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
        private string[] _labels;
        private ToneModel _toneModel;
        public MainForm()
        {
            InitializeComponent();
            SetInitial();
        }

        private void SetInitial()
        {
            modelComboBox.SelectedIndex = 0;

            IlluminantcomboBox.SelectedIndex = 0;
            colorProfileComboBox.SelectedIndex = 0;

            redXNumericUpDown.Value = (decimal)0.64;
            redYNumericUpDown.Value = (decimal)0.33;
            greenXNumericUpDown.Value = (decimal)0.3;
            greenYNumericUpDown.Value = (decimal)0.6;
            blueXNumericUpDown.Value = (decimal)0.15;
            blueYNumericUpDown.Value = (decimal)0.06;

            whitePointXNumericUpDown.Value = (decimal)0.3127;
            whitePointYNumericUpDown.Value = (decimal)0.3290;
            gammaNumericUpDown.Value = (decimal)2.20;
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
                case "Lab":
                    {
                        LabModel();
                        break;
                    }
            }
        }

        private void YCbCrModel()
        {
            _toneModel = ToneModel.YCbCr;
            _labels = new string[] { "Y", "Cb", "Cr" };
            labSettingsGroupBox.Enabled = false;
        }

        private void HSVModel()
        {
            _toneModel = ToneModel.HSV;
            _labels = new string[] { "H", "S", "V" };
            labSettingsGroupBox.Enabled = false;
        }

        private void LabModel()
        {
            _toneModel = ToneModel.Lab;
            _labels = new string[] { "L", "a", "b" };
            labSettingsGroupBox.Enabled = true;
        }

        private void greyscaleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_toneModel != ToneModel.None && _image != null)
            {
                var label = new string[] { "Greyscale" };
                var resultImage = ToGreyscale();
                if (resultImage != null)
                {
                    var resultForm = new ResultForm(label, new Image[] { resultImage });
                    resultForm.ShowDialog();
                }
            }
        }

        private Image ToGreyscale()
        {
            var bitmap = new Bitmap(_image);
            int width = bitmap.Width, height = bitmap.Height;
            var resultImage = new Bitmap(_image);
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    int gray = color.R / 3 + color.G / 3 + color.B / 3;
                    resultImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            return resultImage;
        }

        private void separateChannelsButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_toneModel != ToneModel.None && _image != null)
            {
                var resultImages = Seperate();
                if (resultImages != null)
                {
                    var resultForm = new ResultForm(_labels, resultImages);
                    resultForm.ShowDialog();
                }
            }
        }

        private Image[] Seperate()
        {
            switch (_toneModel)
            {
                case ToneModel.YCbCr:
                    {
                        return UseYCbCr();
                    }
                case ToneModel.HSV:
                    {
                        return UseHsv();
                    }
                case ToneModel.Lab:
                    {
                        return UseLab();
                    }
            }
            return null;
        }

        private Image[] UseYCbCr()
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
                    var Cr = (int)((color.R - Y) / 1.402 + 128);

                    resultImages[0].SetPixel(x, y, Color.FromArgb(Y, Y, Y));
                    resultImages[1].SetPixel(x, y, Color.FromArgb(127, 255 - Cb, Cb));
                    resultImages[2].SetPixel(x, y, Color.FromArgb(Cr, 255 - Cr, 127));
                }
            }

            return resultImages;
        }

        private Image[] UseHsv()
        {
            double max, min, delta;
            var bitmap = new Bitmap(_image);
            int width = bitmap.Width, height = bitmap.Height;
           
            var resultImages = new Bitmap[3];
            resultImages[0] = new Bitmap(_image);
            resultImages[1] = new Bitmap(_image);
            resultImages[2] = new Bitmap(_image);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    min = Math.Min(Math.Min(color.R, color.G), color.B);
                    max = Math.Max(Math.Max(color.R, color.G), color.B);
                    delta = max - min;
                    double H, S, V;
                    V = max / 255;
                    
                    if (delta == 0)
                        H = 0;
                    else if (max == color.R)
                        H = (color.G - color.B) / delta;
                    else if (max == color.G)
                        H = 2 + (color.B - color.R) / delta;
                    else
                        H = 4 + (color.R - color.G) / delta;
                    H *= 60;

                    if (V == 0)
                        S = 0;
                    else
                        S = delta / 255 / V;

                    if (H < 0)
                        H += 360;
                    H = H * 255 / 360;
                    V *= 255;
                    S *= 255;
                    resultImages[0].SetPixel(x, y, Color.FromArgb((int)H, (int)H, (int)H));
                    resultImages[1].SetPixel(x, y, Color.FromArgb((int)S, (int)S, (int)S));
                    resultImages[2].SetPixel(x, y, Color.FromArgb((int)V, (int)V, (int)V));
                }
            }


            return resultImages;
        }

        private Image[] UseLab()
        {
            var bitmap = new Bitmap(_image);
            int width = bitmap.Width, height = bitmap.Height;
            var resultImages = new Bitmap[3];
            resultImages[0] = new Bitmap(_image);
            resultImages[1] = new Bitmap(_image);
            resultImages[2] = new Bitmap(_image);
            double[,] matrixM = MatrixM();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    double gamma = (double)gammaNumericUpDown.Value;
                    double[] xyz = RgbToXyz(Math.Pow(color.R, gamma), Math.Pow(color.G, gamma), Math.Pow(color.B, gamma), matrixM);
                    double[] lab = XyzToLab(xyz);

                    lab[0] = Math.Min(100, lab[0]);
                    lab[0] = Math.Max(0, lab[0]);
                    resultImages[0].SetPixel(x, y, Color.FromArgb((int)(lab[0] * 255 / 100), (int)(lab[0] * 255 / 100), (int)(lab[0] * 255 / 100)));

                    lab[1] = Math.Min(127, lab[1]);
                    lab[1] = Math.Max(-127, lab[1]);
                    lab[2] = Math.Min(127, lab[2]);
                    lab[2] = Math.Max(-127, lab[2]);
       
                    resultImages[1].SetPixel(x, y, Color.FromArgb((int)(128 + lab[1]), (int)(127 - lab[1]), 127));
                    resultImages[2].SetPixel(x, y, Color.FromArgb((int)(128 + lab[2]), 128, (int)(127 - lab[2])));
                }
            }
            
            return resultImages;
        }

        private double[,] MatrixM()
        {
            double xw = (double)whitePointXNumericUpDown.Value;
            double yw = (double)whitePointYNumericUpDown.Value;
            double zw = 1 - xw - yw;

            double Xw = xw / yw;
            double Yw = 1;
            double Zw = zw / yw;


            double[,] XYZMatrix = new double[3, 3];
            XYZMatrix[0, 0] = (double)redXNumericUpDown.Value;
            XYZMatrix[1, 0] = (double)redYNumericUpDown.Value;
            XYZMatrix[2, 0] = 1 - XYZMatrix[0, 0] - XYZMatrix[1, 0];

            XYZMatrix[0, 1] = (double)greenXNumericUpDown.Value;
            XYZMatrix[1, 1] = (double)greenYNumericUpDown.Value;
            XYZMatrix[2, 1] = 1 - XYZMatrix[0, 1] - XYZMatrix[1, 1];

            XYZMatrix[0, 2] = (double)blueXNumericUpDown.Value;
            XYZMatrix[1, 2] = (double)blueYNumericUpDown.Value;
            XYZMatrix[2, 2] = 1 - XYZMatrix[0, 2] - XYZMatrix[1, 2];
            double[,] InverseXYZMatrix = Matrix.MatrixInverse(XYZMatrix);

            double Sr = InverseXYZMatrix[0, 0] * Xw + InverseXYZMatrix[0, 1] * Yw + InverseXYZMatrix[0, 2] * Zw;
            double Sg = InverseXYZMatrix[1, 0] * Xw + InverseXYZMatrix[1, 1] * Yw + InverseXYZMatrix[1, 2] * Zw;
            double Sb = InverseXYZMatrix[2, 0] * Xw + InverseXYZMatrix[2, 1] * Yw + InverseXYZMatrix[2, 2] * Zw;

            double[,] matrixM = new double[3, 3];
            matrixM[0, 0] = XYZMatrix[0, 0] * Sr;
            matrixM[1, 0] = XYZMatrix[1, 0] * Sr;
            matrixM[2, 0] = XYZMatrix[2, 0] * Sr;

            matrixM[0, 1] = XYZMatrix[0, 1] * Sg;
            matrixM[1, 1] = XYZMatrix[1, 1] * Sg;
            matrixM[2, 1] = XYZMatrix[2, 1] * Sg;

            matrixM[0, 2] = XYZMatrix[0, 2] * Sb;
            matrixM[1, 2] = XYZMatrix[1, 2] * Sb;
            matrixM[2, 2] = XYZMatrix[2, 2] * Sb;

            return matrixM;
        }

        private double[] RgbToXyz(double R, double G, double B, double[,] matrixM)
        {
            double x = (matrixM[0, 0] * R + matrixM[0, 1] * G + matrixM[0, 2] * B) / Math.Pow(255, (double)gammaNumericUpDown.Value);
            double y = (matrixM[1, 0] * R + matrixM[1, 1] * G + matrixM[1, 2] * B) / Math.Pow(255, (double)gammaNumericUpDown.Value);
            double z = (matrixM[2, 0] * R + matrixM[2, 1] * G + matrixM[2, 2] * B) / Math.Pow(255, (double)gammaNumericUpDown.Value);

            return new double[] { x, y, z };
        }

        private double[] XyzToLab(double[] xyz)
        {
            double xw = (double)whitePointXNumericUpDown.Value;
            double yw = (double)whitePointYNumericUpDown.Value;
            double zw = 1 - xw - yw;

            double Xw = xw / yw;
            double Yw = 1;
            double Zw = zw / yw;

            double e = 0.008856;
            double k = 903.3;

            double Xr = xyz[0] / Xw;
            double Yr = xyz[1] / Yw;
            double Zr = xyz[2] / Zw;

            double fx, fy, fz;
            if (Xr > e)
                fx = Math.Cbrt(Xr);
            else
                fx = (k * Xr + 16) / 116;
            if (Yr > e)
                fy = Math.Cbrt(Yr);
            else
                fy = (k * Yr + 16) / 116;
            if (Zr > e)
                fz = Math.Cbrt(Zr);
            else
                fz = (k * Zr + 16) / 116;

             double L = 116 * fy - 16;
             double a = 500 * (fx - fy);
             double b = 200 * (fy - fz);

            return new double[] { L, a, b };
        }

        private void colorProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (colorProfileComboBox.Items[colorProfileComboBox.SelectedIndex].ToString())
            {
                case "sRGB":
                    {
                        SetSRGB();
                        break;
                    }
                case "AdobeRGB":
                    {
                        SetAdobeRGB();
                        break;
                    }
                case "AppleRGB":
                    {
                        SetAppleRGB();
                        break;
                    }
                case "WideGamut":
                    {
                        SetWideGamut();
                        break;
                    }
                case "CIERGB":
                    {
                        SetCIERGB();
                        break;
                    }
            }
        }

        private void SetSRGB()
        {
            IlluminantcomboBox.SelectedIndex = IlluminantcomboBox.Items.IndexOf("D65");

            redXNumericUpDown.Value = (decimal)0.64;
            redYNumericUpDown.Value = (decimal)0.33;
            greenXNumericUpDown.Value = (decimal)0.3;
            greenYNumericUpDown.Value = (decimal)0.6;
            blueXNumericUpDown.Value = (decimal)0.15;
            blueYNumericUpDown.Value = (decimal)0.06;

            gammaNumericUpDown.Value = (decimal)2.20;
        }

        private void SetAdobeRGB()
        {
            IlluminantcomboBox.SelectedIndex = IlluminantcomboBox.Items.IndexOf("D65");

            redXNumericUpDown.Value = (decimal)0.64;
            redYNumericUpDown.Value = (decimal)0.33;
            greenXNumericUpDown.Value = (decimal)0.21;
            greenYNumericUpDown.Value = (decimal)0.71;
            blueXNumericUpDown.Value = (decimal)0.15;
            blueYNumericUpDown.Value = (decimal)0.06;

            gammaNumericUpDown.Value = (decimal)2.20;
        }

        private void SetAppleRGB()
        {
            IlluminantcomboBox.SelectedIndex = IlluminantcomboBox.Items.IndexOf("D65");

            redXNumericUpDown.Value = (decimal)0.625;
            redYNumericUpDown.Value = (decimal)0.34;
            greenXNumericUpDown.Value = (decimal)0.28;
            greenYNumericUpDown.Value = (decimal)0.595;
            blueXNumericUpDown.Value = (decimal)0.155;
            blueYNumericUpDown.Value = (decimal)0.07;

            gammaNumericUpDown.Value = (decimal)1.8;
        }

        private void SetWideGamut()
        {
            IlluminantcomboBox.SelectedIndex = IlluminantcomboBox.Items.IndexOf("D50");

            redXNumericUpDown.Value = (decimal)0.7347;
            redYNumericUpDown.Value = (decimal)0.2653;
            greenXNumericUpDown.Value = (decimal)0.1152;
            greenYNumericUpDown.Value = (decimal)0.8264;
            blueXNumericUpDown.Value = (decimal)0.1566;
            blueYNumericUpDown.Value = (decimal)0.0177;

            gammaNumericUpDown.Value = (decimal)1.2;
        }

        private void SetCIERGB()
        {
            IlluminantcomboBox.SelectedIndex = IlluminantcomboBox.Items.IndexOf("E");

            redXNumericUpDown.Value = (decimal)0.735;
            redYNumericUpDown.Value = (decimal)0.265;
            greenXNumericUpDown.Value = (decimal)0.274;
            greenYNumericUpDown.Value = (decimal)0.717;
            blueXNumericUpDown.Value = (decimal)0.167;
            blueYNumericUpDown.Value = (decimal)0.007;


            gammaNumericUpDown.Value = (decimal)2.2;
        }

        private void IlluminantcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (IlluminantcomboBox.Items[IlluminantcomboBox.SelectedIndex].ToString())
            {
                case "A":
                    {
                        SetA();
                        break;
                    }
                case "B":
                    {
                        SetB();
                        break;
                    }
                case "C":
                    {
                        SetC();
                        break;
                    }
                case "D50":
                    {
                        SetD50();
                        break;
                    }
                case "D65":
                    {
                        SetD65();
                        break;
                    }
                case "E":
                    {
                        SetE();
                        break;
                    }
            }
        }

        private void SetA()
        {
            whitePointXNumericUpDown.Value = (decimal)0.44757;
            whitePointYNumericUpDown.Value = (decimal)0.40745;
        }
        private void SetB()
        {
            whitePointXNumericUpDown.Value = (decimal)0.34842;
            whitePointYNumericUpDown.Value = (decimal)0.35161;
        }
        private void SetC()
        {
            whitePointXNumericUpDown.Value = (decimal)0.31006;
            whitePointYNumericUpDown.Value = (decimal)0.31616;
        }
        private void SetD50()
        {
            whitePointXNumericUpDown.Value = (decimal)0.34567;
            whitePointYNumericUpDown.Value = (decimal)0.35850;
        }
        private void SetD65()
        {
            whitePointXNumericUpDown.Value = (decimal)0.31273;
            whitePointYNumericUpDown.Value = (decimal)0.32902;
        }
        private void SetE()
        {
            whitePointXNumericUpDown.Value = (decimal)0.333333;
            whitePointYNumericUpDown.Value = (decimal)0.333333;
        }
    }
}
