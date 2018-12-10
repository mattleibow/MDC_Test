using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
interface MDCFlexibleHeaderViewController : IUIScrollViewDelegate, IUITableViewDelegate
{
    // @property (readonly, nonatomic, strong) MDCFlexibleHeaderView * _Nonnull headerView;
    [Export ("headerView", ArgumentSemantic.Strong)]
    MDCFlexibleHeaderView HeaderView { get; }

    [Wrap ("WeakLayoutDelegate")]
    [NullAllowed]
    MDCFlexibleHeaderViewLayoutDelegate LayoutDelegate { get; set; }

    // @property (nonatomic, weak) id<MDCFlexibleHeaderViewLayoutDelegate> _Nullable layoutDelegate;
    [NullAllowed, Export ("layoutDelegate", ArgumentSemantic.Weak)]
    NSObject WeakLayoutDelegate { get; set; }

    // @property (getter = isTopLayoutGuideAdjustmentEnabled, nonatomic) BOOL topLayoutGuideAdjustmentEnabled;
    [Export ("topLayoutGuideAdjustmentEnabled")]
    bool TopLayoutGuideAdjustmentEnabled { [Bind ("isTopLayoutGuideAdjustmentEnabled")] get; set; }

    // @property (nonatomic, weak) UIViewController * _Nullable topLayoutGuideViewController;
    [NullAllowed, Export ("topLayoutGuideViewController", ArgumentSemantic.Weak)]
    UIViewController TopLayoutGuideViewController { get; set; }

    // @property (nonatomic) BOOL inferTopSafeAreaInsetFromViewController;
    [Export ("inferTopSafeAreaInsetFromViewController")]
    bool InferTopSafeAreaInsetFromViewController { get; set; }

    // @property (nonatomic) BOOL useAdditionalSafeAreaInsetsForWebKitScrollViews;
    [Export ("useAdditionalSafeAreaInsetsForWebKitScrollViews")]
    bool UseAdditionalSafeAreaInsetsForWebKitScrollViews { get; set; }

    // -(BOOL)prefersStatusBarHidden;
    [Export ("prefersStatusBarHidden")]
    [Verify (MethodToProperty)]
    bool PrefersStatusBarHidden { get; }

    // @property (nonatomic) UIStatusBarStyle preferredStatusBarStyle;
    [Export ("preferredStatusBarStyle", ArgumentSemantic.Assign)]
    UIStatusBarStyle PreferredStatusBarStyle { get; set; }

    // @property (nonatomic) BOOL inferPreferredStatusBarStyle;
    [Export ("inferPreferredStatusBarStyle")]
    bool InferPreferredStatusBarStyle { get; set; }
}