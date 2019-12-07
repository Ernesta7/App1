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
    
    public class ToDoViewHolder : Java.Lang.Object
    {
        public TextView Title { get; set; }
        public TextView Description { get; set; }
    }
}