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
    public class RotateInAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                ObjectAnimator.OfFloat(view, "rotation", -200, 0),
                ObjectAnimator.OfFloat(view, "alpha", 0, 1)
                );
        }
    }

    public class RotateInDownLeftAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            float x = view.PaddingLeft;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "rotation", -90, 0),
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }

    public class RotateInDownRightAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            float x = view.Width - view.PaddingRight;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "rotation", 90, 0),
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }

    public class RotateInUpLeftAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            float x = view.PaddingLeft;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "rotation", 90, 0),
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }

    public class RotateInUpRightAnimator : BaseViewAnimator
    {
        public override bool AlphaFromZero { get { return true; } }

        protected override void Prepare(View view)
        {
            float x = view.Width - view.PaddingRight;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "rotation", -90, 0),
                    ObjectAnimator.OfFloat(view, "alpha", 0, 1),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }




    public class RotateOutAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "rotation", 0, 200)
            );
        }
    }

    public class RotateOutDownLeftAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            float x = view.PaddingLeft;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "rotation", 0, 90),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }

    public class RotateOutDownRightAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            float x = view.Width - view.PaddingRight;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "rotation", 0, -90),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }

    public class RotateOutUpLeftAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            float x = view.PaddingLeft;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "rotation", 0, -90),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }

    public class RotateOutUpRightAnimator : BaseViewAnimator
    {
        protected override void Prepare(View view)
        {
            float x = view.Width - view.PaddingRight;
            float y = view.Height - view.PaddingBottom;
            AnimatorAgent.PlayTogether(
                    ObjectAnimator.OfFloat(view, "alpha", 1, 0),
                    ObjectAnimator.OfFloat(view, "rotation", 0, 90),
                    ObjectAnimator.OfFloat(view, "pivotX", x, x),
                    ObjectAnimator.OfFloat(view, "pivotY", y, y)
            );
        }
    }


}