using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCFlexibleHeaderView))]
interface MDCFlexibleHeaderView_
{
    // @property (nonatomic, strong) UIView * _Nonnull contentView __attribute__((deprecated("Please register views directly to the flexible header.")));
    [Export ("contentView", ArgumentSemantic.Strong)]
    UIView ContentView { get; set; }
}