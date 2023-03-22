using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs230320.MVVM.Model
{
    public class PKW
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public DateTime Baujahr { get; set; }


        public static ObservableCollection<PKW> PkwListe { get; set; } = new ObservableCollection<PKW>()
        {
            new PKW(){Hersteller="BMW", MaxGeschwindigkeit=320, Baujahr=new DateTime(2005, 1, 1)}
        };
    }
}
