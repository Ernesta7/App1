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
    public class CalendarItemsAdapter : BaseAdapter<CalendarItem>
    {
        List<CalendarItem> calitems;

        public CalendarItemsAdapter(List<CalendarItem> users)
        {
            this.calitems = users;
        }

        public override CalendarItem this[int position]
        {
            get
            {
                return calitems[position];
            }
        }

        public override int Count
        {
            get
            {
                return calitems.Count;
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
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CalendarHolderItem, parent, false);

                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var department = view.FindViewById<TextView>(Resource.Id.departmentTextView);
                var start = view.FindViewById<Spinner>(Resource.Id.startDateSpinner);
                //var id = view.FindViewById<TextView>(Resource.Id.idView);

                view.Tag = new CalendarViewHolder() { Title = name, Description = department, Date = start };
            }

            var holder = (CalendarViewHolder)view.Tag;

            //holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, users[position].ImageUrl));
            holder.Title.Text = calitems[position].Title;
            holder.Description.Text = calitems[position].Description;
            //holder.Date. = users[position].Date;
            
            if (calitems[position].IsShared)
            {
                view.SetBackgroundColor(Android.Graphics.Color.Purple);
            } else
            {
                view.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }

            if (calitems[position].Spinner==0)
            {

            }

            return view;

        }

        
        
    }
}