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
        public ObservableCollection<Mitarbeiter> mitarbeiters;

        public MainWindow()
        {
            InitializeComponent();
            mitarbeiters = new ObservableCollection<Mitarbeiter>();

            DataContext = mitarbeiters; // Databinding in WPF

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
            //if(CheckBoxChef.IsChecked == true && RatioButtonM.IsChecked == true)
            mitarbeiters.Add(new Mitarbeiter() { Name = TextBoxName.Text, Vorname = TextBoxVorname.Text, Chef = CheckBoxChef.Content.ToString(), Geschlecht = RatioButtonM.Content.ToString() });
            //else if(CheckBoxAngestelter.IsChecked == true && RatioButtonM.IsChecked == true)
            //    mitarbeiters.Add(new Mitarbeiter() { Name = TextBoxName.Text, Vorname = TextBoxVorname.Text, Chef = CheckBoxAngestelter.Content.ToString(), Geschlecht = RatioButtonM.Content.ToString() });
            //else if (CheckBoxChef.IsChecked == true && RatioButtonW.IsChecked == true)
            //    mitarbeiters.Add(new Mitarbeiter() { Name = TextBoxName.Text, Vorname = TextBoxVorname.Text, Chef = CheckBoxChef.Content.ToString(), Geschlecht = RatioButtonW.Content.ToString() });
            //else if (CheckBoxAngestelter.IsChecked == true && RatioButtonW.IsChecked == true)
            //    mitarbeiters.Add(new Mitarbeiter() { Name = TextBoxName.Text, Vorname = TextBoxVorname.Text, Chef = CheckBoxAngestelter.Content.ToString(), Geschlecht = RatioButtonW.Content.ToString() });
            TextBoxName.Text = String.Empty;
            TextBoxVorname.Text = String.Empty;
            //nm.Show();
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
