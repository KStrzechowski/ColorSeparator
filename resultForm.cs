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
    public partial class ResultForm : Form
    {
        private ToneModel _toneModel;
        private Bitmap[] _bitmap;
        //private Graphics _graphics;

        public ResultForm(ToneModel toneModel, Image[] images)
        {
            InitializeComponent();
            Set(toneModel, images);
            ShowResults();
        }

        private void Set(ToneModel toneModel, Image[] images)
        {
            _toneModel = toneModel;
            _bitmap = Enumerable.Select(images, image => new Bitmap(image)).ToArray();
        }

        private void ShowResults()
        {
            switch (_toneModel)
            {
                case ToneModel.YCbCr:
                    {
                        YCbCr();
                        break;
                    }
                case ToneModel.HSV:
                    {
                        HSV();
                        break;
                    }
                case ToneModel.Lab:
                    {
                        Lab();
                        break;
                    }
            }

         
        }

        private void YCbCr()
        {
            resultLabel1.Text = "Y";
            resultLabel2.Text = "Cb";
            resultLabel3.Text = "Cr";

            resultPictureBox1.Size = resultPictureBox2.Size = resultPictureBox3.Size = new Size(_bitmap[0].Width, _bitmap[0].Height);
            resultPictureBox1.Image = _bitmap[0];
            resultPictureBox2.Image = _bitmap[1];
            resultPictureBox3.Image = _bitmap[2];
        }
        private void HSV()
        {
            resultLabel1.Text = "H";
            resultLabel1.Text = "S";
            resultLabel1.Text = "V";

            resultPictureBox1.Size = resultPictureBox2.Size = resultPictureBox3.Size = new Size(_bitmap[0].Width, _bitmap[0].Height);
            resultPictureBox1.Image = _bitmap[0];
            resultPictureBox2.Image = _bitmap[1];
            resultPictureBox3.Image = _bitmap[2];
        }
        private void Lab()
        {
            resultLabel1.Text = "Y";
            resultLabel2.Text = "Cb";
            resultLabel3.Text = "Cr";
        }
    }
}
