using System;
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
            string[] lineas = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };

            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Socket conexion;
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("192.168.0.5"), 8080);

            listen.Connect(connect);
            //listen.Listen(10);

           


           //using (StreamWriter outputFile = new StreamWriter("C:\\Users\\ULYSSESS\\Desktop\\A.txt")){
                foreach(string linea in lineas)
                {
                    //outputFile.WriteLine(linea);
                    byte[] enviar_info = new byte[2048];
                    string data = "";

                    enviar_info = Encoding.Default.GetBytes(linea);

                    listen.Send(enviar_info);
                }
           // }

           

        }
    }
}
