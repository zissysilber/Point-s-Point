using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointToPointApp
{
    public partial class frmPointToPoint : Form
    {
        String path = Application.StartupPath + @"\Images\";
        List<Button> lstpointbutton;
        List<Image> lstimage;
        bool pointcardflipped = false;
        bool pointpointcardflipped = false;
        PictureBox picture1;
        int imagename = 0;

        enum ButtonValue { a, b, c, d, e, f, g, h };

        Random rnd = new();


        public frmPointToPoint()
        {
            InitializeComponent();
            btnPoint1.Click += BtnPoint_Click;
            btnPoint2.Click += BtnPoint_Click;
            btnPoint3.Click += BtnPoint_Click;
            btnPoint4.Click += BtnPoint_Click;
            btnPoint5.Click += BtnPoint_Click;
            btnPoint6.Click += BtnPoint_Click;
            btnPoint7.Click += BtnPoint_Click;
            btnPoint8.Click += BtnPoint_Click;
            btnReset.Click += BtnReset_Click;




            lstpointbutton = new() { btnPoint1, btnPoint2, btnPoint3, btnPoint4, btnPoint5, btnPoint6, btnPoint7, btnPoint8 };
            lstimage = new()
            {

                Image.FromFile(path + "Ari Hakadosh.jpg"),
                Image.FromFile(path + "Churva.jpg"),
                Image.FromFile(path + "Kever Rochel.jpg"),
                Image.FromFile(path + "kosel.jpg"),
                Image.FromFile(path + "Mearas Hamechpela.jpg"),
                Image.FromFile(path + "Rabbi Meir Bal Haness.jpg"),
                Image.FromFile(path + "Rabi Shimon Bar Yochai.jpg"),
                Image.FromFile(path + "Yam Hamelech.jpg")
            };

        }

        private void BtnPoint2_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        //assign a random image to each button and store the name of the image to be referenced to check if it matches
        private void AssignValue()
        {
            List<Image> usedlist = new();
            foreach (Button btn in lstpointbutton)
            {
                while (btn.BackgroundImage == null)
                {
                    Image newimage = lstimage[rnd.Next(0, lstimage.Count())];
                    newimage.Tag = imagename + 1;
                    if (usedlist.Where(i => i == newimage).Count() == 0)
                    {
                        usedlist.Add(newimage);
                        btn.BackgroundImage = newimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                        
                    }
                }

                
            }

        }


        private void FlipCard()
        {
            if (pointcardflipped == true)
            {
                AssignValue();

            }
            pointcardflipped = false;
        }


        private void HidePictures()
        {
            DateTime starttime = DateTime.Now;
            if (pointcardflipped == true)
                //&& pointpointcardflipped == true)

                while ((DateTime.Now - starttime).TotalSeconds <= 10)
                {
                    Application.DoEvents();
                }
            btnPoint1.BackgroundImage = null;
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            AssignValue();
            foreach (Button btn in lstpointbutton)
            {
                btn.ForeColor    = Color.LightSkyBlue;
            }
        }
        private void BtnPoint_Click(object? sender, EventArgs e)
        {
            pointcardflipped = true;
            FlipCard();
            HidePictures();

        }
    }
}
