using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
[DisableDefaultCtor]
interface MDCAppBarContainerViewController
{
    // -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController __attribute__((objc_designated_initializer));
    [Export ("initWithContentViewController:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIViewController contentViewController);

    // @property (readonly, nonatomic, strong) MDCAppBarViewController * _Nonnull appBarViewController;
    [Export ("appBarViewController", ArgumentSemantic.Strong)]
    MDCAppBarViewController AppBarViewController { get; }

    // @property (readonly, nonatomic, strong) UIViewController * _Nonnull contentViewController;
    [Export ("contentViewController", ArgumentSemantic.Strong)]
    UIViewController ContentViewController { get; }

    // @property (getter = isTopLayoutGuideAdjustmentEnabled, nonatomic) BOOL topLayoutGuideAdjustmentEnabled;
    [Export ("topLayoutGuideAdjustmentEnabled")]
    bool TopLayoutGuideAdjustmentEnabled { [Bind ("isTopLayoutGuideAdjustmentEnabled")] get; set; }

    // @property (readonly, nonatomic, strong) MDCAppBar * _Nonnull appBar;
    [Export ("appBar", ArgumentSemantic.Strong)]
    MDCAppBar AppBar { get; }
}