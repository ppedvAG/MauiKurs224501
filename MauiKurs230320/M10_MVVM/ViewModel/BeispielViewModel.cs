using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs230320.MVVM.ViewModel
{
    public class BeispielViewModel : INotifyPropertyChanged
    {
        private string neuerHersteller = String.Empty;
        private int neueMaxGeschwindigkeit = 0;
        private DateTime neuesBaujahr = new DateTime();

        public string NeuerHersteller { get => neuerHersteller; set { neuerHersteller = value; HinzufügenCmd.ChangeCanExecute(); } }
        public int NeueMaxGeschwindigkeit { get => neueMaxGeschwindigkeit; set { neueMaxGeschwindigkeit = value; HinzufügenCmd.ChangeCanExecute(); } }
        public DateTime NeuesBaujahr { get => neuesBaujahr; set {neuesBaujahr = value; HinzufügenCmd.ChangeCanExecute(); }
}
        public ObservableCollection<Model.PKW> PkwListe
        {
            get { return Model.PKW.PkwListe; }
        }

        public Command HinzufügenCmd { get; set; }
        public Command LöschenCmd { get; set; }
        public Command UpdateSelecedPKW { get; set; }


        public BeispielViewModel()
        {
            HinzufügenCmd = new Command
                (
                    () =>
                    {
                        Model.PKW neuerPKW = new Model.PKW() { Hersteller = NeuerHersteller, MaxGeschwindigkeit = NeueMaxGeschwindigkeit, Baujahr = NeuesBaujahr };

                        PkwListe.Add(neuerPKW);

                        NeuerHersteller = String.Empty;
                        NeueMaxGeschwindigkeit = 0;
                        NeuesBaujahr = new DateTime();

                        InformView(nameof(NeuerHersteller));
                        InformView(nameof(NeueMaxGeschwindigkeit));
                        InformView(nameof(NeuesBaujahr));
                    },

                    () =>
                    {
                        return !NeuerHersteller.Equals(String.Empty) && NeueMaxGeschwindigkeit > 0 && NeuesBaujahr.Year > 1950;
                    }
                );
            LöschenCmd = new Command
                (
                    p =>
                    {
                        PkwListe.Remove((p as ListView).SelectedItem as Model.PKW);
                        (p as ListView).ClearValue(ListView.SelectedItemProperty);
                        LöschenCmd.ChangeCanExecute();
                    },
                    p =>
                    {
                        return (p as ListView).SelectedItem is Model.PKW;
                    }
                );

            UpdateSelecedPKW = new Command
                (
                    () => LöschenCmd.ChangeCanExecute()
                );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void InformView(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
