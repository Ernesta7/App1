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
using static Android.App.DatePickerDialog;

namespace App1
{
    [Activity(Label = "CalendarCard")]
    public class CalendarCard : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CalendarCard);


            Spinner spinner = FindViewById<Spinner>(Resource.Id.startDateSpinner);
            //spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            Button button = FindViewById<Button>(Resource.Id.AddEventbtn);
            button.Click += AddEventbtn_Click;

            Button cancelbtn = FindViewById<Button>(Resource.Id.CancelEventbtn);
            cancelbtn.Click += CancelEventbtn_Click;

            CheckBox shareBtn = FindViewById<CheckBox>(Resource.Id.shareCheckBox);
            //shareBtn.Checked = Share_Check;

        }

        //private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        //{
        //    Spinner spinner = (Spinner)sender;


        //}

            private void Share_Check(object sender, EventArgs e)
        {

        }

        private void AddEventbtn_Click(object sender, EventArgs e)
        {
            EditText et = FindViewById<EditText>(Resource.Id.titleEditText);
            EditText sp = FindViewById<EditText>(Resource.Id.desciptionEditText);
            Spinner s = FindViewById<Spinner>(Resource.Id.startDateSpinner);
            CheckBox ch = FindViewById<CheckBox>(Resource.Id.shareCheckBox);

            CalendarItem calendarItem = new CalendarItem();
            
            calendarItem.Title = et.Text;
            calendarItem.Description = sp.Text;
            calendarItem.Spinner = s.SelectedItemPosition;
            calendarItem.IsShared = ch.Checked;

            CalendarItemsList.AddCalcs(calendarItem);

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