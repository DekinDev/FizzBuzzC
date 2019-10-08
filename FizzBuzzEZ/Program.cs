﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzEZ
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            bool nuevaInstancia;
            using (Mutex mutex = new Mutex(true, Process.GetCurrentProcess().ProcessName, out nuevaInstancia))
            {
                if (nuevaInstancia)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                else
                {
                    MessageBox.Show("FizzBuzz ya está abierto.", "Repack Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
