
namespace Virtual_GPIO
{
    partial class Form1
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
            this.comboBoard = new System.Windows.Forms.ComboBox();
            this.sw0 = new System.Windows.Forms.PictureBox();
            this.sw1 = new System.Windows.Forms.PictureBox();
            this.sw2 = new System.Windows.Forms.PictureBox();
            this.sw3 = new System.Windows.Forms.PictureBox();
            this.sw4 = new System.Windows.Forms.PictureBox();
            this.sw5 = new System.Windows.Forms.PictureBox();
            this.sw6 = new System.Windows.Forms.PictureBox();
            this.sw7 = new System.Windows.Forms.PictureBox();
            this.btnUpR = new System.Windows.Forms.PictureBox();
            this.btnDownR = new System.Windows.Forms.PictureBox();
            this.btnLeftR = new System.Windows.Forms.PictureBox();
            this.btnRightR = new System.Windows.Forms.PictureBox();
            this.btnUpL = new System.Windows.Forms.PictureBox();
            this.btnDownL = new System.Windows.Forms.PictureBox();
            this.btnLeftL = new System.Windows.Forms.PictureBox();
            this.btnRightL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sw0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeftR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRightR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeftL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRightL)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoard
            // 
            this.comboBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoard.FormattingEnabled = true;
            this.comboBoard.Items.AddRange(new object[] {
            "Board 1",
            "Board 2",
            "Board 3",
            "Board 4",
            "Board 5",
            "Board 6"});
            this.comboBoard.Location = new System.Drawing.Point(39, 33);
            this.comboBoard.Name = "comboBoard";
            this.comboBoard.Size = new System.Drawing.Size(508, 37);
            this.comboBoard.TabIndex = 8;
            this.comboBoard.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sw0
            // 
            this.sw0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw0.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw0.Location = new System.Drawing.Point(661, 166);
            this.sw0.Margin = new System.Windows.Forms.Padding(2);
            this.sw0.Name = "sw0";
            this.sw0.Size = new System.Drawing.Size(60, 120);
            this.sw0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw0.TabIndex = 16;
            this.sw0.TabStop = false;
            this.sw0.Click += new System.EventHandler(this.sw0_Click);
            // 
            // sw1
            // 
            this.sw1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw1.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw1.Location = new System.Drawing.Point(597, 166);
            this.sw1.Margin = new System.Windows.Forms.Padding(2);
            this.sw1.Name = "sw1";
            this.sw1.Size = new System.Drawing.Size(60, 120);
            this.sw1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw1.TabIndex = 15;
            this.sw1.TabStop = false;
            this.sw1.Click += new System.EventHandler(this.sw1_Click);
            // 
            // sw2
            // 
            this.sw2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw2.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw2.Location = new System.Drawing.Point(533, 166);
            this.sw2.Margin = new System.Windows.Forms.Padding(2);
            this.sw2.Name = "sw2";
            this.sw2.Size = new System.Drawing.Size(60, 120);
            this.sw2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw2.TabIndex = 14;
            this.sw2.TabStop = false;
            this.sw2.Click += new System.EventHandler(this.sw2_Click);
            // 
            // sw3
            // 
            this.sw3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw3.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw3.Location = new System.Drawing.Point(469, 166);
            this.sw3.Margin = new System.Windows.Forms.Padding(2);
            this.sw3.Name = "sw3";
            this.sw3.Size = new System.Drawing.Size(60, 120);
            this.sw3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw3.TabIndex = 13;
            this.sw3.TabStop = false;
            this.sw3.Click += new System.EventHandler(this.sw3_Click);
            // 
            // sw4
            // 
            this.sw4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw4.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw4.Location = new System.Drawing.Point(405, 166);
            this.sw4.Margin = new System.Windows.Forms.Padding(2);
            this.sw4.Name = "sw4";
            this.sw4.Size = new System.Drawing.Size(60, 120);
            this.sw4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw4.TabIndex = 12;
            this.sw4.TabStop = false;
            this.sw4.Click += new System.EventHandler(this.sw4_Click);
            // 
            // sw5
            // 
            this.sw5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw5.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw5.Location = new System.Drawing.Point(341, 166);
            this.sw5.Margin = new System.Windows.Forms.Padding(2);
            this.sw5.Name = "sw5";
            this.sw5.Size = new System.Drawing.Size(60, 120);
            this.sw5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw5.TabIndex = 11;
            this.sw5.TabStop = false;
            this.sw5.Click += new System.EventHandler(this.sw5_Click);
            // 
            // sw6
            // 
            this.sw6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw6.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw6.Location = new System.Drawing.Point(277, 166);
            this.sw6.Margin = new System.Windows.Forms.Padding(2);
            this.sw6.Name = "sw6";
            this.sw6.Size = new System.Drawing.Size(60, 120);
            this.sw6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw6.TabIndex = 10;
            this.sw6.TabStop = false;
            this.sw6.Click += new System.EventHandler(this.sw6_Click);
            // 
            // sw7
            // 
            this.sw7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sw7.Image = global::Virtual_GPIO.Properties.Resources.sw_off;
            this.sw7.Location = new System.Drawing.Point(213, 166);
            this.sw7.Margin = new System.Windows.Forms.Padding(2);
            this.sw7.Name = "sw7";
            this.sw7.Size = new System.Drawing.Size(60, 120);
            this.sw7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sw7.TabIndex = 9;
            this.sw7.TabStop = false;
            this.sw7.Click += new System.EventHandler(this.sw7_Click);
            // 
            // btnUpR
            // 
            this.btnUpR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpR.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnUpR.Location = new System.Drawing.Point(642, 414);
            this.btnUpR.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpR.Name = "btnUpR";
            this.btnUpR.Size = new System.Drawing.Size(60, 60);
            this.btnUpR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpR.TabIndex = 17;
            this.btnUpR.TabStop = false;
            this.btnUpR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpR_MouseDown);
            this.btnUpR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpR_MouseUp);
            // 
            // btnDownR
            // 
            this.btnDownR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDownR.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnDownR.Location = new System.Drawing.Point(642, 571);
            this.btnDownR.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownR.Name = "btnDownR";
            this.btnDownR.Size = new System.Drawing.Size(60, 60);
            this.btnDownR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDownR.TabIndex = 18;
            this.btnDownR.TabStop = false;
            this.btnDownR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDownR_MouseDown);
            this.btnDownR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDownR_MouseUp);
            // 
            // btnLeftR
            // 
            this.btnLeftR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeftR.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnLeftR.Location = new System.Drawing.Point(564, 492);
            this.btnLeftR.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftR.Name = "btnLeftR";
            this.btnLeftR.Size = new System.Drawing.Size(60, 60);
            this.btnLeftR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLeftR.TabIndex = 20;
            this.btnLeftR.TabStop = false;
            this.btnLeftR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeftR_MouseDown);
            this.btnLeftR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeftR_MouseUp);
            // 
            // btnRightR
            // 
            this.btnRightR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRightR.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnRightR.Location = new System.Drawing.Point(720, 492);
            this.btnRightR.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightR.Name = "btnRightR";
            this.btnRightR.Size = new System.Drawing.Size(60, 60);
            this.btnRightR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRightR.TabIndex = 21;
            this.btnRightR.TabStop = false;
            this.btnRightR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRightR_MouseDown);
            this.btnRightR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRightR_MouseUp);
            // 
            // btnUpL
            // 
            this.btnUpL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpL.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnUpL.Location = new System.Drawing.Point(231, 414);
            this.btnUpL.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpL.Name = "btnUpL";
            this.btnUpL.Size = new System.Drawing.Size(60, 60);
            this.btnUpL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpL.TabIndex = 22;
            this.btnUpL.TabStop = false;
            this.btnUpL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpL_MouseDown);
            this.btnUpL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpL_MouseUp);
            // 
            // btnDownL
            // 
            this.btnDownL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDownL.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnDownL.Location = new System.Drawing.Point(231, 571);
            this.btnDownL.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownL.Name = "btnDownL";
            this.btnDownL.Size = new System.Drawing.Size(60, 60);
            this.btnDownL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDownL.TabIndex = 23;
            this.btnDownL.TabStop = false;
            this.btnDownL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDownL_MouseDown);
            this.btnDownL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDownL_MouseUp);
            // 
            // btnLeftL
            // 
            this.btnLeftL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeftL.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnLeftL.Location = new System.Drawing.Point(153, 492);
            this.btnLeftL.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftL.Name = "btnLeftL";
            this.btnLeftL.Size = new System.Drawing.Size(60, 60);
            this.btnLeftL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLeftL.TabIndex = 24;
            this.btnLeftL.TabStop = false;
            this.btnLeftL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeftL_MouseDown);
            this.btnLeftL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeftL_MouseUp);
            // 
            // btnRightL
            // 
            this.btnRightL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRightL.Image = global::Virtual_GPIO.Properties.Resources.btn_off;
            this.btnRightL.Location = new System.Drawing.Point(309, 492);
            this.btnRightL.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightL.Name = "btnRightL";
            this.btnRightL.Size = new System.Drawing.Size(60, 60);
            this.btnRightL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRightL.TabIndex = 25;
            this.btnRightL.TabStop = false;
            this.btnRightL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRightL_MouseDown);
            this.btnRightL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRightL_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 756);
            this.Controls.Add(this.btnRightL);
            this.Controls.Add(this.btnLeftL);
            this.Controls.Add(this.btnDownL);
            this.Controls.Add(this.btnUpL);
            this.Controls.Add(this.btnRightR);
            this.Controls.Add(this.btnLeftR);
            this.Controls.Add(this.btnDownR);
            this.Controls.Add(this.btnUpR);
            this.Controls.Add(this.sw0);
            this.Controls.Add(this.sw1);
            this.Controls.Add(this.sw2);
            this.Controls.Add(this.sw3);
            this.Controls.Add(this.sw4);
            this.Controls.Add(this.sw5);
            this.Controls.Add(this.sw6);
            this.Controls.Add(this.sw7);
            this.Controls.Add(this.comboBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Virtual GPIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.sw0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sw7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeftR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRightR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeftL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRightL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoard;
        private System.Windows.Forms.PictureBox sw7;
        private System.Windows.Forms.PictureBox sw6;
        private System.Windows.Forms.PictureBox sw4;
        private System.Windows.Forms.PictureBox sw5;
        private System.Windows.Forms.PictureBox sw2;
        private System.Windows.Forms.PictureBox sw3;
        private System.Windows.Forms.PictureBox sw0;
        private System.Windows.Forms.PictureBox sw1;
        private System.Windows.Forms.PictureBox btnUpR;
        private System.Windows.Forms.PictureBox btnDownR;
        private System.Windows.Forms.PictureBox btnLeftR;
        private System.Windows.Forms.PictureBox btnRightR;
        private System.Windows.Forms.PictureBox btnRightL;
        private System.Windows.Forms.PictureBox btnLeftL;
        private System.Windows.Forms.PictureBox btnDownL;
        private System.Windows.Forms.PictureBox btnUpL;
    }
}

