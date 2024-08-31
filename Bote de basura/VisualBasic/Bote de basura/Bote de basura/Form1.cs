using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Bote_de_basura
{
    public partial class Form1 : Form
    {
        string Recibidos;
        public Form1()
        {
            InitializeComponent();
                try
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                    }
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(Recepcion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el puerto: " + ex.Message);
                }
        }


        private void Recepcion(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadExisting().Trim(); // Leer y limpiar los datos recibidos

            // Verificar si se recibió un solo carácter
            if (data.Length > 0)
            {
                char receivedChar = data[0]; // Solo toma el primer carácter recibido
                // Actualizar la interfaz de usuario en el hilo principal
                this.Invoke(new Action(() => Actualizar(receivedChar)));
            }
        }

        private void Actualizar(char receivedChar)
        {
            switch (receivedChar)
            {
                //100
                case '0':
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    break;
                case '1':
                    button1.BackColor = Color.White;
                    break;
                // 75
                case '2':
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    break;
                case '3':
                    button2.BackColor = Color.White;
                    break;
                // 50
                case '4':
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    break;
                case '5':
                    button3.BackColor = Color.White;
                    break;
                // 25
                case '6':
                    button4.BackColor = Color.Black;
                    break;
                case '7':
                    button4.BackColor = Color.White;
                    break;


                default:
                    // Manejar caracteres no esperados si es necesario
                    break;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
