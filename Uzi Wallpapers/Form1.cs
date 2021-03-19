using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;

namespace Uzi_Wallpapers
{
    public partial class Form1 : Form



    {


        Point lastPoint;

        [DllImport("user32.dll")]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        UInt32 SPI_SETWALL = 0x14;
        UInt32 SPIF_UPDATE = 0x01;
        UInt32 SPIF_SWEDWINI = 0x2;

        OpenFileDialog op = new OpenFileDialog();
        string filePath;


        public Form1()
        {
            using (var client = new WebClient())
            {


                // Specifing a file 
                String myfile = @"C:\\temp\\1.jpg";
                String myfile1 = @"C:\\temp\\2.jpg";
                String myfile2 = @"C:\\temp\\3.jpg";
                String myfile3 = @"C:\\temp\\4.jpg";
                String myfile4 = @"C:\\temp\\5.jpg";
                String myfile5 = @"C:\\temp\\6.jpg";
                String myfile6 = @"C:\\temp\\7.jpg";
                String myfile7 = @"C:\\temp\\8.jpg";
                String myfile8 = @"C:\\temp\\9.jpg";
                String myfile9 = @"C:\\temp\\10.jpg";
                String myfile10 = @"C:\\temp\\wallpapers.zip";





                // Calling the Delete() function to 
                // delete the file file.txt 
                File.Delete(myfile);
                File.Delete(myfile1);
                File.Delete(myfile2);
                File.Delete(myfile3);
                File.Delete(myfile4);
                File.Delete(myfile5);
                File.Delete(myfile6);
                File.Delete(myfile7);
                File.Delete(myfile8);
                File.Delete(myfile9);
                File.Delete(myfile10);




                client.DownloadFile("https://cdn.discordapp.com/attachments/822285300239564813/822314201430622248/wallpapers.zip", "C:\\temp\\wallpapers.zip");


                
                string startPath = @"C:\\temp\\wallpapers.zip";
                string zipPath = @"C:\\temp\\wallpapers.zip";
                string extractPath = @"C:\\temp\\";


                
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                
                

            }

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\testing.png", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\1.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\2.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\3.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\4.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\5.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\6.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\7.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\8.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\9.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, "C:\\temp\\10.jpg", SPIF_UPDATE | SPIF_SWEDWINI);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(op.ShowDialog() == DialogResult.OK)
            {
                
               
                
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETWALL, 0, filePath, SPIF_UPDATE | SPIF_SWEDWINI);
        }
    }
}
