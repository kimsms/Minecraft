using System.Runtime.CompilerServices;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using OpenCvSharp;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.Devices;
using Point = System.Drawing.Point;
using System.Runtime.InteropServices;
using System.Reflection;

namespace ImageAutoClick
{
    public partial class Main : Form
    {
        Bitmap findimage; // ã�� �̹���
        Bitmap Allimage; // ��ü �̹���
        int ������ = 0; //Ŭ���� 1�ʰ� �����̸� �ֱ� ���� ����

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        const uint LBUTTONDOWN = 0x0002;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            X��ǥ.Text = Cursor.Position.X.ToString();
            Y��ǥ.Text = Cursor.Position.Y.ToString();
        }

        private void �̹�����ư_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                findimage = new Bitmap(openFileDialog.FileName);
            }
        }

        private void ���۹�ư_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (timer1.Enabled)
                {
                    ���۹�ư.Text = "����";
                    timer1.Stop();
                    timer2.Start();
                }
                else
                {
                    ���۹�ư.Text = "����";
                    timer1.Start();
                    timer2.Stop();
                }
            }
            else
            {
                MessageBox.Show("�̹����� �����ϼ���");
            }

        }

        private void ����ȭ��(int x, int y, int width, int height)
        {
            width = width - x;
            height = height - y;

            Bitmap bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(bitmap);

            g.CopyFromScreen(x, y, 0, 0, bitmap.Size);

            Allimage = bitmap;

            //Cv2.ImShow("temp", OpenCvSharp.Extensions.BitmapConverter.ToMat(Allimage));
        }

        private bool �̹���ã��()
        {
            ����ȭ��(int.Parse(����X.Text), int.Parse(����Y.Text), int.Parse(��X.Text), int.Parse(��Y.Text));
            Mat mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(Allimage);

            Mat temp = OpenCvSharp.Extensions.BitmapConverter.ToMat(findimage);

            mat = mat.CvtColor(ColorConversionCodes.BGR2GRAY);
            temp = temp.CvtColor(ColorConversionCodes.BGR2GRAY);

            Mat result = new Mat();

            Cv2.MatchTemplate(mat, temp, result, TemplateMatchModes.CCoeffNormed);

            OpenCvSharp.Point minloc, maxloc;
            double minval, maxval;
            Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);

            var threshold = 0.8;
            if (maxval >= threshold)
            {
                Rect rect = new Rect(maxloc.X, maxloc.Y, temp.Width, temp.Height);
                Cv2.Rectangle(mat, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);

                //Cv2.ImShow("temp", mat);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (�̹���ã��())
            {
                Point p = new Point(int.Parse(Ŭ��X.Text), int.Parse(Ŭ��Y.Text));
                Cursor.Position = p;

                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);

                timer3.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (������ == 1)
            {
                Point p = new Point(int.Parse(�߾�X.Text), int.Parse(�߾�Y.Text));
                Cursor.Position = p;
                //mouse_event(LBUTTONDOWN, 0, 0, 0, 0);

                timer2.Start();
                timer3.Stop();
            }
            else
            {
                ������++;
            }

        }



    }
}

