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
    
    public static class ToDoItemList 
    {
        public static List<ToDoItem> cals { get; private set; }

        static ToDoItemList()
        {
            cals = new List<ToDoItem>();

            ToDoItem t1 = new ToDoItem();
            t1.Title = "Dovana Teciui";
            t1.Description = "Reikia nupirkti dovana teciui iki pirmadienio";
            cals.Add(t1);

            ToDoItem t2 = new ToDoItem();
            t2.Title = "Paruosti ataskaita";
            t2.Description = "Paruosti galutine praktikos ataskaita iki antradienio";
            cals.Add(t2);

            ToDoItem t3 = new ToDoItem();
            t3.Title = "Vakariene";
            t3.Description = "Ateis vakarieniauti visi draugai";
            cals.Add(t3);

            ToDoItem t4 = new ToDoItem();
            t4.Title = "Vizitas pas gydytoja";
            t4.Description = "Vizitas pas seimos gydytoja, reikia pasidaryti kraujo tyrima.";
            t4.IsShared = true;
            cals.Add(t4);

            ToDoItem t5 = new ToDoItem();
            t5.Title = "Agnes gimtadienis";
            t5.Description = "koleges Agnes gimtadienis, reikia suruosti paminejima darbe.";
            t5.IsShared = false;
            cals.Add(t5);

            ToDoItem t6 = new ToDoItem();
            t6.Title = "Susirinkimas del apyvartu";
            t6.Description = "Vyks susirinkimas, kuriame bus aptariama kaip galima butu pakelti apyvartas.";
            t6.IsShared = false;
            cals.Add(t6);

            ToDoItem t7 = new ToDoItem();
            t7.Title = "Mociutes vardadienis";
            t7.Description = "Butinai paskambinti mociutei ir pasveikinti su vardadieniu, o tai labai supyks";
            t7.IsShared = true;
            cals.Add(t7);

            ToDoItem t8 = new ToDoItem();
            t8.Title = "Praktinio darbo atsiskaitymas";
            t8.Description = "Jau reikia buti paruosus praktikos ataskaita";
            t8.IsShared = false;
            cals.Add(t8);
        }

        public static void AddCalcs(ToDoItem cs)
        {
            cals.Add(cs);
        }
    }
}