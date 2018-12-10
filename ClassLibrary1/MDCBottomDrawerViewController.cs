using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
interface MDCBottomDrawerViewController : IMDCBottomDrawerPresentationControllerDelegate
{
    // @property (nonatomic) UIViewController * _Nullable contentViewController;
    [NullAllowed, Export ("contentViewController", ArgumentSemantic.Assign)]
    UIViewController ContentViewController { get; set; }

    // @property (nonatomic) UIViewController<MDCBottomDrawerHeader> * _Nullable headerViewController;
    [NullAllowed, Export ("headerViewController", ArgumentSemantic.Assign)]
    MDCBottomDrawerHeader HeaderViewController { get; set; }

    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }

    // @property (readonly, nonatomic) MDCBottomDrawerState drawerState;
    [Export ("drawerState")]
    MDCBottomDrawerState DrawerState { get; }

    // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
    [NullAllowed, Export ("scrimColor", ArgumentSemantic.Strong)]
    UIColor ScrimColor { get; set; }

    // @property (getter = isTopHandleHidden, assign, nonatomic) BOOL topHandleHidden;
    [Export ("topHandleHidden")]
    bool TopHandleHidden { [Bind ("isTopHandleHidden")] get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable topHandleColor;
    [NullAllowed, Export ("topHandleColor", ArgumentSemantic.Strong)]
    UIColor TopHandleColor { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCBottomDrawerViewControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCBottomDrawerViewControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // -(void)setTopCornersRadius:(CGFloat)radius forDrawerState:(MDCBottomDrawerState)drawerState;
    [Export ("setTopCornersRadius:forDrawerState:")]
    void SetTopCornersRadius (nfloat radius, MDCBottomDrawerState drawerState);

    // -(CGFloat)topCornersRadiusForDrawerState:(MDCBottomDrawerState)drawerState;
    [Export ("topCornersRadiusForDrawerState:")]
    nfloat TopCornersRadiusForDrawerState (MDCBottomDrawerState drawerState);

    // -(void)setContentOffsetY:(CGFloat)contentOffsetY animated:(BOOL)animated;
    [Export ("setContentOffsetY:animated:")]
    void SetContentOffsetY (nfloat contentOffsetY, bool animated);
}