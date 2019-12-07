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
    public static class CalendarItemsList
    {
        public static List<CalendarItem> cals { get; private set; }

        static CalendarItemsList()
        {
            cals = new List<CalendarItem>();

            CalendarItem c1 = new CalendarItem();
            c1.Title = "Susitikimas su bakalaurinio vadovu";
            c1.Description = "Kolegijoje vyks susitikimas su vadovu del bakalauo rasymo nuo 12 val. iki 13 val.";
            c1.IsShared = false;
            cals.Add(c1);

            CalendarItem c2 = new CalendarItem();
            c2.Title = "Vizitas pas gydytoja";
            c2.Description = "Vizitas pas seimos gydytoja, reikia pasidaryti kraujo tyrima.";
            c2.IsShared = true;
            cals.Add(c2);

            CalendarItem c3 = new CalendarItem();
            c3.Title = "Agnes gimtadienis";
            c3.Description = "koleges Agnes gimtadienis, reikia suruosti paminejima darbe.";
            c3.IsShared = false;
            cals.Add(c3);

            CalendarItem c4 = new CalendarItem();
            c4.Title = "Susirinkimas del apyvartu";
            c4.Description = "Vyks susirinkimas, kuriame bus aptariama kaip galima butu pakelti apyvartas.";
            c4.IsShared = false;
            cals.Add(c4);

            CalendarItem c5 = new CalendarItem();
            c5.Title = "Mociutes vardadienis";
            c5.Description = "Butinai paskambinti mociutei ir pasveikinti su vardadieniu, o tai labai supyks";
            c5.IsShared = true;
            cals.Add(c5);

            CalendarItem c6 = new CalendarItem();
            c6.Title = "Praktinio darbo atsiskaitymas";
            c6.Description = "Jau reikia buti paruosus praktikos ataskaita";
            c6.IsShared = false;
            cals.Add(c6);

            CalendarItem c7 = new CalendarItem();
            c7.Title = "Susitikt su Sima";
            c7.Description = "Jau reikia butinai su ja susitikt";
            c7.IsShared = true;
            cals.Add(c7);

            CalendarItem c8 = new CalendarItem();
            c8.Title = "Degustacine vakariene";
            c8.Description = "Vakariene restorane didzioji g. 7";
            c8.IsShared = true;
            cals.Add(c6);

            CalendarItem c9 = new CalendarItem();
            c9.Title = "Uzsisakyti staliuka ";
            c9.Description = "Jubiliejaus proga reikia uzsisakyti staliuka restorane";
            c9.IsShared = true;
            cals.Add(c9);



        }

        public static void AddCalcs(CalendarItem cs)
        {
            cals.Add(cs);
        }
    }
}