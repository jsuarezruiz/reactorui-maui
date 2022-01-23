using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IBorder : IView
    {
        PropertyValue<Microsoft.Maui.Thickness>? Padding { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? Stroke { get; set; }
        PropertyValue<double>? StrokeThickness { get; set; }
        PropertyValue<Microsoft.Maui.Controls.DoubleCollection>? StrokeDashArray { get; set; }
        PropertyValue<double>? StrokeDashOffset { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>? StrokeLineCap { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>? StrokeLineJoin { get; set; }
        PropertyValue<double>? StrokeMiterLimit { get; set; }


    }
    public partial class Border<T> : View<T>, IBorder where T : Microsoft.Maui.Controls.Border, new()
    {
        public Border()
        {

        }

        public Border(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Thickness>? IBorder.Padding { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? IBorder.Stroke { get; set; }
        PropertyValue<double>? IBorder.StrokeThickness { get; set; }
        PropertyValue<Microsoft.Maui.Controls.DoubleCollection>? IBorder.StrokeDashArray { get; set; }
        PropertyValue<double>? IBorder.StrokeDashOffset { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>? IBorder.StrokeLineCap { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>? IBorder.StrokeLineJoin { get; set; }
        PropertyValue<double>? IBorder.StrokeMiterLimit { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIBorder = (IBorder)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.PaddingProperty, thisAsIBorder.Padding);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeProperty, thisAsIBorder.Stroke);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeThicknessProperty, thisAsIBorder.StrokeThickness);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeDashArrayProperty, thisAsIBorder.StrokeDashArray);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, thisAsIBorder.StrokeDashOffset);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeLineCapProperty, thisAsIBorder.StrokeLineCap);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeLineJoinProperty, thisAsIBorder.StrokeLineJoin);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, thisAsIBorder.StrokeMiterLimit);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIBorder = (IBorder)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeThicknessProperty, thisAsIBorder.StrokeThickness);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, thisAsIBorder.StrokeDashOffset);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, thisAsIBorder.StrokeMiterLimit);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class Border : Border<Microsoft.Maui.Controls.Border>
    {
        public Border()
        {

        }

        public Border(Action<Microsoft.Maui.Controls.Border?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class BorderExtensions
    {
        public static T Padding<T>(this T border, Microsoft.Maui.Thickness padding) where T : IBorder
        {
            border.Padding = new PropertyValue<Microsoft.Maui.Thickness>(padding);
            return border;
        }

        public static T Padding<T>(this T border, Func<Microsoft.Maui.Thickness> paddingFunc) where T : IBorder
        {
            border.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
            return border;
        }
        public static T Padding<T>(this T border, double leftRight, double topBottom) where T : IBorder
        {
            border.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(leftRight, topBottom));
            return border;
        }
        public static T Padding<T>(this T border, double uniformSize) where T : IBorder
        {
            border.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(uniformSize));
            return border;
        }



        public static T Stroke<T>(this T border, Microsoft.Maui.Controls.Brush stroke) where T : IBorder
        {
            border.Stroke = new PropertyValue<Microsoft.Maui.Controls.Brush>(stroke);
            return border;
        }

        public static T Stroke<T>(this T border, Func<Microsoft.Maui.Controls.Brush> strokeFunc) where T : IBorder
        {
            border.Stroke = new PropertyValue<Microsoft.Maui.Controls.Brush>(strokeFunc);
            return border;
        }



        public static T StrokeThickness<T>(this T border, double strokeThickness, RxDoubleAnimation? customAnimation = null) where T : IBorder
        {
            border.StrokeThickness = new PropertyValue<double>(strokeThickness);
            border.AppendAnimatable(Microsoft.Maui.Controls.Border.StrokeThicknessProperty, customAnimation ?? new RxDoubleAnimation(strokeThickness), v => border.StrokeThickness = new PropertyValue<double>(v.CurrentValue()));
            return border;
        }

        public static T StrokeThickness<T>(this T border, Func<double> strokeThicknessFunc) where T : IBorder
        {
            border.StrokeThickness = new PropertyValue<double>(strokeThicknessFunc);
            return border;
        }



        public static T StrokeDashArray<T>(this T border, Microsoft.Maui.Controls.DoubleCollection strokeDashArray) where T : IBorder
        {
            border.StrokeDashArray = new PropertyValue<Microsoft.Maui.Controls.DoubleCollection>(strokeDashArray);
            return border;
        }

        public static T StrokeDashArray<T>(this T border, Func<Microsoft.Maui.Controls.DoubleCollection> strokeDashArrayFunc) where T : IBorder
        {
            border.StrokeDashArray = new PropertyValue<Microsoft.Maui.Controls.DoubleCollection>(strokeDashArrayFunc);
            return border;
        }



        public static T StrokeDashOffset<T>(this T border, double strokeDashOffset, RxDoubleAnimation? customAnimation = null) where T : IBorder
        {
            border.StrokeDashOffset = new PropertyValue<double>(strokeDashOffset);
            border.AppendAnimatable(Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, customAnimation ?? new RxDoubleAnimation(strokeDashOffset), v => border.StrokeDashOffset = new PropertyValue<double>(v.CurrentValue()));
            return border;
        }

        public static T StrokeDashOffset<T>(this T border, Func<double> strokeDashOffsetFunc) where T : IBorder
        {
            border.StrokeDashOffset = new PropertyValue<double>(strokeDashOffsetFunc);
            return border;
        }



        public static T StrokeLineCap<T>(this T border, Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap) where T : IBorder
        {
            border.StrokeLineCap = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>(strokeLineCap);
            return border;
        }

        public static T StrokeLineCap<T>(this T border, Func<Microsoft.Maui.Controls.Shapes.PenLineCap> strokeLineCapFunc) where T : IBorder
        {
            border.StrokeLineCap = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>(strokeLineCapFunc);
            return border;
        }



        public static T StrokeLineJoin<T>(this T border, Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin) where T : IBorder
        {
            border.StrokeLineJoin = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>(strokeLineJoin);
            return border;
        }

        public static T StrokeLineJoin<T>(this T border, Func<Microsoft.Maui.Controls.Shapes.PenLineJoin> strokeLineJoinFunc) where T : IBorder
        {
            border.StrokeLineJoin = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>(strokeLineJoinFunc);
            return border;
        }



        public static T StrokeMiterLimit<T>(this T border, double strokeMiterLimit, RxDoubleAnimation? customAnimation = null) where T : IBorder
        {
            border.StrokeMiterLimit = new PropertyValue<double>(strokeMiterLimit);
            border.AppendAnimatable(Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, customAnimation ?? new RxDoubleAnimation(strokeMiterLimit), v => border.StrokeMiterLimit = new PropertyValue<double>(v.CurrentValue()));
            return border;
        }

        public static T StrokeMiterLimit<T>(this T border, Func<double> strokeMiterLimitFunc) where T : IBorder
        {
            border.StrokeMiterLimit = new PropertyValue<double>(strokeMiterLimitFunc);
            return border;
        }




    }
}
