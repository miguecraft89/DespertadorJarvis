using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Despertador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            song.CreateControl();
            cargar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        AxWMPLib.AxWindowsMediaPlayer song = new AxWMPLib.AxWindowsMediaPlayer();
        SoundPlayer open;
        SoundPlayer listo;
        SoundPlayer cerrar;
       

        string ruta = string.Empty;
        string archivo = string.Empty;
        List<string> dias = new List<string>();
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.SafeFileName;
                ruta = ofd.FileName;
                song.URL = ruta;                
                song.settings.setMode("loop", true);
                song.Ctlcontrols.stop();
                lblCancion.Text = archivo;
                lblCancion.Location = new Point(this.ClientSize.Width / 2 - lblCancion.Width / 2, lblCancion.Location.Y);

            }
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (cbTodos.Checked)
                    {
                        ((CheckBox)c).Checked = true;
                    }
                    else
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
            lblDia.Text = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
            string hora = DateTime.Now.Hour.ToString("00");
            lblhora.Text = DateTime.Now.Hour.ToString("00");
            string minutos = DateTime.Now.Minute.ToString("00");
            lblminutos.Text = DateTime.Now.Minute.ToString("00");

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    if (dia == c.Text.ToLower().ToString() && minutos == tbMinutos.Text.ToString() && hora == tbHoras.Text.ToString())
                    {
                        try
                        {
                            song.Ctlcontrols.play();
                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                   
                }
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            song.Ctlcontrols.stop();
            lblEstado.Text = "Alarma desactivada";
            lblEstado.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblEstado.Text = "Alarma activada";
            lblEstado.BackColor = Color.Lime;
            listo.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            song.Ctlcontrols.stop();

            try
            {
                open = new SoundPlayer(Application.StartupPath + @"\Canciones\open.wav");
                listo =new SoundPlayer(Application.StartupPath+ @"\Canciones\listo.wav");
                cerrar = new SoundPlayer(Application.StartupPath + @"\Canciones\cerrarApp.wav");
                open.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dias.Clear();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                    {
                        dias.Add(cb.Text);//Talvez esto esta mal
                    }
                }
            }
            guardar g = new guardar(tbHoras.Text, tbMinutos.Text, ruta, archivo, dias);//talvez aqui esta mal
            int res = g.guardarInt();

           
        }

        public void cargar() 
        {
            string path = Application.StartupPath + @"\settings";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            try
            {
                var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                guardar g = (guardar)binfor.Deserialize(fs);

                tbHoras.Text = g.Hora;
                tbMinutos.Text = g.Min;
                ruta = g.Ruta;
                archivo = g.Nombre;
                dias = g.Dias;

                foreach (Control c in this.Controls) 
                {
                    if (dias.Count > 0)
                    {
                        for (int i = 0; i < dias.Count; i++)
                        {
                            if (c.Text == dias[i])
                            {
                                ((CheckBox)c).Checked = true;
                            }
                        }
                    }
                }

                song.URL = ruta;
                song.Ctlcontrols.stop();
                lblCancion.Text = archivo;
                lblCancion.Location = new Point(this.ClientSize.Width / 2 - lblCancion.Width / 2, lblCancion.Location.Y);

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            fs.Close();
        }

        

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar.Play();

            DialogResult = MessageBox.Show("¿Desea guardar?");
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
