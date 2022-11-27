using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Mitarbeiterliste
{
    /// <summary>
    /// Interaction logic for NewMitarbeiter.xaml
    /// </summary>
    public partial class NewMitarbeiter : Window
    {
        private ObservableCollection<Mitarbeiter> mitarbeiters;
        public NewMitarbeiter()
        {
            //MainWindow mainWindow = new MainWindow();
            mitarbeiters = new ObservableCollection<Mitarbeiter>();
            InitializeComponent();
            //Binding binding = new(); // Init binding
            //mainWindow.MitarbeiterListe.SetBinding(ListBox.ItemsSourceProperty, binding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow? mw = Application.Current.MainWindow as MainWindow;
            
            //MainWindow mainWindow = new MainWindow();
            //NewMitarbeiter newMitarbeiter = new NewMitarbeiter();
            //newMitarbeiter.ShowDialog();
            //mainWindow.MitarbeiterListe.Items.Add(newMitarbeiter);
            mitarbeiters.Add(new Mitarbeiter() { Name = textboxName.Text, Vorname = textboxVorname.Text});
            //textboxName.Text = String.Empty;
            //textboxVorname.Text = String.Empty;
            this.Close();
        }
    }
}
