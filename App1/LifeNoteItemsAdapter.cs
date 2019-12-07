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
    public class LifeNoteItemsAdapter : BaseAdapter<LifeNoteItem>
    {
        List<LifeNoteItem> users;

        public LifeNoteItemsAdapter(List<LifeNoteItem> users)
        {
            this.users = users;
        }

        public override LifeNoteItem this[int position]
        {
            get
            {
                return users[position];
            }
        }

        public override int Count
        {
            get
            {
                return users.Count;
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
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.LifeNoteHolderItem, parent, false);

                var name = view.FindViewById<TextView>(Resource.Id.titletxt);
                var department = view.FindViewById<TextView>(Resource.Id.noteTxt);
                //var id = view.FindViewById<TextView>(Resource.Id.idView);

                view.Tag = new LifeNoteViewHolder() { Title = name, Description = department };
            }

            var holder = (LifeNoteViewHolder)view.Tag;

            //holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, users[position].ImageUrl));
            holder.Title.Text = users[position].Title;
            holder.Description.Text = users[position].Description;



            return view;

        }



    }
}