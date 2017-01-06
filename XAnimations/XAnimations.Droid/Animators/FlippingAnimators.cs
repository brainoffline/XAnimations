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

    public class FlipInXAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                ObjectAnimator.OfFloat(view, "rotationX", 90, -15, 15, 0),
                ObjectAnimator.OfFloat(view, "alpha", 0.25f, 0.5f, 0.75f, 1)
                );
        }
    }

    public class FlipInYAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                ObjectAnimator.OfFloat(view, "rotationY", 90, -15, 15, 0),
                ObjectAnimator.OfFloat(view, "alpha", 0.25f, 0.5f, 0.75f, 1)
                );
        }
    }

    public class FlipOutXAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                ObjectAnimator.OfFloat(view, "rotationX", 0, 90),
                ObjectAnimator.OfFloat(view, "alpha", 1, 0)
                );
        }
    }

    public class FlipOutYAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                ObjectAnimator.OfFloat(view, "rotationY", 0, 90),
                ObjectAnimator.OfFloat(view, "alpha", 1, 0)
                );
        }
    }

}