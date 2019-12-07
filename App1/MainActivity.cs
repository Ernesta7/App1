using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using System.Collections;
using Android.Content.Res;


namespace App1
{
    [Activity(Label = "Login", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

           Button buttonAdd = FindViewById<Button>(Resource.Id.AddbtnCal);
           buttonAdd.Click += Addbtn_Click;

            
        }

        
        
       

        private void Addbtn_Click(object sender, EventArgs e)
        {

            StartActivity(g.Calendar);

        }

        
    }

}


