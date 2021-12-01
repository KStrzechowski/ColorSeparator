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
        private string[] _labels;
        private Bitmap[] _bitmap;
        public ResultForm(string[] labels, Image[] images)
        {
            InitializeComponent();
            Set(labels, images);
            ShowResults();
        }

        private void Set(string[] labels, Image[] images)
        {
            _labels = labels;
            _bitmap = Enumerable.Select(images, image => new Bitmap(image)).ToArray();
        }

        private void ShowResults()
        {
            int n = _labels.Length;
            if (n <= 0 || _bitmap.Length < n)
                throw new ArgumentException();

            if (n == 3)
                SetExactlyThree();
            else if (n < 3)
                SetLess(n);
            else
                SetMore(n);

        }

        private void SetExactlyThree()
        {
            resultLabel1.Text = _labels[0];
            resultLabel2.Text = _labels[1];
            resultLabel3.Text = _labels[2];

            resultPictureBox1.Size = new Size(_bitmap[0].Width, _bitmap[0].Height);
            resultPictureBox2.Size = new Size(_bitmap[1].Width, _bitmap[1].Height);
            resultPictureBox3.Size = new Size(_bitmap[2].Width, _bitmap[2].Height);
            resultPictureBox1.Image = _bitmap[0];
            resultPictureBox2.Image = _bitmap[1];
            resultPictureBox3.Image = _bitmap[2];
        }

        private void SetLess(int n)
        {
            mainTableLayoutPanel.Controls.Remove(resultLabel3);
            mainTableLayoutPanel.Controls.Remove(resultPictureBox3);
            mainTableLayoutPanel.RowCount--;
            if (n == 1)
            {
                mainTableLayoutPanel.Controls.Remove(resultLabel2);
                mainTableLayoutPanel.Controls.Remove(resultPictureBox2);
                mainTableLayoutPanel.RowCount--;
            }
            else
            {
                resultLabel2.Text = _labels[1];
                resultPictureBox2.Size = new Size(_bitmap[1].Width, _bitmap[1].Height);
                resultPictureBox2.Image = _bitmap[1];
            }

            resultLabel1.Text = _labels[0];
            resultPictureBox1.Size = new Size(_bitmap[0].Width, _bitmap[0].Height);
            resultPictureBox1.Image = _bitmap[0];
        }

        private void SetMore(int n)
        {
            SetExactlyThree();

            for (int i = 3; i < n; i++)
            {
                var label = new Label();
                label.Text = _labels[i];
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;

                var pictureBox = new PictureBox();
                pictureBox.Size = new Size(_bitmap[i].Width, _bitmap[i].Height);
                pictureBox.Image = _bitmap[i];
                pictureBox.Dock = DockStyle.Fill;

                mainTableLayoutPanel.RowCount++;
                mainTableLayoutPanel.Controls.Add(label);
                mainTableLayoutPanel.Controls.Add(pictureBox);
                mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, pictureBox.Height));
            }

            for (int i = 3; i < n; i++)
                mainTableLayoutPanel.RowStyles[i].Height = _bitmap[i].Height;
        }
    }
}
