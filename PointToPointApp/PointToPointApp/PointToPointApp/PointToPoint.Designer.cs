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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            tblMap = new TableLayoutPanel();
            btnReset = new Button();
            pnlMapImage = new Panel();
            tblDestination = new TableLayoutPanel();
            label1 = new Label();
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
            tblPointCards.Controls.Add(button1, 0, 0);
            tblPointCards.Controls.Add(button2, 1, 0);
            tblPointCards.Controls.Add(button3, 2, 0);
            tblPointCards.Controls.Add(button4, 3, 0);
            tblPointCards.Controls.Add(button5, 0, 1);
            tblPointCards.Controls.Add(button6, 1, 1);
            tblPointCards.Controls.Add(button7, 2, 1);
            tblPointCards.Controls.Add(button8, 3, 1);
            tblPointCards.Dock = DockStyle.Fill;
            tblPointCards.Location = new Point(3, 74);
            tblPointCards.Name = "tblPointCards";
            tblPointCards.RowCount = 2;
            tblPointCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPointCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPointCards.Size = new Size(773, 354);
            tblPointCards.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(6, 6);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(181, 165);
            button1.TabIndex = 0;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(199, 6);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(181, 165);
            button2.TabIndex = 1;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(392, 6);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(181, 165);
            button3.TabIndex = 2;
            button3.Text = "  ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(585, 6);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(182, 165);
            button4.TabIndex = 3;
            button4.Text = "  ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(6, 183);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(181, 165);
            button5.TabIndex = 4;
            button5.Text = "  ";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSkyBlue;
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(199, 183);
            button6.Margin = new Padding(6);
            button6.Name = "button6";
            button6.Size = new Size(181, 165);
            button6.TabIndex = 5;
            button6.Text = "  ";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(392, 183);
            button7.Margin = new Padding(6);
            button7.Name = "button7";
            button7.Size = new Size(181, 165);
            button7.TabIndex = 6;
            button7.Text = "  ";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSkyBlue;
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(585, 183);
            button8.Margin = new Padding(6);
            button8.Name = "button8";
            button8.Size = new Size(182, 165);
            button8.TabIndex = 7;
            button8.Text = "  ";
            button8.UseVisualStyleBackColor = false;
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
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