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
using Android.Animation;

namespace XAnimations
{

    public class SlideInDownAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            int distance = view.Top + view.Height;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "translationY", -distance, 0)
            );
        }
    }

    public class SlideInLeftAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            ViewGroup parent = (ViewGroup)view.Parent;
            int distance = parent.Width - view.Left;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "translationX", -distance, 0)
            );
        }
    }

    public class SlideInRightAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            ViewGroup parent = (ViewGroup)view.Parent;
            int distance = parent.Width - view.Left;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "translationX", distance, 0)
            );
        }
    }

    public class SlideInUpAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            ViewGroup parent = (ViewGroup)view.Parent;
            int distance = parent.Height - view.Top;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "translationY", distance, 0)
            );
        }
    }


    public class SlideOutDownAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            ViewGroup parent = (ViewGroup)view.Parent;
            int distance = parent.Height - view.Top;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "translationY", 0, distance)
            );
        }
    }

    public class SlideOutLeftAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "translationX", 0, -view.Right)
            );
        }
    }

    public class SlideOutRightAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            ViewGroup parent = (ViewGroup)view.Parent;
            int distance = parent.Width - view.Left;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "translationX", 0, distance)
            );
        }
    }

    public class SlideOutUpAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "translationY", 0, -view.Bottom)
            );
        }
    }

}