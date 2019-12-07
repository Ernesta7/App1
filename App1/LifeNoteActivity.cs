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
    [Activity(Label = "Life-Note")]
    public class LifeNoteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LifenoteView);

            ListView myList = FindViewById<ListView>(Resource.Id.listView1);
            g.lfa = new LifeNoteItemsAdapter(LifeNoteItemsList.cals);
            myList.Adapter = g.lfa;

            myList.ItemClick += MyList_ItemClick; ;

            Button buttonAdd = FindViewById<Button>(Resource.Id.Addbtn);
            buttonAdd.Click += Addbtn_Click;

            Button buttonNext = FindViewById<Button>(Resource.Id.nextLife);
            buttonNext.Click += next_Click;

            Button buttonPrior = FindViewById<Button>(Resource.Id.previousLife);
            buttonPrior.Click += prior_Click;
        }

        private void prior_Click(object sender, EventArgs e)
        {
            g.Life = this.Intent;
            StartActivity(g.Todo);
        }

        private void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MyList_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            throw new NotImplementedException();
        }



        private void Addbtn_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(LifeNoteCard));
            StartActivity(intent);


        }

        private void next_Click(object sender, EventArgs e)
        {
            g.Life = this.Intent;
            StartActivity(g.Calendar);

        }
    }

}
