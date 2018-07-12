using System;
using Xamarin.Forms;

namespace XAnimation.Forms
{
    public class KeyFrame<T>
    {
        public double MilliSeconds { get; set; }
        public T Value { get; set; }
        public Easing Easing { get; set; }
    }

    public abstract class AnimationDefinition
    {
        public uint Duration { get; set; }
        public int PauseBefore { get; set; }
        public int PauseAfter { get; set; }
        public double SpeedRatio { get; set; }
        public int RepeatCount { get; set; }
        public int RepeatDuration { get; set; }
        public int Delay { get; set; }
        public bool AutoReverse { get; set; }
        public bool Forever { get; set; }

        public bool OpacityFromZero { get; protected set; }

        protected AnimationDefinition()
        {
            Duration = 1000;
        }

        protected Tuple<double, double> GetTranslation(VisualElement element)
        {
            var x = element.TranslationX;
            var y = element.TranslationY;
            return new Tuple<double, double>(x, y);
        }

        public abstract Animation CreateAnimation(VisualElement element);

        public AnimationDefinition Clone()
        {
            var clone = (AnimationDefinition)MemberwiseClone();
            return clone;
        }
    }
}
