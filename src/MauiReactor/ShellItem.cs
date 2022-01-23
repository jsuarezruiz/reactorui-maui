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
    public partial interface IShellItem : IShellGroupItem
    {


    }
    public partial class ShellItem<T> : ShellGroupItem<T>, IShellItem where T : Microsoft.Maui.Controls.ShellItem, new()
    {
        public ShellItem()
        {

        }

        public ShellItem(Action<T?> componentRefAction)
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

    public partial class ShellItem : ShellItem<Microsoft.Maui.Controls.ShellItem>
    {
        public ShellItem()
        {

        }

        public ShellItem(Action<Microsoft.Maui.Controls.ShellItem?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class ShellItemExtensions
    {

    }
}
