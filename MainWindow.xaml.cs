using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Mitarbeiterliste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //private List<Mitarbeiter> lol = new List<Mitarbeiter>()
        //{
        //    new Mitarbeiter(){Name="hhuh", Vorname="zbzhb"},
        //    new Mitarbeiter(){Name="sd", Vorname="lol"}
        //};

        //public ObservableCollection<Mitarbeiter> Workers
        //{
        //    get
        //    {
        //        return new ObservableCollection<Mitarbeiter>
        //        {
        //            new Mitarbeiter {Vorname = "u", Name = "arbeiter1"},
        //            new Mitarbeiter {Vorname = "kk", Name = "arbeiter2"}
        //        };
        //    }
        //}



        public ObservableCollection<Mitarbeiter> mitarbeiters;

        public MainWindow()
        {
            InitializeComponent();
            //mitarbeiters = new ObservableCollection<Mitarbeiter>();

            DataContext = this; // Databinding in WPF

            Binding binding = new(); // Init binding

            MitarbeiterListe.SetBinding(ListBox.ItemsSourceProperty, binding); //Specify where to bind to
        }

        //public void AddItem(Mitarbeiter mt)
        //{
        //    mitarbeiters.Add(mt);
        //}

        public void button_new_Click(object sender, RoutedEventArgs e)
        {
            //NewMitarbeiter nm = new NewMitarbeiter();
            mitarbeiters.Add(new Mitarbeiter() { Name = TextBoxName.Text, Vorname = TextBoxVorname.Text });
            TextBoxName.Text = String.Empty;
            TextBoxVorname.Text = String.Empty;
            //nm.Show();
        }
    }
}
