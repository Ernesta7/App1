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
    public sealed class g
    {
        public static int idtoshow = -1;

        public static CalendarItemsAdapter cla;
        public static ToDoItemAdapter tda;
        public static LifeNoteItemsAdapter lfa;

        public static Intent Calendar = new Intent(Application.Context, typeof(CalendarActivity));
        public static Intent Todo = new Intent(Application.Context, typeof(TodoActivity));
        public static Intent Life= new Intent(Application.Context, typeof(LifeNoteActivity));
        

    }


}