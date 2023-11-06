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
        enum ButtonValue {a, b, c, d, e, f, g, h };

        Random rnd = new();
        

        public frmPointToPoint()
        {
            InitializeComponent();
            btnPoint1.Click += BtnPoint1_Click;
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

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            
        }

        //assign a random image to each button and store the name of the image to be referenced to check if it matches
        private void AssignValue(Button btn)
        {
            /*
             * assign random image
             * assign to button background image
             * add image to used list
             * 
             * choose another image
             * check if already on used list
             * if it is, choose another image
             * if not, assign image to next item in button list
             * add image to used list
             * repeat from step 4
             */

            List<Image> usedlist = new();
            btn.BackgroundImage = lstimage[rnd.Next(0, lstimage.Count())];
            usedlist.Add(btn.BackgroundImage);



                
               


                

        }
        

        private void FlipCard() { 
        if(pointcardflipped == true)
            {
                btnPoint1.BackgroundImage = Image.FromFile(path + "Ari Hakadosh.jpg");
                btnPoint1.BackgroundImageLayout = ImageLayout.Zoom;
            }
        else    btnPoint1.BackgroundImage = null;
            
        }
        private void BtnPoint1_Click(object? sender, EventArgs e)
        {
            
            pointcardflipped = !pointcardflipped;
            FlipCard();
            HidePictures();
           
        }

        private void HidePictures() {
            DateTime starttime = DateTime.Now;
            if (pointcardflipped==true) 
                //&& pointpointcardflipped == true)
                
            while ((DateTime.Now - starttime).TotalSeconds <= 10)
            {
                Application.DoEvents();
                }
            btnPoint1.BackgroundImage = null;
        }
        
    }
}
