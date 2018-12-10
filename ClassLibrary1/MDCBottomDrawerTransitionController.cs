using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCBottomDrawerTransitionController : IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
{
    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }
}