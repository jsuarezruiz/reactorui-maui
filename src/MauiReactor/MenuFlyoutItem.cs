// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor
{
    public partial interface IMenuFlyoutItem : IMenuItem
    {
    }

    public partial class MenuFlyoutItem<T> : MenuItem<T>, IMenuFlyoutItem where T : Microsoft.Maui.Controls.MenuFlyoutItem, new()
    {
        public MenuFlyoutItem()
        {
        }

        public MenuFlyoutItem(Action<T?> componentRefAction) : base(componentRefAction)
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

    public partial class MenuFlyoutItem : MenuFlyoutItem<Microsoft.Maui.Controls.MenuFlyoutItem>
    {
        public MenuFlyoutItem()
        {
        }

        public MenuFlyoutItem(Action<Microsoft.Maui.Controls.MenuFlyoutItem?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class MenuFlyoutItemExtensions
    {
    }
}