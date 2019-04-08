using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };

    public partial class FormPing : Form
    {
       // int contador = 0;
        int computadorAtual = 1;
       // int numeroDeComputadores = 0;

        public FormPing()
        {
            InitializeComponent();
        }

        private void Ping_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int numeroDeComputadoresDigitadosPeloUsuario = Int32.Parse(cmbPc.Text);
                while (numeroDeComputadoresDigitadosPeloUsuario >= computadorAtual)
                {
                    Ping ping = new Ping();

                    PingReply reply = ping.Send("10.54." + numeroDoLab.Text + "." + computadorAtual as String);
                    progressBar1.MarqueeAnimationSpeed = 20;
                    progressBar1.Style = ProgressBarStyle.Marquee;

                    if (reply.Status == IPStatus.DestinationHostUnreachable || reply.Status == IPStatus.DestinationNetworkUnreachable || reply.Status == IPStatus.DestinationPortUnreachable)
                    {
                        MessageBox.Show("Erro no computador: " + computadorAtual + " Verifique-o! (Ok para continuar o teste.)", "Confirm", MessageBoxButtons.OK);
                        richTextBox1.Text = "Erro na maquina: " + computadorAtual;
                        // richTextBox1(LogMsgType.Normal, "Início da geração do inventário");
                    }

                    if (reply.Status == IPStatus.Success)
                    {
                        richTextBox1.Text = "Ping testado com sucesso na maquina: " + computadorAtual;
                    }
                    computadorAtual++;
                }
        }

        // Testa se um URL esta ativa. Ex: bool res = IsConnectedToHost(new uri("www.teste.com.br/etc"))
        public static bool IsConectedToHost(Uri uri)
        {
            try
            {
                Dns.GetHostEntry(uri.Host);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        // Testa se existe conexão com a internet;
        public static bool IsConectedToInternet()
        {
            try
            {
                Dns.GetHostEntry("www.uni7.edu.br");
                return true;
            }
            catch (SocketException)
            {
                return false;
            }

        }
    }
}
