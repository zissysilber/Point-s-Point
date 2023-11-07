using System.Data;


namespace PointToPointApp
{
    public partial class frmPointToPoint : Form
    {
        String path = Application.StartupPath + @"\Images\";
        List<Button> lstpointbutton;
        List<Button> lstpointpointbutton;
        List<Image> lstname;
        List<Image> lstimage;
        bool pointcardflipped = false;
        bool pointpointcardflipped = false;

        enum CardFlipped { point, pointpoint, none }
        CardFlipped cardstatus = CardFlipped.none;


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
            btnPoint9.Click += BtnPoint_Click;
            btnPoint10.Click += BtnPoint_Click;
            btnPoint11.Click += BtnPoint_Click;
            btnPoint12.Click += BtnPoint_Click;
            btnPoint13.Click += BtnPoint_Click;
            btnPoint14.Click += BtnPoint_Click;
            btnPoint15.Click += BtnPoint_Click;
            btnPoint16.Click += BtnPoint_Click;
            btnReset.Click += BtnReset_Click;


            lstpointbutton = new() { btnPoint1, btnPoint2, btnPoint3, btnPoint4, btnPoint5, btnPoint6, btnPoint7, btnPoint8 };
            lstpointpointbutton = new() { btnPoint9, btnPoint10, btnPoint11, btnPoint12, btnPoint13, btnPoint14, btnPoint15, btnPoint16 };
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
            foreach (Button btn in lstpointbutton)
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
            foreach (Button btn in lstpointpointbutton)
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

            if (cardstatus == CardFlipped.none || cardstatus == CardFlipped.pointpoint)
            {
                //if button is part of point cards, cardstatus changes accordingly...
                if (lstpointbutton.Where(b => b == btn).Count() == 0)
                { cardstatus = CardFlipped.point; }
                btn.Image = null;
            }
            if (cardstatus == CardFlipped.none || cardstatus == CardFlipped.point)
                if (lstpointpointbutton.Where(b => b == btn).Count() == 0)
                { cardstatus = CardFlipped.pointpoint; }
                btn.Image = null;
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

        }
        private void BtnPoint_Click(object? sender, EventArgs e)
        {

            Button btn = (Button)sender;
            DoTurn(btn);
        }
    }
}
