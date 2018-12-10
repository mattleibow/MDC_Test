using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIPresentationController))]
interface MDCBottomDrawerPresentationController
{
    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
    [NullAllowed, Export ("scrimColor", ArgumentSemantic.Strong)]
    UIColor ScrimColor { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCBottomDrawerPresentationControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCBottomDrawerPresentationControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (getter = isTopHandleHidden, assign, nonatomic) BOOL topHandleHidden;
    [Export ("topHandleHidden")]
    bool TopHandleHidden { [Bind ("isTopHandleHidden")] get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable topHandleColor;
    [NullAllowed, Export ("topHandleColor", ArgumentSemantic.Strong)]
    UIColor TopHandleColor { get; set; }

    // @property (readonly, nonatomic) BOOL contentReachesFullscreen;
    [Export ("contentReachesFullscreen")]
    bool ContentReachesFullscreen { get; }

    // -(void)setContentOffsetY:(CGFloat)contentOffsetY animated:(BOOL)animated;
    [Export ("setContentOffsetY:animated:")]
    void SetContentOffsetY (nfloat contentOffsetY, bool animated);
}