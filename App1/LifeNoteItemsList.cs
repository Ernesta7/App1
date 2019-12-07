using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    public static class LifeNoteItemsList
    {
        public static List<LifeNoteItem> cals { get; private set; }

        static LifeNoteItemsList()
        {
            cals = new List<LifeNoteItem>();

            LifeNoteItem l2 = new LifeNoteItem();
            l2.Title = "Vizitas pas gydytoja";
            l2.Description = "Vizitas pas seimos gydytoja, reikia pasidaryti kraujo tyrima.";
           
            cals.Add(l2);

            LifeNoteItem l3 = new LifeNoteItem();
            l3.Title = "Agnes gimtadienis";
            l3.Description = "koleges Agnes gimtadienis, reikia suruosti paminejima darbe.";
            cals.Add(l3);

            LifeNoteItem l4 = new LifeNoteItem();
            l4.Title = "Susirinkimas del apyvartu";
            l4.Description = "Vyks susirinkimas, kuriame bus aptariama kaip galima butu pakelti apyvartas.";
            cals.Add(l4);

            LifeNoteItem l5 = new LifeNoteItem();
            l5.Title = "Mociutes vardadienis";
            l5.Description = "Butinai paskambinti mociutei ir pasveikinti su vardadieniu, o tai labai supyks";
            cals.Add(l5);

            LifeNoteItem l6 = new LifeNoteItem();
            l6.Title = "Praktinio darbo atsiskaitymas";
            l6.Description = "Jau reikia buti paruosus praktikos ataskaita";
            cals.Add(l6);
        }

        public static void AddCalcs(LifeNoteItem ls)
        {
            cals.Add(ls);
        }
    }
}