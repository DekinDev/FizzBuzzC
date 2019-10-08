using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzEZ
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region DECLARACIONES GENERALES
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        int Jugadores;
        int JugadorActual;
        Logs oLog = new Logs(Application.StartupPath + @"\Logs");
        Logs oLog2 = new Logs(Application.StartupPath + @"\Logs");
        NumberControl ControlN = new NumberControl();
        string NumberControlResult;
        private int xz;
        private delegate void SafeCallDelegate(string text);
        #endregion

        #region FORMULARIO
        private void TopP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oLog2.Add2("INFO: Load Form1");
            MusicPlayer.settings.volume = 100;
            MusicPlayer.URL = (Application.StartupPath + @"\Music.mp3");
            MusicPlayer.Ctlcontrols.play();
            MusicPlayer.settings.setMode("loop", true);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(TXT.Text != "")
            {
                oLog.Add("Fin de la Partida");
            }
        }
        #endregion

        #region BOTONES JUGADORES
        private void ATRASBTN_Click(object sender, EventArgs e)
        {
            oLog.Add("Fin de la Partida");
            BTN1.Visible = true;
            BTN2.Visible = true;
            BTN3.Visible = true;
            BTN4.Visible = true;
            BTN5.Visible = true;
            BTN6.Visible = true;
            TXT.Visible = false;
            BTN0.Visible = false;
            ATRASBTN.Visible = false;
            RandomNumber.Visible = false;
            ResultFizzBuzz.Text = "";
            TopP.BackColor = Color.FromArgb(40, 40, 40);
            LeftP.BackColor = Color.FromArgb(40, 40, 40);
            RightP.BackColor = Color.FromArgb(40, 40, 40);
            BootomP.BackColor = Color.FromArgb(40, 40, 40);
            Close.BackColor = Color.FromArgb(40, 40, 40);
            Minimize.BackColor = Color.FromArgb(40, 40, 40);
            Title.BackColor = Color.FromArgb(40, 40, 40);
            BTN0.BackColor = Color.FromArgb(40, 40, 40);
            Sound.BackColor = Color.FromArgb(40, 40, 40);
            RandomNumber.BackColor = Color.FromArgb(40, 40, 40);
        }
        private void BTN1_Click(object sender, EventArgs e)
        {
            oLog.Add("Nueva Partida - 1 Jugador");
            Jugadores = 1;
            JugadorActual = 1;
            TopP.BackColor = BTN1.BackColor;
            LeftP.BackColor = BTN1.BackColor;
            RightP.BackColor = BTN1.BackColor;
            BootomP.BackColor = BTN1.BackColor;
            ATRASBTN.BackColor = BTN1.BackColor;
            Close.BackColor = BTN1.BackColor;
            Minimize.BackColor = BTN1.BackColor;
            Title.BackColor = BTN1.BackColor;
            BTN0.BackColor = BTN1.BackColor;
            Sound.BackColor = BTN1.BackColor;
            RandomNumber.BackColor = BTN1.BackColor;
            BTN1.Visible = false;
            BTN2.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;
            BTN5.Visible = false;
            BTN6.Visible = false;
            TXT.Visible = true;
            BTN0.Visible = true;
            ATRASBTN.Visible = true;
            RandomNumber.Visible = true;
            Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
            RandomNumberCTH.Start();
        }
        private void BTN2_Click(object sender, EventArgs e)
        {
            oLog.Add("Nueva Partida - 2 Jugadores");
            Jugadores = 2;
            JugadorActual = 1;
            TopP.BackColor = BTN1.BackColor;
            LeftP.BackColor = BTN1.BackColor;
            RightP.BackColor = BTN1.BackColor;
            BootomP.BackColor = BTN1.BackColor;
            ATRASBTN.BackColor = BTN1.BackColor;
            Close.BackColor = BTN1.BackColor;
            Minimize.BackColor = BTN1.BackColor;
            Title.BackColor = BTN1.BackColor;
            BTN0.BackColor = BTN1.BackColor;
            Sound.BackColor = BTN1.BackColor;
            RandomNumber.BackColor = BTN1.BackColor;
            BTN1.Visible = false;
            BTN2.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;
            BTN5.Visible = false;
            BTN6.Visible = false;
            TXT.Visible = true;
            BTN0.Visible = true;
            ATRASBTN.Visible = true;
            RandomNumber.Visible = true;
            Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
            RandomNumberCTH.Start();
        }
        private void BTN3_Click(object sender, EventArgs e)
        {
            oLog.Add("Nueva Partida - 3 Jugadores");
            Jugadores = 3;
            JugadorActual = 1;
            TopP.BackColor = BTN1.BackColor;
            LeftP.BackColor = BTN1.BackColor;
            RightP.BackColor = BTN1.BackColor;
            BootomP.BackColor = BTN1.BackColor;
            ATRASBTN.BackColor = BTN1.BackColor;
            Close.BackColor = BTN1.BackColor;
            Minimize.BackColor = BTN1.BackColor;
            Title.BackColor = BTN1.BackColor;
            BTN0.BackColor = BTN1.BackColor;
            Sound.BackColor = BTN1.BackColor;
            RandomNumber.BackColor = BTN1.BackColor;
            BTN1.Visible = false;
            BTN2.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;
            BTN5.Visible = false;
            BTN6.Visible = false;
            TXT.Visible = true;
            BTN0.Visible = true;
            ATRASBTN.Visible = true;
            RandomNumber.Visible = true;
            Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
            RandomNumberCTH.Start();
        }
        private void BTN4_Click(object sender, EventArgs e)
        {
            oLog.Add("Nueva Partida - 4 Jugadores");
            Jugadores = 4;
            JugadorActual = 1;
            TopP.BackColor = BTN1.BackColor;
            LeftP.BackColor = BTN1.BackColor;
            RightP.BackColor = BTN1.BackColor;
            BootomP.BackColor = BTN1.BackColor;
            ATRASBTN.BackColor = BTN1.BackColor;
            Close.BackColor = BTN1.BackColor;
            Minimize.BackColor = BTN1.BackColor;
            Title.BackColor = BTN1.BackColor;
            BTN0.BackColor = BTN1.BackColor;
            Sound.BackColor = BTN1.BackColor;
            RandomNumber.BackColor = BTN1.BackColor;
            BTN1.Visible = false;
            BTN2.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;
            BTN5.Visible = false;
            BTN6.Visible = false;
            TXT.Visible = true;
            BTN0.Visible = true;
            ATRASBTN.Visible = true;
            RandomNumber.Visible = true;
            Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
            RandomNumberCTH.Start();
        }
        private void BTN5_Click(object sender, EventArgs e)
        {
            oLog.Add("Nueva Partida - 5 Jugadores");
            Jugadores = 5;
            JugadorActual = 1;
            TopP.BackColor = BTN1.BackColor;
            LeftP.BackColor = BTN1.BackColor;
            RightP.BackColor = BTN1.BackColor;
            BootomP.BackColor = BTN1.BackColor;
            ATRASBTN.BackColor = BTN1.BackColor;
            Close.BackColor = BTN1.BackColor;
            Minimize.BackColor = BTN1.BackColor;
            Title.BackColor = BTN1.BackColor;
            BTN0.BackColor = BTN1.BackColor;
            Sound.BackColor = BTN1.BackColor;
            RandomNumber.BackColor = BTN1.BackColor;
            BTN1.Visible = false;
            BTN2.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;
            BTN5.Visible = false;
            BTN6.Visible = false;
            TXT.Visible = true;
            BTN0.Visible = true;
            ATRASBTN.Visible = true;
            RandomNumber.Visible = true;
            Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
            RandomNumberCTH.Start();
        }
        private void BTN6_Click(object sender, EventArgs e)
        {
            oLog.Add("Nueva Partida - 6 Jugadores");
            Jugadores = 6;
            JugadorActual = 1;
            TopP.BackColor = BTN1.BackColor;
            LeftP.BackColor = BTN1.BackColor;
            RightP.BackColor = BTN1.BackColor;
            BootomP.BackColor = BTN1.BackColor;
            ATRASBTN.BackColor = BTN1.BackColor;
            Close.BackColor = BTN1.BackColor;
            Minimize.BackColor = BTN1.BackColor;
            Title.BackColor = BTN1.BackColor;
            BTN0.BackColor = BTN1.BackColor;
            Sound.BackColor = BTN1.BackColor;
            RandomNumber.BackColor = BTN1.BackColor;
            BTN1.Visible = false;
            BTN2.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;
            BTN5.Visible = false;
            BTN6.Visible = false;
            TXT.Visible = true;
            BTN0.Visible = true;
            ATRASBTN.Visible = true;
            RandomNumber.Visible = true;
            Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
            RandomNumberCTH.Start();
        }
        #endregion

        #region BOTÓN INGRESAR
        private void BTN0_Click(object sender, EventArgs e)
        {
            oLog2.Add2("INFO: Botón ingresar numero");
            if (TXT.Text != "")
            {
                BTN0.Enabled = false;
                ResultFizzBuzz.Location = new Point(240, 466);
                xz = 0;
                TMover1.Stop();
                TMover2.Stop();
                TMover3.Stop();
                NumberControlResult = ControlN.FizzBuzz(TXT.Text);
                if (NumberControlResult != "")
                {
                    ResultFizzBuzz.Text = NumberControlResult;
                }
                if (ResultFizzBuzz.Text == "Fizz" || ResultFizzBuzz.Text == "Buzz" || ResultFizzBuzz.Text == "FizzBuzz")
                {
                    ErrorSound.settings.volume = 100;
                    ErrorSound.URL = (Application.StartupPath + @"\Error.mp3");
                    ErrorSound.Ctlcontrols.play();
                    MusicPlayer.settings.volume = 40;
                    TVolumen.Start();
                    TMover1.Start();
                }

                if (Jugadores == 2)
                {
                    if (JugadorActual == 1)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN2.BackColor;
                        LeftP.BackColor = BTN2.BackColor;
                        RightP.BackColor = BTN2.BackColor;
                        BootomP.BackColor = BTN2.BackColor;
                        ATRASBTN.BackColor = BTN2.BackColor;
                        Close.BackColor = BTN2.BackColor;
                        Minimize.BackColor = BTN2.BackColor;
                        Title.BackColor = BTN2.BackColor;
                        BTN0.BackColor = BTN2.BackColor;
                        Sound.BackColor = BTN2.BackColor;
                        RandomNumber.BackColor = BTN2.BackColor;
                    }
                    else if (JugadorActual == 2)
                    {
                        JugadorActual = 1;
                        TopP.BackColor = BTN1.BackColor;
                        LeftP.BackColor = BTN1.BackColor;
                        RightP.BackColor = BTN1.BackColor;
                        BootomP.BackColor = BTN1.BackColor;
                        ATRASBTN.BackColor = BTN1.BackColor;
                        Close.BackColor = BTN1.BackColor;
                        Minimize.BackColor = BTN1.BackColor;
                        Title.BackColor = BTN1.BackColor;
                        BTN0.BackColor = BTN1.BackColor;
                        Sound.BackColor = BTN1.BackColor;
                        RandomNumber.BackColor = BTN1.BackColor;
                    }
                }
                else if (Jugadores == 3)
                {
                    if (JugadorActual == 1)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN2.BackColor;
                        LeftP.BackColor = BTN2.BackColor;
                        RightP.BackColor = BTN2.BackColor;
                        BootomP.BackColor = BTN2.BackColor;
                        ATRASBTN.BackColor = BTN2.BackColor;
                        Close.BackColor = BTN2.BackColor;
                        Minimize.BackColor = BTN2.BackColor;
                        Title.BackColor = BTN2.BackColor;
                        BTN0.BackColor = BTN2.BackColor;
                        Sound.BackColor = BTN2.BackColor;
                        RandomNumber.BackColor = BTN2.BackColor;
                    }
                    else if (JugadorActual == 2)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN3.BackColor;
                        LeftP.BackColor = BTN3.BackColor;
                        RightP.BackColor = BTN3.BackColor;
                        BootomP.BackColor = BTN3.BackColor;
                        ATRASBTN.BackColor = BTN3.BackColor;
                        Close.BackColor = BTN3.BackColor;
                        Minimize.BackColor = BTN3.BackColor;
                        Title.BackColor = BTN3.BackColor;
                        BTN0.BackColor = BTN3.BackColor;
                        Sound.BackColor = BTN3.BackColor;
                        RandomNumber.BackColor = BTN3.BackColor;
                    }
                    else if (JugadorActual == 3)
                    {
                        JugadorActual = 1;
                        TopP.BackColor = BTN1.BackColor;
                        LeftP.BackColor = BTN1.BackColor;
                        RightP.BackColor = BTN1.BackColor;
                        BootomP.BackColor = BTN1.BackColor;
                        ATRASBTN.BackColor = BTN1.BackColor;
                        Close.BackColor = BTN1.BackColor;
                        Minimize.BackColor = BTN1.BackColor;
                        Title.BackColor = BTN1.BackColor;
                        BTN0.BackColor = BTN1.BackColor;
                        Sound.BackColor = BTN1.BackColor;
                        RandomNumber.BackColor = BTN1.BackColor;
                    }
                }
                else if (Jugadores == 4)
                {
                    if (JugadorActual == 1)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN2.BackColor;
                        LeftP.BackColor = BTN2.BackColor;
                        RightP.BackColor = BTN2.BackColor;
                        BootomP.BackColor = BTN2.BackColor;
                        ATRASBTN.BackColor = BTN2.BackColor;
                        Close.BackColor = BTN2.BackColor;
                        Minimize.BackColor = BTN2.BackColor;
                        Title.BackColor = BTN2.BackColor;
                        BTN0.BackColor = BTN2.BackColor;
                        Sound.BackColor = BTN2.BackColor;
                        RandomNumber.BackColor = BTN2.BackColor;
                    }
                    else if (JugadorActual == 2)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN3.BackColor;
                        LeftP.BackColor = BTN3.BackColor;
                        RightP.BackColor = BTN3.BackColor;
                        BootomP.BackColor = BTN3.BackColor;
                        ATRASBTN.BackColor = BTN3.BackColor;
                        Close.BackColor = BTN3.BackColor;
                        Minimize.BackColor = BTN3.BackColor;
                        Title.BackColor = BTN3.BackColor;
                        BTN0.BackColor = BTN3.BackColor;
                        Sound.BackColor = BTN3.BackColor;
                        RandomNumber.BackColor = BTN3.BackColor;
                    }
                    else if (JugadorActual == 3)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN4.BackColor;
                        LeftP.BackColor = BTN4.BackColor;
                        RightP.BackColor = BTN4.BackColor;
                        BootomP.BackColor = BTN4.BackColor;
                        ATRASBTN.BackColor = BTN4.BackColor;
                        Close.BackColor = BTN4.BackColor;
                        Minimize.BackColor = BTN4.BackColor;
                        Title.BackColor = BTN4.BackColor;
                        BTN0.BackColor = BTN4.BackColor;
                        Sound.BackColor = BTN4.BackColor;
                        RandomNumber.BackColor = BTN4.BackColor;
                    }
                    else if (JugadorActual == 4)
                    {
                        JugadorActual = 1;
                        TopP.BackColor = BTN1.BackColor;
                        LeftP.BackColor = BTN1.BackColor;
                        RightP.BackColor = BTN1.BackColor;
                        BootomP.BackColor = BTN1.BackColor;
                        ATRASBTN.BackColor = BTN1.BackColor;
                        Close.BackColor = BTN1.BackColor;
                        Minimize.BackColor = BTN1.BackColor;
                        Title.BackColor = BTN1.BackColor;
                        BTN0.BackColor = BTN1.BackColor;
                        Sound.BackColor = BTN1.BackColor;
                        RandomNumber.BackColor = BTN1.BackColor;
                    }
                }
                else if (Jugadores == 5)
                {
                    if (JugadorActual == 1)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN2.BackColor;
                        LeftP.BackColor = BTN2.BackColor;
                        RightP.BackColor = BTN2.BackColor;
                        BootomP.BackColor = BTN2.BackColor;
                        ATRASBTN.BackColor = BTN2.BackColor;
                        Close.BackColor = BTN2.BackColor;
                        Minimize.BackColor = BTN2.BackColor;
                        Title.BackColor = BTN2.BackColor;
                        BTN0.BackColor = BTN2.BackColor;
                        Sound.BackColor = BTN2.BackColor;
                        RandomNumber.BackColor = BTN2.BackColor;
                    }
                    else if (JugadorActual == 2)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN3.BackColor;
                        LeftP.BackColor = BTN3.BackColor;
                        RightP.BackColor = BTN3.BackColor;
                        BootomP.BackColor = BTN3.BackColor;
                        ATRASBTN.BackColor = BTN3.BackColor;
                        Close.BackColor = BTN3.BackColor;
                        Minimize.BackColor = BTN3.BackColor;
                        Title.BackColor = BTN3.BackColor;
                        BTN0.BackColor = BTN3.BackColor;
                        Sound.BackColor = BTN3.BackColor;
                        RandomNumber.BackColor = BTN3.BackColor;
                    }
                    else if (JugadorActual == 3)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN4.BackColor;
                        LeftP.BackColor = BTN4.BackColor;
                        RightP.BackColor = BTN4.BackColor;
                        BootomP.BackColor = BTN4.BackColor;
                        ATRASBTN.BackColor = BTN4.BackColor;
                        Close.BackColor = BTN4.BackColor;
                        Minimize.BackColor = BTN4.BackColor;
                        Title.BackColor = BTN4.BackColor;
                        BTN0.BackColor = BTN4.BackColor;
                        Sound.BackColor = BTN4.BackColor;
                        RandomNumber.BackColor = BTN4.BackColor;
                    }
                    else if (JugadorActual == 4)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN5.BackColor;
                        LeftP.BackColor = BTN5.BackColor;
                        RightP.BackColor = BTN5.BackColor;
                        BootomP.BackColor = BTN5.BackColor;
                        ATRASBTN.BackColor = BTN5.BackColor;
                        Close.BackColor = BTN5.BackColor;
                        Minimize.BackColor = BTN5.BackColor;
                        Title.BackColor = BTN5.BackColor;
                        BTN0.BackColor = BTN5.BackColor;
                        Sound.BackColor = BTN5.BackColor;
                        RandomNumber.BackColor = BTN5.BackColor;
                    }
                    else if (JugadorActual == 5)
                    {
                        JugadorActual = 1;
                        TopP.BackColor = BTN1.BackColor;
                        LeftP.BackColor = BTN1.BackColor;
                        RightP.BackColor = BTN1.BackColor;
                        BootomP.BackColor = BTN1.BackColor;
                        ATRASBTN.BackColor = BTN1.BackColor;
                        Close.BackColor = BTN1.BackColor;
                        Minimize.BackColor = BTN1.BackColor;
                        Title.BackColor = BTN1.BackColor;
                        BTN0.BackColor = BTN1.BackColor;
                        Sound.BackColor = BTN1.BackColor;
                        RandomNumber.BackColor = BTN1.BackColor;
                    }
                }
                else if (Jugadores == 6)
                {
                    if (JugadorActual == 1)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN2.BackColor;
                        LeftP.BackColor = BTN2.BackColor;
                        RightP.BackColor = BTN2.BackColor;
                        BootomP.BackColor = BTN2.BackColor;
                        ATRASBTN.BackColor = BTN2.BackColor;
                        Close.BackColor = BTN2.BackColor;
                        Minimize.BackColor = BTN2.BackColor;
                        Title.BackColor = BTN2.BackColor;
                        BTN0.BackColor = BTN2.BackColor;
                        Sound.BackColor = BTN2.BackColor;
                        RandomNumber.BackColor = BTN2.BackColor;
                    }
                    else if (JugadorActual == 2)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN3.BackColor;
                        LeftP.BackColor = BTN3.BackColor;
                        RightP.BackColor = BTN3.BackColor;
                        BootomP.BackColor = BTN3.BackColor;
                        ATRASBTN.BackColor = BTN3.BackColor;
                        Close.BackColor = BTN3.BackColor;
                        Minimize.BackColor = BTN3.BackColor;
                        Title.BackColor = BTN3.BackColor;
                        BTN0.BackColor = BTN3.BackColor;
                        Sound.BackColor = BTN3.BackColor;
                        RandomNumber.BackColor = BTN3.BackColor;
                    }
                    else if (JugadorActual == 3)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN4.BackColor;
                        LeftP.BackColor = BTN4.BackColor;
                        RightP.BackColor = BTN4.BackColor;
                        BootomP.BackColor = BTN4.BackColor;
                        ATRASBTN.BackColor = BTN4.BackColor;
                        Close.BackColor = BTN4.BackColor;
                        Minimize.BackColor = BTN4.BackColor;
                        Title.BackColor = BTN4.BackColor;
                        BTN0.BackColor = BTN4.BackColor;
                        Sound.BackColor = BTN4.BackColor;
                        RandomNumber.BackColor = BTN4.BackColor;
                    }
                    else if (JugadorActual == 4)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN5.BackColor;
                        LeftP.BackColor = BTN5.BackColor;
                        RightP.BackColor = BTN5.BackColor;
                        BootomP.BackColor = BTN5.BackColor;
                        ATRASBTN.BackColor = BTN5.BackColor;
                        Close.BackColor = BTN5.BackColor;
                        Minimize.BackColor = BTN5.BackColor;
                        Title.BackColor = BTN5.BackColor;
                        BTN0.BackColor = BTN5.BackColor;
                        Sound.BackColor = BTN5.BackColor;
                        RandomNumber.BackColor = BTN5.BackColor;
                    }
                    else if (JugadorActual == 5)
                    {
                        JugadorActual = JugadorActual + 1;
                        TopP.BackColor = BTN6.BackColor;
                        LeftP.BackColor = BTN6.BackColor;
                        RightP.BackColor = BTN6.BackColor;
                        BootomP.BackColor = BTN6.BackColor;
                        ATRASBTN.BackColor = BTN6.BackColor;
                        Close.BackColor = BTN6.BackColor;
                        Minimize.BackColor = BTN6.BackColor;
                        Title.BackColor = BTN6.BackColor;
                        BTN0.BackColor = BTN6.BackColor;
                        Sound.BackColor = BTN6.BackColor;
                        RandomNumber.BackColor = BTN6.BackColor;
                    }
                    else if (JugadorActual == 6)
                    {
                        JugadorActual = 1;
                        TopP.BackColor = BTN1.BackColor;
                        LeftP.BackColor = BTN1.BackColor;
                        RightP.BackColor = BTN1.BackColor;
                        BootomP.BackColor = BTN1.BackColor;
                        ATRASBTN.BackColor = BTN1.BackColor;
                        Close.BackColor = BTN1.BackColor;
                        Minimize.BackColor = BTN1.BackColor;
                        Title.BackColor = BTN1.BackColor;
                        BTN0.BackColor = BTN1.BackColor;
                        Sound.BackColor = BTN1.BackColor;
                        RandomNumber.BackColor = BTN1.BackColor;
                    }
                }
            }
            else
            {
                oLog2.Add2("WARNING: No hay número");
                MessageBox.Show("No hay número", "Fizz-Buzz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT.Enabled = true;
            }
        }
        #endregion

        #region MULTITHREAD RANDOMNUMBER
        private void RandomNumber_Click(object sender, EventArgs e)
        {
            try
            {
                Thread RandomNumberCTH = new Thread(new ThreadStart(RandomNumberC));
                RandomNumberCTH.Start();
            }
            catch (Exception ex)
            {
                oLog2.Add2("ERROR: " + ex.Message);
            }
        }

        public void RandomNumberC()
        {
            try
            {
                ResultFizzBuzz.Text = "";
                Random rnd = new Random();
                int RandomNum = rnd.Next(0, 100);
                WriteTextSafe(RandomNum.ToString());
            }
            catch (Exception ex)
            {
                oLog2.Add2("ERROR: " + ex.Message);
            }
        }


        private void WriteTextSafe(string text)
        {
            try
            {
                if (TXT.InvokeRequired)
                {
                    var d = new SafeCallDelegate(WriteTextSafe);
                    TXT.Invoke(d, new object[] { text });
                }
                else
                {
                    TXT.Text = text;
                }
            }
            catch (Exception ex)
            {
                oLog2.Add2("ERROR: " + ex.Message);
            }
        }
        #endregion

        #region MUSICA
        private void TVolumen_Tick(object sender, EventArgs e)
        {
            MusicPlayer.settings.volume = 100;
            TVolumen.Stop();
        }

        int Play = 0;
        private void Sound_Click(object sender, EventArgs e)
        {
            try
            {
                if (Play == 0)
                {
                    Play = 1;
                    MusicPlayer.Ctlcontrols.pause();
                    Sound.BackgroundImage = Properties.Resources.Sound2;
                }
                else if (Play == 1)
                {
                    Play = 0;
                    MusicPlayer.URL = (Application.StartupPath + @"\Music.mp3");
                    MusicPlayer.Ctlcontrols.play();
                    Sound.BackgroundImage = Properties.Resources.Sound;
                }
            }
            catch (Exception ex)
            {
                oLog2.Add2("ERROR: " + ex.Message);
            }
        }
        #endregion

        #region CUADROS DE TEXTO
        private void TXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BTN0.Enabled = true;
                ResultFizzBuzz.Text = "";
                long ContadorNumeros = Convert.ToInt64(TXT.Text);

                if (ContadorNumeros >= 101)
                {
                    MessageBox.Show("Números del 0 al 100.", "Fizz-Buzz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT.Text = "0";
                }
            }
            catch (Exception ex)
            {
                oLog2.Add2("ERROR: " + ex.Message);
            }

        }
        #endregion

        #region MOVIMIENTO
        private void TMover_Tick(object sender, EventArgs e)
        {
            xz = xz + 10;
            ResultFizzBuzz.Location = new Point(240 - xz, 466);
            if (ResultFizzBuzz.Location == new Point(220, 466))
            {
                xz = 0;
                TMover1.Stop();
                TMover2.Start();
            }
        }

        private void TMover2_Tick(object sender, EventArgs e)
        {
            xz = xz + 10;
            ResultFizzBuzz.Location = new Point(200 + xz, 466);
            if (ResultFizzBuzz.Location == new Point(280, 466))
            {
                xz = 0;
                TMover3.Start();
                TMover2.Stop();
            }
        }

        private void TMover3_Tick(object sender, EventArgs e)
        {
            xz = xz + 10;
            ResultFizzBuzz.Location = new Point(280 - xz, 466);
            if (ResultFizzBuzz.Location == new Point(240, 466))
            {
                xz = 0;
                TMover3.Stop();
            }
        }
        #endregion
    }
}
