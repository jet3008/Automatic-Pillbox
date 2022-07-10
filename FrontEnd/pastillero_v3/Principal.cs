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

namespace pastillero_v3
{

    public partial class Principal : Form
    {
        string dato;
        private int cont;
        private string rawdata;
        public Principal()
        {
            InitializeComponent();
            label1.Text = BaseDatos.nombreCompleto;
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            btn_desconectar.Enabled = false;
            btn_send.Enabled = false;
            label2.Text = "Sin Conectar";
            if (BaseDatos.tipoUsuario == "Administrador")
            {
                lbl_tipo.Text = "Administrador";
                btn_config.Enabled = true;

            }
            else if (BaseDatos.tipoUsuario == "Profesor")
            {
                lbl_tipo.Text = "Usuario";
                btn_config.Enabled = false;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        { 
            serialPort1.WriteLine(time1.Value+"A"+ time2.Value + "B"+ time3.Value+"C"+ time4.Value+"D"+can1.Value+"E"+can2.Value+"F"+can3.Value+"G"+can4.Value);
            
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                label2.Text = "Sin Conectar";
            }
            else
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                btn_desconectar.Enabled = true;
                btn_send.Enabled = true;
                btn_conectar.Enabled = false;
                label2.Text = comboBox1.Text;
                timer1.Enabled = true;
            }
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btn_conectar.Enabled = true;
            btn_send.Enabled = false;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (serialPort1.ReadLine() == "")
             {

                 lab_act1.Text = "??";
             }
             else
             {
                 cont++;
                 label5.Text = cont.ToString();
                 rawdata = serialPort1.ReadLine();
                 lab_act1.Text = serialPort1.ReadLine();
             }*/
        }
    }
}
