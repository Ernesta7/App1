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
    [Activity(Label = "Calendar")]
    public class CalendarActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.CalendarView);

          

            ListView myList = FindViewById<ListView>(Resource.Id.listView1);
            g.cla = new CalendarItemsAdapter(CalendarItemsList.cals);
            myList.Adapter = g.cla;

            myList.ItemClick += MyList_ItemClick; ;

            Button buttonAdd = FindViewById<Button>(Resource.Id.Addbtn);
            buttonAdd.Click += Addbtn_Click;

            Button buttonNext = FindViewById<Button>(Resource.Id.next);
            buttonNext.Click += next_Click;

            Button buttonPrior = FindViewById<Button>(Resource.Id.previous);
            buttonPrior.Click += prior_Click;
        }

        private void prior_Click(object sender, EventArgs e)
        {
            g.Calendar = this.Intent;
            StartActivity(g.Life);
        }

        private void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            g.idtoshow = (CalendarItemsList.cals[e.Position]).ID;

            //throw new NotImplementedException();
        }

        private void MyList_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            throw new NotImplementedException();
        }



        private void Addbtn_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(CalendarCard));
            StartActivity(intent);


        }

        private void next_Click(object sender, EventArgs e)
        {

            g.Calendar = this.Intent;

            StartActivity(g.Todo);

            
        }
    }

}


