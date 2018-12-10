using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
interface MDCTabBarViewController : IMDCTabBarDelegate, IUIBarPositioningDelegate
{
    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCTabBarControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCTabBarControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (copy, nonatomic) NSArray<UIViewController *> * _Nonnull viewControllers;
    [Export ("viewControllers", ArgumentSemantic.Copy)]
    UIViewController[] ViewControllers { get; set; }

    // @property (nonatomic, weak) UIViewController * _Nullable selectedViewController;
    [NullAllowed, Export ("selectedViewController", ArgumentSemantic.Weak)]
    UIViewController SelectedViewController { get; set; }

    // @property (readonly, nonatomic) MDCTabBar * _Nullable tabBar;
    [NullAllowed, Export ("tabBar")]
    MDCTabBar TabBar { get; }

    // @property (nonatomic) BOOL tabBarHidden;
    [Export ("tabBarHidden")]
    bool TabBarHidden { get; set; }

    // -(void)setTabBarHidden:(BOOL)hidden animated:(BOOL)animated;
    [Export ("setTabBarHidden:animated:")]
    void SetTabBarHidden (bool hidden, bool animated);
}