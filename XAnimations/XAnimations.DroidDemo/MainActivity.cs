using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Views.Animations;

namespace XAnimations.Demo
{
    [Activity(
        Label = "XAnimations Demo", 
        MainLauncher = true, 
        Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView mListView;
        private EffectAdapter mAdapter;
        private View titleView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.main);

            mListView = (ListView)FindViewById(Resource.Id.list_items);
            titleView = FindViewById(Resource.Id.hello_world);
            titleView.Click += (s, e) => { titleView.ResetAnimations(); };

            mAdapter = new EffectAdapter(this);
            mListView.Adapter = mAdapter;
            mListView.ItemClick += async (s, e) =>
            {
                var type = AnimationTechniques.Animators[e.Position];
                await titleView.CreateAnimator(type).Animate();

                titleView.CreateAnimator<BounceInAnimator>().Start();
                await titleView.CreateAnimator<BounceInAnimator>().Animate();
            };
        }
    }
}

