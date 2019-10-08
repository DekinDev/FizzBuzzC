using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FizzBuzzEZ
{
    class Logs
    {
        #region LOG PARTIDAS
        private string Path = "";
        public Logs(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {
            try
            {
                CreateDirectory();
                string nombre = GetNameFile();
                string cadena = "";
                cadena += DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "|: " + sLog + Environment.NewLine;

                using (StreamWriter sr = new StreamWriter(Path + "/" + nombre, true))
                {
                    sr.Write(cadena);
                    sr.Close();
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private string GetNameFile()
        {
            string nombre = "";
            nombre = "Log_Numeros_" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt";
            return nombre;
        }

        private void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region LOG ERRORES
        private string Path2 = "";

        public void Add2(string sLog)
        {
            try
            {
                CreateDirectory2();
                string nombre = GetNameFile2();
                string cadena = "";
                cadena += DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "|: " + sLog + Environment.NewLine;

                using (StreamWriter sr = new StreamWriter(Path + "/" + nombre, true))
                {
                    sr.Write(cadena);
                    sr.Close();
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private string GetNameFile2()
        {
            string nombre = "";

            nombre = "Log_Error_" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt";

            return nombre;
        }

        private void CreateDirectory2()
        {
            try
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
