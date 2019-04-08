using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
           // Process.Start(@"cmd.exe", @"/k Testar_ping_maquinas.bat");
            FormPing f = new FormPing();
            f.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k Desligar_maquinas_labs.bat");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k auto_logon.bat");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k Copiar_arquivos.bat");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            {


                ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/AngeloCastro9");

                Process.Start(sInfo);

            }
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //Tentar o ./ ou algo parecido para encurtar o caminho
            Process.Start(@"cmd.exe", @"/k AutoCad.bat");
           
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k CS6.bat");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k Adobe_CC.bat");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k Revit.bat");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k Project.bat");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k PgAdmin4.bat");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Process.Start(@"cmd.exe", @"/k Uninstall_Tool_Autodesk.bat"); 
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            {


                ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.google.com/forms/d/1PC91qP0T7EH2GN7z-2wheX9kWjnI_jr3ur4enH1wi78/");

                Process.Start(sInfo);


            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.google.com/document/d/1Y6KoV7ZP4i-5tv58oI6YZs6uwTn3DSAYQDljRNtx20c/edit?usp=sharing");

            Process.Start(sInfo);

        }
        
    }
}
