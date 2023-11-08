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
        bool imagecardflipped = false;
        bool namecardflipped = false;
        bool matchedset = false;
        int matchingset = 10;


        Button? btn1 = null;
        Button? btn2 = null;
        enum GameStatus { playing, notplaying }
        GameStatus status = GameStatus.notplaying;


        Random rnd = new();


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
            if (status == GameStatus.playing)
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

                    MessageBar(n1);
                    DelayTime(4);
                    btn1.Visible = false;
                    btn2.Visible = false;
                    HideCards();
                    matchedset = false;
                    DelayTime(4);
                    MessageBar();

                }
                if (n1 != n2)
                {
                    DelayTime();
                    HideCards();
                }
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


        private void MessageBar(int value = 10)
        {
            String message = "";

            if (matchedset == true)
            {
                switch (matchingset)
                {
                    case 0:
                        message = "Ari Hakadosh";
                        lblAriHakadosh.Visible = true;
                        picAriHakadosh.Visible = true;
                        break;
                    case 1:
                        message = "Churva";
                        lblChurva.Visible = true;
                        picChurva.Visible = true;
                        break;
                    case 2:
                        message = "Kever Rochel";
                        break;
                    case 3:
                        message = "Kosel";
                        break;
                    case 4:
                        message = "Mearas Hamachpela";
                        break;
                    case 5:
                        message = "Rabbi Meir Bal Haness";
                        break;
                    case 6:
                        message = "Rabi Shimon Bar Yochai";
                        break;
                    case 7:
                        message = "Yam Hamelech";
                        break;
                    case 10:
                        message = "Flip a Card to Continue";
                        break;

                }

                lblMessageBar.Text = message;

            }

        }
        private void BtnReset_Click(object? sender, EventArgs e)
        {
            AssignValue();
            imagecardflipped = false;
            namecardflipped = false;
            btn1 = null;
            btn2 = null;
            status = GameStatus.playing;

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


    }
}
