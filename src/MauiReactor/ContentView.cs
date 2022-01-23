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
    public partial interface IContentView : ITemplatedView
    {


    }
    public partial class ContentView<T> : TemplatedView<T>, IContentView where T : Microsoft.Maui.Controls.ContentView, new()
    {
        public ContentView()
        {

        }

        public ContentView(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }



        protected override void OnUpdate()
        {
            OnBeginUpdate();

            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class ContentView : ContentView<Microsoft.Maui.Controls.ContentView>
    {
        public ContentView()
        {

        }

        public ContentView(Action<Microsoft.Maui.Controls.ContentView?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class ContentViewExtensions
    {

    }
}
