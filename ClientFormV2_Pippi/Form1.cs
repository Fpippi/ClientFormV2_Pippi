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

namespace ClientFormV2_Pippi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_serverIp.Enabled = true;
            txt_serverPort.Enabled = true;
            button1.Enabled = true;
            button2.Visible = false;
            txt_messaggio.Visible = false;
            Errore.Visible = false;
            listBox1.Visible = false;
            Size = new Size(800, 156);
        }
        Socket client;
        IPAddress ipAddr = null;
        string strIPAddress = "";
        string strPort = "";
        int nPort = 0;
        string recvString = "";
        byte[] sendBuff = new byte[128];
        byte[] recvBuff = new byte[128];
        int recvBytes = 0;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strIPAddress = txt_serverIp.Text;
            strPort = txt_serverPort.Text;
            if (!IPAddress.TryParse(strIPAddress.Trim(), out ipAddr))
            {
                Errore.Text = "IP non valido .";
                return;
            }
            if (!int.TryParse(strPort, out nPort))
            {
                Errore.Text = "Porta non valida .";
                return;
            }
            if (nPort <= 0 || nPort >= 65535)
            {
                Errore.Text = "Porta non valida .";
                return;
            }
            Errore.Text = "Endpoint: " + ipAddr.ToString() + " " + nPort;

            // Connessione al server
            try
            {

                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ipAddr, nPort);
                Errore.Text = "Connection Succesfull;";

                txt_serverIp.Enabled = false;
                txt_serverPort.Enabled = false;
                button1.Enabled = false;

                Size = new Size(800, 399);
                button2.Visible = true;
                txt_messaggio.Visible = true;
                Errore.Visible = true;
                listBox1.Visible = true;
                listBox1.Items.Add("Chatta con il server. ");

            }
            catch (Exception ex)
            {
                Errore.Text = ex.Message;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                sendBuff = Encoding.ASCII.GetBytes(txt_messaggio.Text);
                if (txt_messaggio.Text.ToUpper().Trim() != "QUIT")
                {

                    client.Send(sendBuff);
                    recvBytes = client.Receive(recvBuff);
                    recvString = Encoding.ASCII.GetString(recvBuff);
                    listBox1.Items.Add("Client: " + txt_messaggio.Text);
                    listBox1.Items.Add("Server: " + recvString);

                    Array.Clear(recvBuff, 0, recvBuff.Length);
                    Array.Clear(sendBuff, 0, sendBuff.Length);
                    recvString = "";
                    recvBytes = 0;
                    txt_messaggio.Text = "";
                }

                if (txt_messaggio.Text.ToUpper().Trim() == "QUIT")
                {
                    button2.Visible = false;
                    txt_messaggio.Visible = false;
                    Errore.Visible = false;
                    listBox1.Visible = false;
                    client.Send(sendBuff);
                    client.Close();
                    client.Dispose();
                    Errore.Text = "Ti sei disconneso :)";
                    Size = new Size(800, 156);
                    listBox1.Items.Clear();

                    txt_serverIp.Enabled = true;
                    txt_serverPort.Enabled = true;
                    button1.Enabled = true;

                }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_disconetti_Click(object sender, EventArgs e)
        {
            if (client != null)
            {

                button2.Visible = false;
                txt_messaggio.Visible = false;
                Errore.Visible = false;
                listBox1.Visible = false;
                client.Send(sendBuff);
                client.Close();
                client.Dispose();
                Errore.Text = "Ti sei disconneso :)";
                Size = new Size(800, 156);

                txt_serverIp.Enabled = true;
                txt_serverPort.Enabled = true;
                button1.Enabled = true;

                txt_serverIp.Enabled = true;
                txt_serverPort.Enabled = true;
                button1.Enabled = true;
                button2.Visible = false;
                txt_messaggio.Visible = false;
                Errore.Visible = false;
                listBox1.Visible = false;
            }
        }
        
    }
    
}
