using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Despertador
{ 
    [Serializable]
    class guardar
    {
        private string hora;
        private string min;
        private string ruta;
        private string nombre;
        private List<string> dias;

        public string Hora { get => hora; set => hora = value; }
        public string Min { get => min; set => min = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<string> Dias { get => dias; set => dias = value; }

        public guardar(string hora, string min, string ruta, string nombre, List<string> dias) 
        {
            this.Hora = hora;
            this.Min = min;
            this.Ruta = ruta;
            this.Nombre = nombre;
            this.Dias = dias;

        }

        public int guardarInt() 
        {
            try
            {
                using (System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog())
                {
                    string path = Application.StartupPath + @"\settings";
                    dialog.FileName = path;
                    {
                        using (Stream st = File.Open(dialog.FileName, FileMode.Create))
                        {
                            var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            binfor.Serialize(st, this);
                            return 0;
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return 1;
            }
        }

    }
}
