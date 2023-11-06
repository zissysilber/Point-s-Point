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
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
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
            tableLayoutPanel1.Controls.Add(button9, 0, 0);
            tableLayoutPanel1.Controls.Add(button10, 1, 0);
            tableLayoutPanel1.Controls.Add(button11, 2, 0);
            tableLayoutPanel1.Controls.Add(button12, 3, 0);
            tableLayoutPanel1.Controls.Add(button13, 0, 1);
            tableLayoutPanel1.Controls.Add(button14, 1, 1);
            tableLayoutPanel1.Controls.Add(button15, 2, 1);
            tableLayoutPanel1.Controls.Add(button16, 3, 1);
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
            // button9
            // 
            button9.BackColor = Color.SteelBlue;
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(6, 6);
            button9.Margin = new Padding(6);
            button9.Name = "button9";
            button9.Size = new Size(181, 165);
            button9.TabIndex = 0;
            button9.Text = "  ";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.SteelBlue;
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(199, 6);
            button10.Margin = new Padding(6);
            button10.Name = "button10";
            button10.Size = new Size(181, 165);
            button10.TabIndex = 1;
            button10.Text = "  ";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.SteelBlue;
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(392, 6);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(181, 165);
            button11.TabIndex = 2;
            button11.Text = "  ";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.SteelBlue;
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(585, 6);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(182, 165);
            button12.TabIndex = 3;
            button12.Text = "  ";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.SteelBlue;
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(6, 183);
            button13.Margin = new Padding(6);
            button13.Name = "button13";
            button13.Size = new Size(181, 166);
            button13.TabIndex = 4;
            button13.Text = "  ";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.SteelBlue;
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(199, 183);
            button14.Margin = new Padding(6);
            button14.Name = "button14";
            button14.Size = new Size(181, 166);
            button14.TabIndex = 5;
            button14.Text = "  ";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.SteelBlue;
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(392, 183);
            button15.Margin = new Padding(6);
            button15.Name = "button15";
            button15.Size = new Size(181, 166);
            button15.TabIndex = 6;
            button15.Text = "  ";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.SteelBlue;
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(585, 183);
            button16.Margin = new Padding(6);
            button16.Name = "button16";
            button16.Size = new Size(182, 166);
            button16.TabIndex = 7;
            button16.Text = "  ";
            button16.UseVisualStyleBackColor = false;
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
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Label label1;
    }
}