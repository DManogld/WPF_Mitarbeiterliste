using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterliste
{
    public class Mitarbeiter :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropretyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }


        public string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                SetProperty(ref _Name, value);
            }
        }

        public string _Chef;
        public string Chef
        {
            get { return _Chef; }
            set
            {
                SetProperty(ref _Chef, value);
            }
        }

        public string _Geschlecht;
        public string Geschlecht
        {
            get { return _Geschlecht; }
            set
            {
                SetProperty(ref _Geschlecht, value);
            }
        }

        private string _Vorname;
        public string Vorname
        {
            get { return _Vorname; }
            set
            {
                SetProperty(ref _Vorname, value);
            }
        }

        public virtual void SetProperty<T>(ref T storage, T value, [CallerMemberName] string property = null)
        {
            storage = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
