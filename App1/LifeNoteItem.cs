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
    [Activity(Label = "LifeNoteItem")]
    public class LifeNoteItem : Activity
    {
        public new string Title { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return Title;

        }
    }


}