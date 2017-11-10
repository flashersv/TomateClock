﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TomateClock
{
    public partial class Form1 : Form
    {
        int intervalo = 1;
        int conteoSegundos;
        int conteoMinutos;
        int controlDescanso = 0;
        string losSegundos;
        string losMinutos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "TomateClock - Técnica de Pomodoro";
            losMinutos = "00";
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conteoSegundos = 0;
            conteoMinutos = 0;
            timer1.Start();
            button1.Enabled = false;
            button4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteoSegundos++;
            Tiempo();
        }

        public void Tiempo()
        {
            
            if (conteoSegundos <= 9)
            {
                losSegundos = "0" + conteoSegundos.ToString();
            }
            else
            {
                losSegundos = conteoSegundos.ToString();
            }

            if (conteoSegundos >= 60)
            {
                conteoSegundos = 0;
                losSegundos = "00";
                conteoMinutos++;

                if (conteoMinutos <= 9)
                {
                    losMinutos = "0" + (conteoMinutos).ToString();
                }
                else
                {
                    losMinutos = (conteoMinutos).ToString();
                }

                if (controlDescanso == 0)
                {
                    if (conteoMinutos >= 25)
                    {
                        timer1.Stop();
                        conteoMinutos = 0;
                        conteoSegundos = 0;
                        notificacionTaskBar("TomateClock - Intervalo terminado", "A descansar se ha dicho!");

                        if (MessageBox.Show("Haz click en Aceptar para iniciar descanso", "Termino intervalo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            losMinutos = "00";
                            controlDescanso = 1;
                            panel1.Visible = true;
                            timer1.Start();
                        }

                        if (intervalo < 4)
                        {
                            intervalo_lb.Text = "El intervalo " + intervalo.ToString() + " Finalizó";
                            label1.Text = "Estas en período de descanso (5 minutos):";
                        }
                        else
                        {
                            intervalo_lb.Text = "Finalizaron los 4 intervalos, descansa 25 minutos y vuelve a iniciar la aplicación";
                            label1.Text = "Mereces un descanso! de 25 minutos:";
                        }
                    }
                }
                else
                {
                    if (intervalo < 4)
                    {
                        if (conteoMinutos >= 5)
                        {
                            timer1.Stop();
                            conteoMinutos = 0;
                            conteoSegundos = 0;
                            notificacionTaskBar("TomateClock - Fin del descanso", "Regresemos a trabajar");

                            if (MessageBox.Show("A trabajar nuevamente!", "Se terminó el descanso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                            {
                                losMinutos = "00";
                                controlDescanso = 0;
                                intervalo++;
                                intervalo_lb.Text = "Intervalo" + intervalo.ToString();
                                panel1.Visible = false;
                                timer1.Start();
                            }
                        }
                    }
                    else
                    {
                        if (conteoMinutos >= 25)
                        {
                            timer1.Stop();
                            conteoMinutos = 0;
                            conteoSegundos = 0;
                            notificacionTaskBar("TomateClock - Tiempo terminado", "Finalizaste con exito 4 intervalos e hiciste los descansos");

                            if (MessageBox.Show("Terminaste los 4 intervalos y el descanso de 25 minutos. El conteo volverá a iniciar", "Se acabo el descanso de 25 minutos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                            {
                                losMinutos = "00";
                                controlDescanso = 0;
                                intervalo = 1;
                                intervalo_lb.Text = "Intervalo" + intervalo.ToString();
                                panel1.Visible = false;
                                timer1.Start();
                            }
                        }
                    }
                }
            }
            if (controlDescanso == 0)
            {
                segundos.Text = losSegundos;
                minutos.Text = losMinutos;
            }
            else
            {
                segundosNull.Text = losSegundos;
                minutosNull.Text = losMinutos;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if(MessageBox.Show("¿Desea reiniciar la aplicación?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                button4.Enabled = false;
                button1.Enabled = true;
                Application.Restart();
                Environment.Exit(0);
            }
        }

        public void notificacionTaskBar(string titulo, string contenido)
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = titulo;
            notifyIcon1.BalloonTipText = contenido;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }

        private void técnicaPomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoInfo = "La Técnica Pomodoro es un método para mejorar la administración ";
            textoInfo += "del tiempo, desarrollado por Francesco Cirillo a fines de los años 1980. ";
            textoInfo += "Divide el tiempo dedicado a un trabajo en intervalos de 25 minutos -llamados ";
            textoInfo += "'pomodoros' y descansar 5 minutos después. Al llegar a 4 intervalos, ";
            textoInfo += "descansar entre 20 y 30 minutos, para luego empezar nuevamente a contar desde cero.";
            MessageBox.Show(textoInfo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pequeña aplicación realizada por Ludwin Rodríguez Salinas, de El Salvador, Centroamérica. E-mail flashersv@gmail.com", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form conf = new Configuracion(timer1);
            timer1.Stop();
            conf.ShowDialog();
        }
    }
}
