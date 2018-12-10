using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCBottomSheetTransitionController : IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
{
    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }

    // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
    [Export ("dismissOnBackgroundTap")]
    bool DismissOnBackgroundTap { get; set; }
}