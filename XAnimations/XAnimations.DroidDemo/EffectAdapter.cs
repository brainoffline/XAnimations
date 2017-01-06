using System;

using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace XAnimations.Demo
{
    public class EffectAdapter : BaseAdapter
    {
        Context _context;

        public EffectAdapter(Context context)
        {
            _context = context;
        }

        public override int Count => AnimationTechniques.Animators.Length;

        public override Java.Lang.Object GetItem(int position)
        {
            return (Java.Lang.Object)Activator.CreateInstance(AnimationTechniques.Animators[position]);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View v = LayoutInflater.From(_context).Inflate(Android.Resource.Layout.SimpleListItem1, null, false);
            TextView t = (TextView)v.FindViewById(Android.Resource.Id.Text1);
            var o = GetItem(position);
            int start = o.Class.Name.LastIndexOf(".") + 1;
            var name = o.Class.Name.Substring(start);
            t.Text = name;
            v.Tag = AnimationTechniques.Animators[position].FullName;
            return v;
        }
    }

}