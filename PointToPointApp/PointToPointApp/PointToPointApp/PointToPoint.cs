using System.Data;

namespace PointToPointApp
{
    public partial class frmPointToPoint : Form
    {
        String path = Application.StartupPath + @"\Images\";
        List<Button> lstimagebutton;
        List<Button> lstnamebutton;
        List<Image> lstname;
        List<Image> lstimage;
        List<PictureBox> lstmappic;
        List<Label> lstmaplabel;

        bool imagecardflipped = false;
        bool namecardflipped = false;
        bool matchedset = false;
        int matchingset = 10;
        Random rnd = new();

        Button? btn1 = null;
        Button? btn2 = null;
        enum GameStatusEnum { playing, notplaying, finishedplaying }
        GameStatusEnum status = GameStatusEnum.notplaying;


        public frmPointToPoint()
        {
            InitializeComponent();
            btnImage1.Click += BtnPoint_Click;
            btnImage2.Click += BtnPoint_Click;
            btnImage3.Click += BtnPoint_Click;
            btnImage4.Click += BtnPoint_Click;
            btnImage5.Click += BtnPoint_Click;
            btnImage6.Click += BtnPoint_Click;
            btnImage7.Click += BtnPoint_Click;
            btnImage8.Click += BtnPoint_Click;
            btnName9.Click += BtnPoint_Click;
            btnName10.Click += BtnPoint_Click;
            btnName11.Click += BtnPoint_Click;
            btnName12.Click += BtnPoint_Click;
            btnName13.Click += BtnPoint_Click;
            btnName14.Click += BtnPoint_Click;
            btnName15.Click += BtnPoint_Click;
            btnName16.Click += BtnPoint_Click;
            btnReset.Click += BtnReset_Click;


            lstimagebutton = new() { btnImage1, btnImage2, btnImage3, btnImage4, btnImage5, btnImage6, btnImage7, btnImage8 };
            lstnamebutton = new() { btnName9, btnName10, btnName11, btnName12, btnName13, btnName14, btnName15, btnName16 };
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

            lstname = new()
            {
                Image.FromFile(path + "Ari Hakadoshwith name.jpg"),
                Image.FromFile(path + "Churvawithname.jpg"),
                Image.FromFile(path + "Kever Rochel with name.jpg"),
                Image.FromFile(path + "Kosel with name.jpg"),
                Image.FromFile(path + "Mearas Hamechpela with name.jpg"),
                Image.FromFile(path + "Rabbi Meir Bal Haness with name.jpg"),
                Image.FromFile(path + "Rabi Shimon Bar Yochai with name.jpg"),
                Image.FromFile(path + "Yam Hamelech with name.jpg")
            };

            lstmappic = new() 
            { 
                picAriHakadosh,
                picChurva,
                picKeverRochel,
                picKosel,
                picMearasHamachpela,
                picRabbiMeir,
                picRabiShimon,
                picYamHamelech,
                
            };

            lstmaplabel = new()
            {
                lblAriHakadosh,
                lblChurva,
                lblKeverRochel,
                lblKosel,
                lblMearasHamachpela,
                lblRabbiMeirBalHaness,
                lblRabiShimon,
                lblYamHamelech
            };
        }

        private void AssignValue()
        {
            List<Image> usedlist = new();
            foreach (Button btn in lstimagebutton)
            {
                while (btn.BackgroundImage == null)
                {
                    Image newimage = lstimage[rnd.Next(0, lstimage.Count())];

                    if (usedlist.Where(i => i == newimage).Count() == 0)
                    {
                        usedlist.Add(newimage);
                        btn.BackgroundImage = newimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }
            foreach (Button btn in lstnamebutton)
            {
                while (btn.BackgroundImage == null)
                {
                    Image nameimage = lstname[rnd.Next(0, lstname.Count())];

                    if (usedlist.Where(i => i == nameimage).Count() == 0)
                    {
                        usedlist.Add(nameimage);
                        btn.BackgroundImage = nameimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }
        }



        private void DoTurn(Button btn)
        {
            string btnName = btn.Name;
            if (status == GameStatusEnum.playing)
                lblMessageBar.Text = "";
            {
                if (imagecardflipped == false)
                {
                    if (btnName.Contains("Image"))
                    {
                        imagecardflipped = true;
                        btn.Image = null;
                    }
                }
                if (namecardflipped == false)
                {
                    if (btnName.Contains("Name"))
                    {
                        namecardflipped = true;
                        btn.Image = null;
                    }
                }
                CheckSet();
            }
        }

        private void CheckSet()
        {
            if (btn1 != null && btn2 != null)
            {
                Image image = btn1.BackgroundImage;
                Image name = btn2.BackgroundImage;

                int n1 = lstimage.IndexOf(image);
                int n2 = lstname.IndexOf(name);

                if (n1 == n2)
                {
                    matchedset = true;
                    matchingset = n1;
                    MessageBar();
                    DelayTime(4);
                    btn1.Visible = false;
                    btn2.Visible = false;
                    HideCards();
                    matchedset = false;
                    CheckEndGame();

                }
                if (n1 != n2)
                {
                    DelayTime();
                    HideCards();
                }
            }
        }

        private void CheckEndGame()
        {
            if ((lstimagebutton.Count(i => i.Visible == false) == 8) && (lstnamebutton.Count(i => i.Visible == false) == 8))
            {
                status = GameStatusEnum.finishedplaying;
            }
        }
        private void DelayTime(int value = 2)
        {
            DateTime starttime = DateTime.Now;

            while ((DateTime.Now - starttime).TotalSeconds <= value)
            {
                Application.DoEvents();
            }
        }

        private void HideCards()
        {
            btn1.Image = Image.FromFile(path + "blankpoint.jpg");
            btn2.Image = Image.FromFile(path + "Blankname.jpg");
            imagecardflipped = false;
            namecardflipped = false;
            btn1 = null;
            btn2 = null;
        }


        private void MessageBar()
        {
            String message = "";

            if (matchedset == true)
            {
                if (matchingset == 0)
                {
                    message = "The Ari Hakadosh is buried in Tzfas.";
                    lblAriHakadosh.Visible = true;
                    picAriHakadosh.Visible = true;
                }
                else if (matchingset == 1)
                {
                    message = "The Churva is a shul in Yerushalayim.";
                    lblChurva.Visible = true;
                    picChurva.Visible = true;
                }
                else if (matchingset == 2)
                {
                    message = "Kever Rochel is in Beis Lechem.";
                    lblKeverRochel.Visible = true;
                    picKeverRochel.Visible = true;
                }
                else if (matchingset == 3)
                {
                    message = "The Kosel is in Yerushalayim.";
                    lblKosel.Visible = true;
                    picKosel.Visible = true;
                }
                else if (matchingset == 4)
                {
                    message = "Mearas Hamachpela is in Chevron.";
                    lblMearasHamachpela.Visible = true;
                    picMearasHamachpela.Visible = true;
                }
                else if (matchingset == 5)
                {
                    message = "The kever of Rabbi Meir Bal Haness is in Tiverya.";
                    lblRabbiMeirBalHaness.Visible = true;
                    picRabbiMeir.Visible = true;
                }
                else if (matchingset == 6)
                {
                    message = "The kever of Rabi Shimon Bar Yochai is in Meron.";
                    lblRabiShimon.Visible = true;
                    picRabiShimon.Visible = true;
                }
                else if (matchingset == 7)
                {
                    message = "The salt in Yam Hamelech makes everything float in the water.";
                    lblYamHamelech.Visible = true;
                    picYamHamelech.Visible = true;
                }

                if (status == GameStatusEnum.finishedplaying)
                {
                    message = "Congratulations!  You've matched all the pictures!";
                }

                lblMessageBar.Text = message;
                
            }

        }
        private void StartResetGame()
        {
            status = GameStatusEnum.playing;
            AssignValue();
            lblMessageBar.Text = "Click a Button!";
            btnReset.Text = "Start Again!";
            imagecardflipped = false;
            namecardflipped = false;
            btn1 = null;
            btn2 = null;
            
            foreach (Button btn in lstimagebutton)
            {
                btn.Visible = true;
            }
            
            foreach (Button b in lstnamebutton)
                b.Visible = true;
            
            
            foreach (PictureBox pic in lstmappic)
            {
                pic.Visible = false;
            }
            
            foreach (Label lbl in lstmaplabel)
            {
                lbl.Visible = false;
            }
        }

        private void BtnPoint_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (lstimagebutton.Exists(b => b == btn))
            {
                if (btn1 == null)
                {
                    btn1 = btn;
                }
            }
            else if (lstnamebutton.Exists(b => b == btn))
            {
                if (btn2 == null)
                {
                    btn2 = btn;
                }
            }
            DoTurn(btn);

        }
        private void BtnReset_Click(object? sender, EventArgs e)
        {
            StartResetGame();
        }


    }
}
