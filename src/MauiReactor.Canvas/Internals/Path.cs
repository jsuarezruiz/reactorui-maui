﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor.Canvas.Internals
{
    public class Path : CanvasVisualElement
    {
        public static readonly BindableProperty DataProperty = BindableProperty.Create(nameof(Data), typeof(PathF), typeof(Path), null);

        public PathF? Data
        {
            get => (PathF?)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }

        public static readonly BindableProperty StrokeColorProperty = BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(Path), null);

        public Color? StrokeColor
        {
            get => (Color?)GetValue(StrokeColorProperty);
            set => SetValue(StrokeColorProperty, value);
        }

        public static readonly BindableProperty StrokeSizeProperty = BindableProperty.Create(nameof(StrokeSize), typeof(float), typeof(Path), 1.0f,
            coerceValue: (BindableObject bindable, object value) => Math.Max((float)value, 0.0f));

        public float StrokeSize
        {
            get => (float)GetValue(StrokeSizeProperty);
            set => SetValue(StrokeSizeProperty, value);
        }

        public static readonly BindableProperty FillColorProperty = BindableProperty.Create(nameof(FillColor), typeof(Color), typeof(Path), null);

        public Color? FillColor
        {
            get => (Color?)GetValue(FillColorProperty);
            set => SetValue(FillColorProperty, value);
        }

        public static readonly BindableProperty WindingProperty = BindableProperty.Create(nameof(Winding), typeof(WindingMode), typeof(Path), null);

        public WindingMode Winding
        {
            get => (WindingMode)GetValue(WindingProperty);
            set => SetValue(WindingProperty, value);
        }

        protected override void OnDraw(DrawingContext context)
        {
            context.Canvas.SaveState();

            context.Canvas.Translate(context.DirtyRect.Location.X, context.DirtyRect.Location.Y);

            if (FillColor != null && Data != null)
            {
                context.Canvas.FillColor = FillColor;
                context.Canvas.FillPath(Data);
            }
            if (StrokeColor != null && Data != null)
            {
                context.Canvas.StrokeColor = StrokeColor;
                context.Canvas.StrokeSize = StrokeSize;
                context.Canvas.DrawPath(Data);
            }

            context.Canvas.RestoreState();

            base.OnDraw(context);
        }

    }
}
