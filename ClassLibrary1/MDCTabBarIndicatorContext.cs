using CoreGraphics;
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTabBarIndicatorContext
{
    // @required @property (readonly, nonatomic) UITabBarItem * _Nonnull item;
    [Abstract]
    [Export ("item")]
    UITabBarItem Item { get; }

    // @required @property (readonly, nonatomic) CGRect bounds;
    [Abstract]
    [Export ("bounds")]
    CGRect Bounds { get; }

    // @required @property (readonly, nonatomic) CGRect contentFrame;
    [Abstract]
    [Export ("contentFrame")]
    CGRect ContentFrame { get; }
}