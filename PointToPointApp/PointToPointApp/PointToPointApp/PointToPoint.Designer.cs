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
            btnImage1 = new Button();
            btnImage2 = new Button();
            btnImage3 = new Button();
            btnImage4 = new Button();
            btnImage5 = new Button();
            btnImage6 = new Button();
            btnImage7 = new Button();
            btnImage8 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnName9 = new Button();
            btnName10 = new Button();
            btnName11 = new Button();
            btnName12 = new Button();
            btnName13 = new Button();
            btnName14 = new Button();
            btnName15 = new Button();
            btnName16 = new Button();
            lblMessageBar = new Label();
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
            tblGameBoard.Controls.Add(lblMessageBar, 0, 1);
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
            tblPointCards.Controls.Add(btnImage1, 0, 0);
            tblPointCards.Controls.Add(btnImage2, 1, 0);
            tblPointCards.Controls.Add(btnImage3, 2, 0);
            tblPointCards.Controls.Add(btnImage4, 3, 0);
            tblPointCards.Controls.Add(btnImage5, 0, 1);
            tblPointCards.Controls.Add(btnImage6, 1, 1);
            tblPointCards.Controls.Add(btnImage7, 2, 1);
            tblPointCards.Controls.Add(btnImage8, 3, 1);
            tblPointCards.Dock = DockStyle.Fill;
            tblPointCards.Location = new Point(3, 74);
            tblPointCards.Name = "tblPointCards";
            tblPointCards.RowCount = 2;
            tblPointCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPointCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPointCards.Size = new Size(773, 354);
            tblPointCards.TabIndex = 0;
            // 
            // btnImage1
            // 
            btnImage1.BackColor = Color.LightSkyBlue;
            btnImage1.Dock = DockStyle.Fill;
            btnImage1.Image = Properties.Resources.blankpoint;
            btnImage1.Location = new Point(6, 6);
            btnImage1.Margin = new Padding(6);
            btnImage1.Name = "btnImage1";
            btnImage1.Size = new Size(181, 165);
            btnImage1.TabIndex = 0;
            btnImage1.Text = " ";
            btnImage1.UseVisualStyleBackColor = false;
            // 
            // btnImage2
            // 
            btnImage2.BackColor = Color.LightSkyBlue;
            btnImage2.Dock = DockStyle.Fill;
            btnImage2.Image = Properties.Resources.blankpoint;
            btnImage2.Location = new Point(199, 6);
            btnImage2.Margin = new Padding(6);
            btnImage2.Name = "btnImage2";
            btnImage2.Size = new Size(181, 165);
            btnImage2.TabIndex = 1;
            btnImage2.Text = " ";
            btnImage2.UseVisualStyleBackColor = false;
            // 
            // btnImage3
            // 
            btnImage3.BackColor = Color.LightSkyBlue;
            btnImage3.Dock = DockStyle.Fill;
            btnImage3.Image = Properties.Resources.blankpoint;
            btnImage3.Location = new Point(392, 6);
            btnImage3.Margin = new Padding(6);
            btnImage3.Name = "btnImage3";
            btnImage3.Size = new Size(181, 165);
            btnImage3.TabIndex = 2;
            btnImage3.Text = "  ";
            btnImage3.UseVisualStyleBackColor = false;
            // 
            // btnImage4
            // 
            btnImage4.BackColor = Color.LightSkyBlue;
            btnImage4.Dock = DockStyle.Fill;
            btnImage4.Image = Properties.Resources.blankpoint;
            btnImage4.Location = new Point(585, 6);
            btnImage4.Margin = new Padding(6);
            btnImage4.Name = "btnImage4";
            btnImage4.Size = new Size(182, 165);
            btnImage4.TabIndex = 3;
            btnImage4.Text = "  ";
            btnImage4.UseVisualStyleBackColor = false;
            // 
            // btnImage5
            // 
            btnImage5.BackColor = Color.LightSkyBlue;
            btnImage5.Dock = DockStyle.Fill;
            btnImage5.Image = Properties.Resources.blankpoint;
            btnImage5.Location = new Point(6, 183);
            btnImage5.Margin = new Padding(6);
            btnImage5.Name = "btnImage5";
            btnImage5.Size = new Size(181, 165);
            btnImage5.TabIndex = 4;
            btnImage5.Text = "  ";
            btnImage5.UseVisualStyleBackColor = false;
            // 
            // btnImage6
            // 
            btnImage6.BackColor = Color.LightSkyBlue;
            btnImage6.Dock = DockStyle.Fill;
            btnImage6.Image = Properties.Resources.blankpoint;
            btnImage6.Location = new Point(199, 183);
            btnImage6.Margin = new Padding(6);
            btnImage6.Name = "btnImage6";
            btnImage6.Size = new Size(181, 165);
            btnImage6.TabIndex = 5;
            btnImage6.Text = "  ";
            btnImage6.UseVisualStyleBackColor = false;
            // 
            // btnImage7
            // 
            btnImage7.BackColor = Color.LightSkyBlue;
            btnImage7.Dock = DockStyle.Fill;
            btnImage7.Image = Properties.Resources.blankpoint;
            btnImage7.Location = new Point(392, 183);
            btnImage7.Margin = new Padding(6);
            btnImage7.Name = "btnImage7";
            btnImage7.Size = new Size(181, 165);
            btnImage7.TabIndex = 6;
            btnImage7.Text = "  ";
            btnImage7.UseVisualStyleBackColor = false;
            // 
            // btnImage8
            // 
            btnImage8.BackColor = Color.LightSkyBlue;
            btnImage8.Dock = DockStyle.Fill;
            btnImage8.Image = Properties.Resources.blankpoint;
            btnImage8.Location = new Point(585, 183);
            btnImage8.Margin = new Padding(6);
            btnImage8.Name = "btnImage8";
            btnImage8.Size = new Size(182, 165);
            btnImage8.TabIndex = 7;
            btnImage8.Text = "  ";
            btnImage8.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnName9, 0, 0);
            tableLayoutPanel1.Controls.Add(btnName10, 1, 0);
            tableLayoutPanel1.Controls.Add(btnName11, 2, 0);
            tableLayoutPanel1.Controls.Add(btnName12, 3, 0);
            tableLayoutPanel1.Controls.Add(btnName13, 0, 1);
            tableLayoutPanel1.Controls.Add(btnName14, 1, 1);
            tableLayoutPanel1.Controls.Add(btnName15, 2, 1);
            tableLayoutPanel1.Controls.Add(btnName16, 3, 1);
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
            // btnName9
            // 
            btnName9.BackColor = Color.SteelBlue;
            btnName9.Dock = DockStyle.Fill;
            btnName9.Image = Properties.Resources.Blankname;
            btnName9.Location = new Point(6, 6);
            btnName9.Margin = new Padding(6);
            btnName9.Name = "btnName9";
            btnName9.Size = new Size(181, 165);
            btnName9.TabIndex = 0;
            btnName9.Text = "  ";
            btnName9.UseVisualStyleBackColor = false;
            // 
            // btnName10
            // 
            btnName10.BackColor = Color.SteelBlue;
            btnName10.Dock = DockStyle.Fill;
            btnName10.Image = Properties.Resources.Blankname;
            btnName10.Location = new Point(199, 6);
            btnName10.Margin = new Padding(6);
            btnName10.Name = "btnName10";
            btnName10.Size = new Size(181, 165);
            btnName10.TabIndex = 1;
            btnName10.Text = "  ";
            btnName10.UseVisualStyleBackColor = false;
            // 
            // btnName11
            // 
            btnName11.BackColor = Color.SteelBlue;
            btnName11.Dock = DockStyle.Fill;
            btnName11.Image = Properties.Resources.Blankname;
            btnName11.Location = new Point(392, 6);
            btnName11.Margin = new Padding(6);
            btnName11.Name = "btnName11";
            btnName11.Size = new Size(181, 165);
            btnName11.TabIndex = 2;
            btnName11.Text = "  ";
            btnName11.UseVisualStyleBackColor = false;
            // 
            // btnName12
            // 
            btnName12.BackColor = Color.SteelBlue;
            btnName12.Dock = DockStyle.Fill;
            btnName12.Image = Properties.Resources.Blankname;
            btnName12.Location = new Point(585, 6);
            btnName12.Margin = new Padding(6);
            btnName12.Name = "btnName12";
            btnName12.Size = new Size(182, 165);
            btnName12.TabIndex = 3;
            btnName12.Text = "  ";
            btnName12.UseVisualStyleBackColor = false;
            // 
            // btnName13
            // 
            btnName13.BackColor = Color.SteelBlue;
            btnName13.Dock = DockStyle.Fill;
            btnName13.Image = Properties.Resources.Blankname;
            btnName13.Location = new Point(6, 183);
            btnName13.Margin = new Padding(6);
            btnName13.Name = "btnName13";
            btnName13.Size = new Size(181, 166);
            btnName13.TabIndex = 4;
            btnName13.Text = "  ";
            btnName13.UseVisualStyleBackColor = false;
            // 
            // btnName14
            // 
            btnName14.BackColor = Color.SteelBlue;
            btnName14.Dock = DockStyle.Fill;
            btnName14.Image = Properties.Resources.Blankname;
            btnName14.Location = new Point(199, 183);
            btnName14.Margin = new Padding(6);
            btnName14.Name = "btnName14";
            btnName14.Size = new Size(181, 166);
            btnName14.TabIndex = 5;
            btnName14.Text = "  ";
            btnName14.UseVisualStyleBackColor = false;
            // 
            // btnName15
            // 
            btnName15.BackColor = Color.SteelBlue;
            btnName15.Dock = DockStyle.Fill;
            btnName15.Image = Properties.Resources.Blankname;
            btnName15.Location = new Point(392, 183);
            btnName15.Margin = new Padding(6);
            btnName15.Name = "btnName15";
            btnName15.Size = new Size(181, 166);
            btnName15.TabIndex = 6;
            btnName15.Text = "  ";
            btnName15.UseVisualStyleBackColor = false;
            // 
            // btnName16
            // 
            btnName16.BackColor = Color.SteelBlue;
            btnName16.Dock = DockStyle.Fill;
            btnName16.Image = Properties.Resources.Blankname;
            btnName16.Location = new Point(585, 183);
            btnName16.Margin = new Padding(6);
            btnName16.Name = "btnName16";
            btnName16.Size = new Size(182, 166);
            btnName16.TabIndex = 7;
            btnName16.Text = "  ";
            btnName16.UseVisualStyleBackColor = false;
            // 
            // lblMessageBar
            // 
            lblMessageBar.AutoSize = true;
            lblMessageBar.Dock = DockStyle.Fill;
            lblMessageBar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessageBar.Location = new Point(3, 11);
            lblMessageBar.Name = "lblMessageBar";
            lblMessageBar.Size = new Size(773, 60);
            lblMessageBar.TabIndex = 2;
            lblMessageBar.Text = "Click any card to begin";
            lblMessageBar.TextAlign = ContentAlignment.MiddleCenter;
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
            tblDestination.ColumnCount = 9;
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDestination.Location = new Point(0, 3);
            tblDestination.Name = "tblDestination";
            tblDestination.RowCount = 16;
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblDestination.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
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
        private Button btnImage1;
        private Button btnImage2;
        private Button btnImage3;
        private Button btnImage4;
        private Button btnImage5;
        private Button btnImage6;
        private Button btnImage7;
        private Button btnImage8;
        private Button btnName9;
        private Button btnName10;
        private Button btnName11;
        private Button btnName12;
        private Button btnName13;
        private Button btnName14;
        private Button btnName15;
        private Button btnName16;
        private Label label1;
        private Label lblMessageBar;
    }
}