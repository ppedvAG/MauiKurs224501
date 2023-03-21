using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs230320.Binding
{
    class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public ObservableCollection<DateTime> WichtigeTage { get; set; } = new ObservableCollection<DateTime>()
        {
            new DateTime(2003, 2, 23),
            new DateTime(2011, 4, 1),
            DateTime.Now
        };

        public event PropertyChangedEventHandler PropertyChanged;

        internal void AktualisiereGUI()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }
}
