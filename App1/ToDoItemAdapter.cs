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
    
    public class ToDoItemAdapter : BaseAdapter<ToDoItem>
    {
        List<ToDoItem> tditems;
        


        public ToDoItemAdapter(List<ToDoItem> users)
        {
            this.tditems = users;
        }

        public override ToDoItem this[int position]
        {
            get
            {
                return tditems[position];
            }
        }

        public override int Count
        {
            get
            {
                return tditems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.TodoHolderItem, parent, false);

                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var department = view.FindViewById<TextView>(Resource.Id.departmentTextView);
                
                view.Tag = new ToDoViewHolder() { Title = name, Description = department };
            }

            var holder = (ToDoViewHolder)view.Tag;

            //holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, users[position].ImageUrl));
            holder.Title.Text = tditems[position].Title;
            holder.Description.Text = tditems[position].Description;

            if (tditems[position].IsShared)
            {
                view.SetBackgroundColor(Android.Graphics.Color.Purple);
            }
            else
            {
                view.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }

            return view;

        }



    }
}
    