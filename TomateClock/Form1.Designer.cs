namespace TomateClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.minutos = new System.Windows.Forms.TextBox();
            this.segundos = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.intervalo_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minutosNull = new System.Windows.Forms.TextBox();
            this.segundosNull = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicaPomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(284, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minutos
            // 
            this.minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.Location = new System.Drawing.Point(12, 47);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(123, 83);
            this.minutos.TabIndex = 3;
            this.minutos.TabStop = false;
            this.minutos.Text = "00";
            this.minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segundos
            // 
            this.segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.Location = new System.Drawing.Point(155, 47);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(123, 83);
            this.segundos.TabIndex = 4;
            this.segundos.TabStop = false;
            this.segundos.Text = "00";
            this.segundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(14, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // intervalo_lb
            // 
            this.intervalo_lb.AutoSize = true;
            this.intervalo_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalo_lb.ForeColor = System.Drawing.Color.DarkRed;
            this.intervalo_lb.Location = new System.Drawing.Point(14, 30);
            this.intervalo_lb.Name = "intervalo_lb";
            this.intervalo_lb.Size = new System.Drawing.Size(68, 13);
            this.intervalo_lb.TabIndex = 7;
            this.intervalo_lb.Text = "Intervalo 1";
            this.intervalo_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Estas en período de descanso (5 minutos):";
            // 
            // minutosNull
            // 
            this.minutosNull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minutosNull.Location = new System.Drawing.Point(226, 7);
            this.minutosNull.Name = "minutosNull";
            this.minutosNull.ReadOnly = true;
            this.minutosNull.Size = new System.Drawing.Size(24, 13);
            this.minutosNull.TabIndex = 16;
            this.minutosNull.TabStop = false;
            this.minutosNull.Text = "00";
            this.minutosNull.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segundosNull
            // 
            this.segundosNull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.segundosNull.Location = new System.Drawing.Point(252, 7);
            this.segundosNull.Name = "segundosNull";
            this.segundosNull.ReadOnly = true;
            this.segundosNull.Size = new System.Drawing.Size(24, 13);
            this.segundosNull.TabIndex = 17;
            this.segundosNull.TabStop = false;
            this.segundosNull.Text = "00";
            this.segundosNull.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(244, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(14, 13);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = ":";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.segundosNull);
            this.panel1.Controls.Add(this.minutosNull);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 25);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(358, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Reiniciar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TomateClock - notificación";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.técnicaPomodoroToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // técnicaPomodoroToolStripMenuItem
            // 
            this.técnicaPomodoroToolStripMenuItem.Name = "técnicaPomodoroToolStripMenuItem";
            this.técnicaPomodoroToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.técnicaPomodoroToolStripMenuItem.Text = "¿Técnica Pomodoro?";
            this.técnicaPomodoroToolStripMenuItem.Click += new System.EventHandler(this.técnicaPomodoroToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acercaToolStripMenuItem.Text = "Acerca";
            this.acercaToolStripMenuItem.Click += new System.EventHandler(this.acercaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(436, 160);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.intervalo_lb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox minutos;
        private System.Windows.Forms.TextBox segundos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label intervalo_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minutosNull;
        private System.Windows.Forms.TextBox segundosNull;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicaPomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
    }
}

