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
        private Bitmap _bitmap;
        private Graphics _graphics;

        public ResultForm(ToneModel toneModel, Image image)
        {
            InitializeComponent();
            _toneModel = toneModel;
            SetBitmap(image);
            ShowResults();
        }

        private void SetBitmap(Image image)
        {
            _bitmap = new Bitmap(image);
            _graphics = Graphics.FromImage(_bitmap);
        }

        private void ShowResults()
        {
            resultPictureBox1.Size = new Size(_bitmap.Width, _bitmap.Height);
            resultPictureBox2.Size = new Size(_bitmap.Width, _bitmap.Height);
            resultPictureBox3.Size = new Size(_bitmap.Width, _bitmap.Height);
            resultPictureBox1.Image = _bitmap;
            resultPictureBox2.Image = _bitmap;
            resultPictureBox3.Image = _bitmap;
        }
    }
}
