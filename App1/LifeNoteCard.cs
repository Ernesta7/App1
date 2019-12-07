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
    [Activity(Label = "LifeNoteCard")]
    public class LifeNoteCard : Activity
    {
       
            protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LifeNoteCard);


            //Spinner spinner = FindViewById<Spinner>(Resource.Id.startDateSpinner);
            //spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            //var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);
            //adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            //spinner.Adapter = adapter;

            Button button = FindViewById<Button>(Resource.Id.Addbtn);
            button.Click += AddEventbtn_Click;

            Button cancelbtn = FindViewById<Button>(Resource.Id.Cancelbtn);
            cancelbtn.Click += CancelEventbtn_Click;

        }

        //private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        //{
        //    Spinner spinner = (Spinner)sender;


        //}

        private void AddEventbtn_Click(object sender, EventArgs e)
        {
            EditText et = FindViewById<EditText>(Resource.Id.titleEditText);
            EditText sp = FindViewById<EditText>(Resource.Id.noteTxt);



        


            LifeNoteItem lifeItem = new LifeNoteItem();

            lifeItem.Title = et.Text;
            lifeItem.Description = sp.Text;
            //calendarItem.Description = "";

            //LifeNoteItemsList.AddCalcs(lifeItem);

            g.cla.NotifyDataSetChanged();

            Finish();


            //Intent intent = new Intent(this, typeof(MainActivity));
            //StartActivity(intent);
        }

        private void CancelEventbtn_Click(object sender, EventArgs a)
        {
            this.Finish();
        }


    }



}
     