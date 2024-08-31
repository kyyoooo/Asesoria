using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banda_transportadora
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        private bool btnEnclavadoPE = false;
        private bool btnEnclavadoP = false;
        private bool btnEnclavadoDir = false;

        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM5";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Arduino.IsOpen)
            {
                Arduino.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPE_Click(object sender, EventArgs e)
        {
            btnEnclavadoPE = !btnEnclavadoPE;
            if (btnEnclavadoPE)
            {
                btnPE.Text = "Paro de emergencia DESACTIVADO";
                Arduino.Write("1");

            }
            else
            {
                btnPE.Text = "Paro de emergencia ACTIVADO";
                Arduino.Write("2");
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        { 
            btnEnclavadoP = !btnEnclavadoP;
            if (btnEnclavadoP)
            {
                btnP.Text = "Paro DESACTIVADO";
                Arduino.Write("3");

            }
            else
            {
                btnP.Text = "Paro ACTIVADO";
                Arduino.Write("4");
            }
        }

        private void btnArranque_Click(object sender, EventArgs e)
        {
            Arduino.Write("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnEnclavadoDir = !btnEnclavadoDir;
            if (btnEnclavadoDir)
            {
                btnDireccion.Text = "Derecho";
                Arduino.Write("6");

            }
            else
            {
                btnDireccion.Text = "Desvio";
                Arduino.Write("7");
            }
        }
    }
}
