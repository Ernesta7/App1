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
    [Activity(Label = "Todo")]
    public class TodoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TodoView);

            ListView TodoList = FindViewById<ListView>(Resource.Id.listViewTodo);
            g.tda = new ToDoItemAdapter(ToDoItemList.cals);
            TodoList.Adapter = g.tda;

            TodoList.ItemClick += TodoList_ItemClick; ;

            Button buttonAddTodo = FindViewById<Button>(Resource.Id.AddbtnTodo);
            buttonAddTodo.Click += AddbtnTodo_Click;

            Button buttonNext = FindViewById<Button>(Resource.Id.nextTodo);
            buttonNext.Click += nextTodo_Click;

            Button buttonPr = FindViewById<Button>(Resource.Id.previousTodo);
            buttonPr.Click += prTodo_Click;
        }

        private void TodoList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TodoList_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            throw new NotImplementedException();
        }



        private void AddbtnTodo_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(ToDoCard));
            StartActivity(intent);


        }

        private void nextTodo_Click(object sender, EventArgs e)
        {

            StartActivity(g.Life);

            //Intent i = new Intent(Application.Context, typeof(LifeNoteActivity));
            //StartActivity(i);

            //this.Title = "Calendar";
            //ListView myList = FindViewById<ListView>(Resource.Id.listView1);

            //g.cla = new CalendarItemsAdapter(CalendarItemsList.cals);
            //myList.Adapter = g.cla;
        }

        private void prTodo_Click(object sender, EventArgs e)
        {
            //Intent i = new Intent(Application.Context, typeof(MainActivity));
            //StartActivity(i);
            StartActivity(g.Calendar);
        }



        //protected override void EventClicked(ListView listView1, View v, int position, long id)
        // {
        // var t = ToDoItem[position];
        //  Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
    }
}
    
