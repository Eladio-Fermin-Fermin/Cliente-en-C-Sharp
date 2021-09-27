﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lineas = { Nombre.Text, Apellido.Text, Telefono.Text, Fecha.Text, Descripcion.Text };

            //Socket
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("192.168.0.5"), 8080);

            listen.Connect(connect);
      
                foreach(string linea in lineas)
                {
                    //outputFile.WriteLine(linea);
                    byte[] enviar_info = new byte[2048];
                    enviar_info = Encoding.Default.GetBytes(linea);
                    listen.Send(enviar_info);
                }
        }

        /*private void Consult1_Click(object sender, EventArgs e)
        {
            Consulta c1 = new Consulta();
            c1.Show();
        }*/
    }
}
