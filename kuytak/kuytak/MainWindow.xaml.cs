using System;
using System.Collections.Generic;
using System.IO;
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

namespace kuytak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Kutyafajtak> Kutyafajta_lista = new List<Kutyafajtak>();
            
            using(StreamReader sr = new StreamReader("kutyafajtak.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Kutyafajtak s = new Kutyafajtak(sor);
                    Kutyafajta_lista.Add(s);
                }
            }

            List<Kutyak> kutyak_lista = new List<Kutyak>();

            using (StreamReader sr = new StreamReader("kutya.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Kutyak s = new Kutyak(sor);
                    Kutyafajta_lista.Add(s);
                }
            }

            List<KutyaNevek> kutya_nevek_lista = new List<KutyaNevek>();

            using (StreamReader sr = new StreamReader("KutyaNevek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    KutyaNevek s = new KutyaNevek(sor);
                    Kutyafajta_lista.Add(s);
                }
            }


        }
    }
}