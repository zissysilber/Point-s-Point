namespace PointToPointApp
{
    partial class frmPointToPoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointToPoint));
            tblMain = new TableLayoutPanel();
            tblGameBoard = new TableLayoutPanel();
            tblPointCards = new TableLayoutPanel();
            btnPoint1 = new Button();
            btnPoint2 = new Button();
            btnPoint3 = new Button();
            btnPoint4 = new Button();
            btnPoint5 = new Button();
            btnPoint6 = new Button();
            btnPoint7 = new Button();
            btnPoint8 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPoint9 = new Button();
            btnPoint10 = new Button();
            btnPoint11 = new Button();
            btnPoint12 = new Button();
            btnPoint13 = new Button();
            btnPoint14 = new Button();
            btnPoint15 = new Button();
            btnPoint16 = new Button();
            label1 = new Label();
            tblMap = new TableLayoutPanel();
            btnReset = new Button();
            pnlMapImage = new Panel();
            tblDestination = new TableLayoutPanel();
            tblMain.SuspendLayout();
            tblGameBoard.SuspendLayout();
            tblPointCards.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblMap.SuspendLayout();
            pnlMapImage.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.92641F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0735931F));
            tblMain.Controls.Add(tblGameBoard, 0, 0);
            tblMain.Controls.Add(tblMap, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(1174, 798);
            tblMain.TabIndex = 0;
            // 
            // tblGameBoard
            // 
            tblGameBoard.BackColor = Color.White;
            tblGameBoard.ColumnCount = 1;
            tblGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblGameBoard.Controls.Add(tblPointCards, 0, 2);
            tblGameBoard.Controls.Add(tableLayoutPanel1, 0, 3);
            tblGameBoard.Controls.Add(label1, 0, 1);
            tblGameBoard.Dock = DockStyle.Fill;
            tblGameBoard.Location = new Point(3, 3);
            tblGameBoard.Name = "tblGameBoard";
            tblGameBoard.RowCount = 4;
            tblGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tblGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblGameBoard.Size = new Size(779, 792);
            tblGameBoard.TabIndex = 0;
            // 
            // tblPointCards
            // 
            tblPointCards.ColumnCount = 4;
            tblPointCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPointCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPointCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPointCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPointCards.Controls.Add(btnPoint1, 0, 0);
            tblPointCards.Controls.Add(btnPoint2, 1, 0);
            tblPointCards.Controls.Add(btnPoint3, 2, 0);
            tblPointCards.Controls.Add(btnPoint4, 3, 0);
            tblPointCards.Controls.Add(btnPoint5, 0, 1);
            tblPointCards.Controls.Add(btnPoint6, 1, 1);
            tblPointCards.Controls.Add(btnPoint7, 2, 1);
            tblPointCards.Controls.Add(btnPoint8, 3, 1);
            tblPointCards.Dock = DockStyle.Fill;
            tblPointCards.Location = new Point(3, 74);
            tblPointCards.Name = "tblPointCards";
            tblPointCards.RowCount = 2;
            tblPointCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPointCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPointCards.Size = new Size(773, 354);
            tblPointCards.TabIndex = 0;
            // 
            // btnPoint1
            // 
            btnPoint1.BackColor = Color.LightSkyBlue;
            btnPoint1.Dock = DockStyle.Fill;
            btnPoint1.Image = Properties.Resources.blankpoint;
            btnPoint1.Location = new Point(6, 6);
            btnPoint1.Margin = new Padding(6);
            btnPoint1.Name = "btnPoint1";
            btnPoint1.Size = new Size(181, 165);
            btnPoint1.TabIndex = 0;
            btnPoint1.Text = " ";
            btnPoint1.UseVisualStyleBackColor = false;
            // 
            // btnPoint2
            // 
            btnPoint2.BackColor = Color.LightSkyBlue;
            btnPoint2.Dock = DockStyle.Fill;
            btnPoint2.Image = Properties.Resources.blankpoint;
            btnPoint2.Location = new Point(199, 6);
            btnPoint2.Margin = new Padding(6);
            btnPoint2.Name = "btnPoint2";
            btnPoint2.Size = new Size(181, 165);
            btnPoint2.TabIndex = 1;
            btnPoint2.Text = " ";
            btnPoint2.UseVisualStyleBackColor = false;
            // 
            // btnPoint3
            // 
            btnPoint3.BackColor = Color.LightSkyBlue;
            btnPoint3.Dock = DockStyle.Fill;
            btnPoint3.Image = Properties.Resources.blankpoint;
            btnPoint3.Location = new Point(392, 6);
            btnPoint3.Margin = new Padding(6);
            btnPoint3.Name = "btnPoint3";
            btnPoint3.Size = new Size(181, 165);
            btnPoint3.TabIndex = 2;
            btnPoint3.Text = "  ";
            btnPoint3.UseVisualStyleBackColor = false;
            // 
            // btnPoint4
            // 
            btnPoint4.BackColor = Color.LightSkyBlue;
            btnPoint4.Dock = DockStyle.Fill;
            btnPoint4.Image = Properties.Resources.blankpoint;
            btnPoint4.Location = new Point(585, 6);
            btnPoint4.Margin = new Padding(6);
            btnPoint4.Name = "btnPoint4";
            btnPoint4.Size = new Size(182, 165);
            btnPoint4.TabIndex = 3;
            btnPoint4.Text = "  ";
            btnPoint4.UseVisualStyleBackColor = false;
            // 
            // btnPoint5
            // 
            btnPoint5.BackColor = Color.LightSkyBlue;
            btnPoint5.Dock = DockStyle.Fill;
            btnPoint5.Image = Properties.Resources.blankpoint;
            btnPoint5.Location = new Point(6, 183);
            btnPoint5.Margin = new Padding(6);
            btnPoint5.Name = "btnPoint5";
            btnPoint5.Size = new Size(181, 165);
            btnPoint5.TabIndex = 4;
            btnPoint5.Text = "  ";
            btnPoint5.UseVisualStyleBackColor = false;
            // 
            // btnPoint6
            // 
            btnPoint6.BackColor = Color.LightSkyBlue;
            btnPoint6.Dock = DockStyle.Fill;
            btnPoint6.Image = Properties.Resources.blankpoint;
            btnPoint6.Location = new Point(199, 183);
            btnPoint6.Margin = new Padding(6);
            btnPoint6.Name = "btnPoint6";
            btnPoint6.Size = new Size(181, 165);
            btnPoint6.TabIndex = 5;
            btnPoint6.Text = "  ";
            btnPoint6.UseVisualStyleBackColor = false;
            // 
            // btnPoint7
            // 
            btnPoint7.BackColor = Color.LightSkyBlue;
            btnPoint7.Dock = DockStyle.Fill;
            btnPoint7.Image = Properties.Resources.blankpoint;
            btnPoint7.Location = new Point(392, 183);
            btnPoint7.Margin = new Padding(6);
            btnPoint7.Name = "btnPoint7";
            btnPoint7.Size = new Size(181, 165);
            btnPoint7.TabIndex = 6;
            btnPoint7.Text = "  ";
            btnPoint7.UseVisualStyleBackColor = false;
            // 
            // btnPoint8
            // 
            btnPoint8.BackColor = Color.LightSkyBlue;
            btnPoint8.Dock = DockStyle.Fill;
            btnPoint8.Image = Properties.Resources.blankpoint;
            btnPoint8.Location = new Point(585, 183);
            btnPoint8.Margin = new Padding(6);
            btnPoint8.Name = "btnPoint8";
            btnPoint8.Size = new Size(182, 165);
            btnPoint8.TabIndex = 7;
            btnPoint8.Text = "  ";
            btnPoint8.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnPoint9, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPoint10, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPoint11, 2, 0);
            tableLayoutPanel1.Controls.Add(btnPoint12, 3, 0);
            tableLayoutPanel1.Controls.Add(btnPoint13, 0, 1);
            tableLayoutPanel1.Controls.Add(btnPoint14, 1, 1);
            tableLayoutPanel1.Controls.Add(btnPoint15, 2, 1);
            tableLayoutPanel1.Controls.Add(btnPoint16, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 434);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(773, 355);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnPoint9
            // 
            btnPoint9.BackColor = Color.SteelBlue;
            btnPoint9.Dock = DockStyle.Fill;
            btnPoint9.Image = Properties.Resources.Blankname;
            btnPoint9.Location = new Point(6, 6);
            btnPoint9.Margin = new Padding(6);
            btnPoint9.Name = "btnPoint9";
            btnPoint9.Size = new Size(181, 165);
            btnPoint9.TabIndex = 0;
            btnPoint9.Text = "  ";
            btnPoint9.UseVisualStyleBackColor = false;
            // 
            // btnPoint10
            // 
            btnPoint10.BackColor = Color.SteelBlue;
            btnPoint10.Dock = DockStyle.Fill;
            btnPoint10.Image = Properties.Resources.Blankname;
            btnPoint10.Location = new Point(199, 6);
            btnPoint10.Margin = new Padding(6);
            btnPoint10.Name = "btnPoint10";
            btnPoint10.Size = new Size(181, 165);
            btnPoint10.TabIndex = 1;
            btnPoint10.Text = "  ";
            btnPoint10.UseVisualStyleBackColor = false;
            // 
            // btnPoint11
            // 
            btnPoint11.BackColor = Color.SteelBlue;
            btnPoint11.Dock = DockStyle.Fill;
            btnPoint11.Image = Properties.Resources.Blankname;
            btnPoint11.Location = new Point(392, 6);
            btnPoint11.Margin = new Padding(6);
            btnPoint11.Name = "btnPoint11";
            btnPoint11.Size = new Size(181, 165);
            btnPoint11.TabIndex = 2;
            btnPoint11.Text = "  ";
            btnPoint11.UseVisualStyleBackColor = false;
            // 
            // btnPoint12
            // 
            btnPoint12.BackColor = Color.SteelBlue;
            btnPoint12.Dock = DockStyle.Fill;
            btnPoint12.Image = Properties.Resources.Blankname;
            btnPoint12.Location = new Point(585, 6);
            btnPoint12.Margin = new Padding(6);
            btnPoint12.Name = "btnPoint12";
            btnPoint12.Size = new Size(182, 165);
            btnPoint12.TabIndex = 3;
            btnPoint12.Text = "  ";
            btnPoint12.UseVisualStyleBackColor = false;
            // 
            // btnPoint13
            // 
            btnPoint13.BackColor = Color.SteelBlue;
            btnPoint13.Dock = DockStyle.Fill;
            btnPoint13.Image = Properties.Resources.Blankname;
            btnPoint13.Location = new Point(6, 183);
            btnPoint13.Margin = new Padding(6);
            btnPoint13.Name = "btnPoint13";
            btnPoint13.Size = new Size(181, 166);
            btnPoint13.TabIndex = 4;
            btnPoint13.Text = "  ";
            btnPoint13.UseVisualStyleBackColor = false;
            // 
            // btnPoint14
            // 
            btnPoint14.BackColor = Color.SteelBlue;
            btnPoint14.Dock = DockStyle.Fill;
            btnPoint14.Image = Properties.Resources.Blankname;
            btnPoint14.Location = new Point(199, 183);
            btnPoint14.Margin = new Padding(6);
            btnPoint14.Name = "btnPoint14";
            btnPoint14.Size = new Size(181, 166);
            btnPoint14.TabIndex = 5;
            btnPoint14.Text = "  ";
            btnPoint14.UseVisualStyleBackColor = false;
            // 
            // btnPoint15
            // 
            btnPoint15.BackColor = Color.SteelBlue;
            btnPoint15.Dock = DockStyle.Fill;
            btnPoint15.Image = Properties.Resources.Blankname;
            btnPoint15.Location = new Point(392, 183);
            btnPoint15.Margin = new Padding(6);
            btnPoint15.Name = "btnPoint15";
            btnPoint15.Size = new Size(181, 166);
            btnPoint15.TabIndex = 6;
            btnPoint15.Text = "  ";
            btnPoint15.UseVisualStyleBackColor = false;
            // 
            // btnPoint16
            // 
            btnPoint16.BackColor = Color.SteelBlue;
            btnPoint16.Dock = DockStyle.Fill;
            btnPoint16.Image = Properties.Resources.Blankname;
            btnPoint16.Location = new Point(585, 183);
            btnPoint16.Margin = new Padding(6);
            btnPoint16.Name = "btnPoint16";
            btnPoint16.Size = new Size(182, 166);
            btnPoint16.TabIndex = 7;
            btnPoint16.Text = "  ";
            btnPoint16.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(773, 60);
            label1.TabIndex = 2;
            label1.Text = "Click any card to begin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblMap
            // 
            tblMap.BackColor = Color.White;
            tblMap.BackgroundImageLayout = ImageLayout.Zoom;
            tblMap.ColumnCount = 1;
            tblMap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMap.Controls.Add(btnReset, 0, 0);
            tblMap.Controls.Add(pnlMapImage, 0, 1);
            tblMap.Dock = DockStyle.Fill;
            tblMap.Location = new Point(788, 3);
            tblMap.Name = "tblMap";
            tblMap.RowCount = 2;
            tblMap.RowStyles.Add(new RowStyle(SizeType.Percent, 4.97448969F));
            tblMap.RowStyles.Add(new RowStyle(SizeType.Percent, 95.02551F));
            tblMap.Size = new Size(383, 792);
            tblMap.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Right;
            btnReset.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(229, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 33);
            btnReset.TabIndex = 0;
            btnReset.Text = "Start Again!";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // pnlMapImage
            // 
            pnlMapImage.BackColor = Color.White;
            pnlMapImage.BackgroundImage = (Image)resources.GetObject("pnlMapImage.BackgroundImage");
            pnlMapImage.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMapImage.Controls.Add(tblDestination);
            pnlMapImage.Dock = DockStyle.Fill;
            pnlMapImage.Location = new Point(3, 42);
            pnlMapImage.Name = "pnlMapImage";
            pnlMapImage.Size = new Size(377, 747);
            pnlMapImage.TabIndex = 1;
            // 
            // tblDestination
            // 
            tblDestination.BackColor = Color.Transparent;
            tblDestination.ColumnCount = 2;
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDestination.Location = new Point(0, 3);
            tblDestination.Name = "tblDestination";
            tblDestination.RowCount = 2;
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDestination.Size = new Size(371, 739);
            tblDestination.TabIndex = 0;
            // 
            // frmPointToPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 798);
            Controls.Add(tblMain);
            Name = "frmPointToPoint";
            Text = "PointToPoint";
            tblMain.ResumeLayout(false);
            tblGameBoard.ResumeLayout(false);
            tblGameBoard.PerformLayout();
            tblPointCards.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tblMap.ResumeLayout(false);
            pnlMapImage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblGameBoard;
        private TableLayoutPanel tblMap;
        private Button btnReset;
        private Panel pnlMapImage;
        private TableLayoutPanel tblDestination;
        private TableLayoutPanel tblPointCards;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPoint1;
        private Button btnPoint2;
        private Button btnPoint3;
        private Button btnPoint4;
        private Button btnPoint5;
        private Button btnPoint6;
        private Button btnPoint7;
        private Button btnPoint8;
        private Button btnPoint9;
        private Button btnPoint10;
        private Button btnPoint11;
        private Button btnPoint12;
        private Button btnPoint13;
        private Button btnPoint14;
        private Button btnPoint15;
        private Button btnPoint16;
        private Label label1;
    }
}