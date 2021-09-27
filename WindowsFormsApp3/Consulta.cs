using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Socket conexion;
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("192.168.0.5"), 8080);

            listen.Connect(connect);

            byte[] recibir_info = new byte[2048];
            string[] linea = {NombreC.Text, ApellidoC.Text, NombreC.Text, DescripcionC.Text };

            //recibir_info = Encoding.Default.GetBytes(linea);

            listen.Send(recibir_info);


        }
    }
}
