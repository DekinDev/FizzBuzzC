namespace FizzBuzzEZ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.Sound = new System.Windows.Forms.PictureBox();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.ATRASBTN = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN0 = new System.Windows.Forms.Button();
            this.TXT = new System.Windows.Forms.TextBox();
            this.RandomNumber = new System.Windows.Forms.PictureBox();
            this.ResultFizzBuzz = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.TopP = new System.Windows.Forms.PictureBox();
            this.BootomP = new System.Windows.Forms.PictureBox();
            this.RightP = new System.Windows.Forms.PictureBox();
            this.LeftP = new System.Windows.Forms.PictureBox();
            this.TMover1 = new System.Windows.Forms.Timer(this.components);
            this.TMover2 = new System.Windows.Forms.Timer(this.components);
            this.TMover3 = new System.Windows.Forms.Timer(this.components);
            this.TVolumen = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BootomP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ErrorSound);
            this.panel1.Controls.Add(this.Sound);
            this.panel1.Controls.Add(this.MusicPlayer);
            this.panel1.Controls.Add(this.ATRASBTN);
            this.panel1.Controls.Add(this.BTN2);
            this.panel1.Controls.Add(this.BTN5);
            this.panel1.Controls.Add(this.BTN6);
            this.panel1.Controls.Add(this.BTN3);
            this.panel1.Controls.Add(this.BTN4);
            this.panel1.Controls.Add(this.BTN1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTN0);
            this.panel1.Controls.Add(this.TXT);
            this.panel1.Controls.Add(this.RandomNumber);
            this.panel1.Controls.Add(this.ResultFizzBuzz);
            this.panel1.Location = new System.Drawing.Point(10, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 597);
            this.panel1.TabIndex = 238;
            // 
            // ErrorSound
            // 
            this.ErrorSound.Enabled = true;
            this.ErrorSound.Location = new System.Drawing.Point(669, 568);
            this.ErrorSound.Name = "ErrorSound";
            this.ErrorSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ErrorSound.OcxState")));
            this.ErrorSound.Size = new System.Drawing.Size(19, 23);
            this.ErrorSound.TabIndex = 253;
            this.ErrorSound.Visible = false;
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Sound.BackgroundImage = global::FizzBuzzEZ.Properties.Resources.Sound;
            this.Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sound.Location = new System.Drawing.Point(718, 565);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(30, 30);
            this.Sound.TabIndex = 251;
            this.Sound.TabStop = false;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(694, 568);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(19, 23);
            this.MusicPlayer.TabIndex = 250;
            this.MusicPlayer.Visible = false;
            // 
            // ATRASBTN
            // 
            this.ATRASBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ATRASBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ATRASBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ATRASBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.ATRASBTN.FlatAppearance.BorderSize = 0;
            this.ATRASBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ATRASBTN.Font = new System.Drawing.Font("Maiandra GD", 15F);
            this.ATRASBTN.ForeColor = System.Drawing.Color.White;
            this.ATRASBTN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ATRASBTN.Location = new System.Drawing.Point(3, 555);
            this.ATRASBTN.Name = "ATRASBTN";
            this.ATRASBTN.Size = new System.Drawing.Size(87, 39);
            this.ATRASBTN.TabIndex = 249;
            this.ATRASBTN.Text = "Atrás";
            this.ATRASBTN.UseVisualStyleBackColor = false;
            this.ATRASBTN.Visible = false;
            this.ATRASBTN.Click += new System.EventHandler(this.ATRASBTN_Click);
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BTN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN2.FlatAppearance.BorderSize = 0;
            this.BTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN2.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.BTN2.ForeColor = System.Drawing.Color.White;
            this.BTN2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN2.Location = new System.Drawing.Point(381, 295);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(228, 69);
            this.BTN2.TabIndex = 244;
            this.BTN2.Text = "2 JUGADORES";
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN5
            // 
            this.BTN5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN5.FlatAppearance.BorderSize = 0;
            this.BTN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN5.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.BTN5.ForeColor = System.Drawing.Color.White;
            this.BTN5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN5.Location = new System.Drawing.Point(142, 455);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(228, 69);
            this.BTN5.TabIndex = 243;
            this.BTN5.Text = "5 JUGADSORES";
            this.BTN5.UseVisualStyleBackColor = false;
            this.BTN5.Click += new System.EventHandler(this.BTN5_Click);
            // 
            // BTN6
            // 
            this.BTN6.BackColor = System.Drawing.Color.Blue;
            this.BTN6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN6.FlatAppearance.BorderSize = 0;
            this.BTN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN6.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.BTN6.ForeColor = System.Drawing.Color.White;
            this.BTN6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN6.Location = new System.Drawing.Point(381, 455);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(228, 69);
            this.BTN6.TabIndex = 242;
            this.BTN6.Text = "6 JUGADORES";
            this.BTN6.UseVisualStyleBackColor = false;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // BTN3
            // 
            this.BTN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.BTN3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN3.FlatAppearance.BorderSize = 0;
            this.BTN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN3.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.BTN3.ForeColor = System.Drawing.Color.White;
            this.BTN3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN3.Location = new System.Drawing.Point(142, 375);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(228, 69);
            this.BTN3.TabIndex = 241;
            this.BTN3.Text = "3 JUGADORES";
            this.BTN3.UseVisualStyleBackColor = false;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // BTN4
            // 
            this.BTN4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.BTN4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN4.FlatAppearance.BorderSize = 0;
            this.BTN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN4.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.BTN4.ForeColor = System.Drawing.Color.White;
            this.BTN4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN4.Location = new System.Drawing.Point(381, 374);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(228, 69);
            this.BTN4.TabIndex = 240;
            this.BTN4.Text = "4 JUGADORES";
            this.BTN4.UseVisualStyleBackColor = false;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN1
            // 
            this.BTN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN1.FlatAppearance.BorderSize = 0;
            this.BTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN1.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.ForeColor = System.Drawing.Color.White;
            this.BTN1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN1.Location = new System.Drawing.Point(142, 295);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(228, 69);
            this.BTN1.TabIndex = 239;
            this.BTN1.Text = "1 JUGADOR";
            this.BTN1.UseVisualStyleBackColor = false;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FizzBuzzEZ.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(59, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 159);
            this.pictureBox1.TabIndex = 238;
            this.pictureBox1.TabStop = false;
            // 
            // BTN0
            // 
            this.BTN0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(64)))));
            this.BTN0.FlatAppearance.BorderSize = 0;
            this.BTN0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN0.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN0.ForeColor = System.Drawing.Color.White;
            this.BTN0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN0.Location = new System.Drawing.Point(240, 387);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(270, 69);
            this.BTN0.TabIndex = 248;
            this.BTN0.Text = "INGRESAR";
            this.BTN0.UseVisualStyleBackColor = false;
            this.BTN0.Visible = false;
            this.BTN0.Click += new System.EventHandler(this.BTN0_Click);
            // 
            // TXT
            // 
            this.TXT.Font = new System.Drawing.Font("Maiandra GD", 30F, System.Drawing.FontStyle.Bold);
            this.TXT.Location = new System.Drawing.Point(240, 326);
            this.TXT.MaxLength = 3;
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(270, 55);
            this.TXT.TabIndex = 247;
            this.TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT.Visible = false;
            this.TXT.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            this.TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_KeyPress);
            // 
            // RandomNumber
            // 
            this.RandomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RandomNumber.BackgroundImage = global::FizzBuzzEZ.Properties.Resources.Random;
            this.RandomNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomNumber.Location = new System.Drawing.Point(350, 264);
            this.RandomNumber.Name = "RandomNumber";
            this.RandomNumber.Size = new System.Drawing.Size(50, 50);
            this.RandomNumber.TabIndex = 252;
            this.RandomNumber.TabStop = false;
            this.RandomNumber.Visible = false;
            this.RandomNumber.Click += new System.EventHandler(this.RandomNumber_Click);
            // 
            // ResultFizzBuzz
            // 
            this.ResultFizzBuzz.BackColor = System.Drawing.Color.Transparent;
            this.ResultFizzBuzz.Font = new System.Drawing.Font("Maiandra GD", 40F);
            this.ResultFizzBuzz.ForeColor = System.Drawing.Color.Black;
            this.ResultFizzBuzz.Location = new System.Drawing.Point(240, 466);
            this.ResultFizzBuzz.Name = "ResultFizzBuzz";
            this.ResultFizzBuzz.Size = new System.Drawing.Size(270, 66);
            this.ResultFizzBuzz.TabIndex = 240;
            this.ResultFizzBuzz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Title.Font = new System.Drawing.Font("Maiandra GD", 15F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(90, 24);
            this.Title.TabIndex = 239;
            this.Title.Text = "Fizz-Buzz";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Minimize.BackgroundImage = global::FizzBuzzEZ.Properties.Resources.Minimizar;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Location = new System.Drawing.Point(693, 7);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 6;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Close.BackgroundImage = global::FizzBuzzEZ.Properties.Resources.Close;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(729, 7);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 5;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TopP
            // 
            this.TopP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TopP.Location = new System.Drawing.Point(0, 0);
            this.TopP.Name = "TopP";
            this.TopP.Size = new System.Drawing.Size(770, 44);
            this.TopP.TabIndex = 1;
            this.TopP.TabStop = false;
            this.TopP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopP_MouseDown);
            // 
            // BootomP
            // 
            this.BootomP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BootomP.Location = new System.Drawing.Point(-13, 640);
            this.BootomP.Name = "BootomP";
            this.BootomP.Size = new System.Drawing.Size(784, 10);
            this.BootomP.TabIndex = 4;
            this.BootomP.TabStop = false;
            // 
            // RightP
            // 
            this.RightP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RightP.Location = new System.Drawing.Point(760, 35);
            this.RightP.Name = "RightP";
            this.RightP.Size = new System.Drawing.Size(10, 625);
            this.RightP.TabIndex = 3;
            this.RightP.TabStop = false;
            // 
            // LeftP
            // 
            this.LeftP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LeftP.Location = new System.Drawing.Point(0, 28);
            this.LeftP.Name = "LeftP";
            this.LeftP.Size = new System.Drawing.Size(10, 625);
            this.LeftP.TabIndex = 2;
            this.LeftP.TabStop = false;
            // 
            // TMover1
            // 
            this.TMover1.Interval = 1;
            this.TMover1.Tick += new System.EventHandler(this.TMover_Tick);
            // 
            // TMover2
            // 
            this.TMover2.Interval = 1;
            this.TMover2.Tick += new System.EventHandler(this.TMover2_Tick);
            // 
            // TMover3
            // 
            this.TMover3.Interval = 1;
            this.TMover3.Tick += new System.EventHandler(this.TMover3_Tick);
            // 
            // TVolumen
            // 
            this.TVolumen.Interval = 1500;
            this.TVolumen.Tick += new System.EventHandler(this.TVolumen_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 650);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TopP);
            this.Controls.Add(this.BootomP);
            this.Controls.Add(this.RightP);
            this.Controls.Add(this.LeftP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fizz-Buzz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BootomP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopP;
        private System.Windows.Forms.PictureBox LeftP;
        private System.Windows.Forms.PictureBox RightP;
        private System.Windows.Forms.PictureBox BootomP;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button BTN2;
        internal System.Windows.Forms.Button BTN5;
        internal System.Windows.Forms.Button BTN6;
        internal System.Windows.Forms.Button BTN3;
        internal System.Windows.Forms.Button BTN4;
        internal System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.TextBox TXT;
        internal System.Windows.Forms.Button ATRASBTN;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Sound;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.PictureBox RandomNumber;
        private System.Windows.Forms.Label ResultFizzBuzz;
        private AxWMPLib.AxWindowsMediaPlayer ErrorSound;
        private System.Windows.Forms.Timer TMover1;
        private System.Windows.Forms.Timer TMover2;
        private System.Windows.Forms.Timer TMover3;
        private System.Windows.Forms.Timer TVolumen;

    }
}

