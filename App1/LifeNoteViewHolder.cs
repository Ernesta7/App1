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
    [Activity(Label = "LifeNoteViewHolder")]
    public class LifeNoteViewHolder : Activity
    {
        public TextView Title { get; set; }
        public TextView Description { get; set; }
    }
}