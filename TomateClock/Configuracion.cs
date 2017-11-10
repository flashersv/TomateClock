using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TomateClock
{
    public partial class Configuracion : Form
    {

        private Timer _timer;

        public Configuracion()
        {
            InitializeComponent();
        }

        public Configuracion(Timer timer)
        {
            InitializeComponent();
            _timer = timer;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            int intervalo = Properties.Settings.Default.tiempoIntervalo;
            int descanso = Properties.Settings.Default.tiempoDescansoMayor;

            if(intervalo == 20)
            {
                radioButton1.Checked = true;
            }
            else if(intervalo == 25)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }

            if(descanso == 25)
            {
                radioButton5.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tiempoIntervalo = 20;
            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tiempoIntervalo = 25;
            Properties.Settings.Default.Save();
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tiempoIntervalo = 30;
            Properties.Settings.Default.Save();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            _timer.Start();  
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tiempoDescansoMayor = 25;
            Properties.Settings.Default.Save();
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tiempoDescansoMayor = 30;
            Properties.Settings.Default.Save();
            
        }
    }
}
