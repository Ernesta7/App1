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
    [Activity(Label = "ToDoCard")]
    public class ToDoCard : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ToDoCard);


            Button button = FindViewById<Button>(Resource.Id.Addbtn);
            button.Click += Addbtn_Click;

            Button cancelbtn = FindViewById<Button>(Resource.Id.Cancelbtn);
            cancelbtn.Click += Cancelbtn_Click;

            CheckBox shareBtn = FindViewById<CheckBox>(Resource.Id.shareCheckBox);
        }


        private void Share_Check(object sender, EventArgs e)
        {

        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            EditText et = FindViewById<EditText>(Resource.Id.titletxt);
            EditText sp = FindViewById<EditText>(Resource.Id.noteTxt);
            CheckBox ch = FindViewById<CheckBox>(Resource.Id.shareCheckBox);

            ToDoItem todoItem = new ToDoItem();

            todoItem.Title = et.Text;



            todoItem.Description = sp.Text;
            todoItem.IsShared = ch.Checked;
            //calendarItem.Description = "";

            ToDoItemList.AddCalcs(todoItem);

            g.tda.NotifyDataSetChanged();

            Finish();
        }

        private void Cancelbtn_Click(object sender, EventArgs a)
        {
            this.Finish();
        }
    }
    }