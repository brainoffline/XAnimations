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

namespace XAnimations
{
    public class AnimationTechniques
    {
        public static Type[] Animators = new [] {

            // Attention Animators
            typeof(BounceAnimator),
            typeof(FlashAnimator),
            typeof(PulseAnimator),
            typeof(RubberBandAnimator),
            typeof(ShakeAnimator),
            typeof(StandUpAnimator),
            typeof(SwingAnimator),
            typeof(TadaAnimator),
            typeof(WaveAnimator),
            typeof(WobbleAnimator),

            // Bounce In Animators
            typeof(BounceInAnimator),
            typeof(BounceInDownAnimator),
            typeof(BounceInLeftAnimator),
            typeof(BounceInRightAnimator),
            typeof(BounceInUpAnimator),

            // Fading Animators
            typeof(FadeInAnimator),
            typeof(FadeInDownAnimator),
            typeof(FadeInLeftAnimator),
            typeof(FadeInRightAnimator),
            typeof(FadeInUpAnimator),

            typeof(FadeOutAnimator),
            typeof(FadeOutDownAnimator),
            typeof(FadeOutLeftAnimator),
            typeof(FadeOutRightAnimator),
            typeof(FadeOutUpAnimator),

            // Flipping Animators
            typeof(FlipInXAnimator),
            typeof(FlipInYAnimator),
            typeof(FlipOutXAnimator),
            typeof(FlipOutYAnimator),

            // Rotating Animators
            typeof(RotateInAnimator),
            typeof(RotateInDownLeftAnimator),
            typeof(RotateInDownRightAnimator),
            typeof(RotateInUpLeftAnimator),
            typeof(RotateInUpRightAnimator),

            typeof(RotateOutAnimator),
            typeof(RotateOutDownLeftAnimator),
            typeof(RotateOutDownRightAnimator),
            typeof(RotateOutUpLeftAnimator),
            typeof(RotateOutUpRightAnimator),

            //Sliding Animators
            typeof(SlideInDownAnimator),
            typeof(SlideInLeftAnimator),
            typeof(SlideInRightAnimator),
            typeof(SlideInUpAnimator),

            typeof(SlideOutDownAnimator),
            typeof(SlideOutLeftAnimator),
            typeof(SlideOutRightAnimator),
            typeof(SlideOutUpAnimator),

            // Special Animators
            typeof(DropOutAnimator),
            typeof(LandingAnimator),
            typeof(TakingOffAnimator),
            typeof(HingeAnimator),
            typeof(RollInAnimator),
            typeof(RollOutAnimator),

            // Zooming Animators
            typeof(ZoomInAnimator),
            typeof(ZoomInDownAnimator),
            typeof(ZoomInLeftAnimator),
            typeof(ZoomInRightAnimator),
            typeof(ZoomInUpAnimator),

            typeof(ZoomOutAnimator),
            typeof(ZoomOutDownAnimator),
            typeof(ZoomOutLeftAnimator),
            typeof(ZoomOutRightAnimator),
            typeof(ZoomOutUpAnimator),
        };
    }
}