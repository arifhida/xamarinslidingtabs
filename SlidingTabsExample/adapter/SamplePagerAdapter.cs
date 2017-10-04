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
using Android.Support.V4.View;
using Java.Lang;

namespace SlidingTabsExample.adapter
{
    class SamplePagerAdapter : PagerAdapter
    {
        List<string> items = new List<string>();

        public SamplePagerAdapter() :base()
        {
            items.Add("Xamarin");
            items.Add("Android");
            items.Add("Tutorial");
            items.Add("Part");
            items.Add("12");
            items.Add("Hooray");
        }
        public override int Count
        {
            get { return items.Count(); }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view == @object;
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            View view = LayoutInflater.From(container.Context).Inflate(Resource.Layout.pager_item, container, false);
            container.AddView(view);

            TextView txtTitle = view.FindViewById<TextView>(Resource.Id.item_title);
            int pos = position + 1;
            txtTitle.Text = pos.ToString();

            return view;
        }
        public string GetHeaderTitle(int position)
        {
            return items[position];
        }
        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object @object)
        {
            container.RemoveView((View)@object);
        }
    }
}