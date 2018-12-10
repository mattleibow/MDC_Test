using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIViewController))]
interface UIViewController_MDMTransitionController
{
    // @property (readonly, nonatomic, strong) id<MDMTransitionController> _Nonnull mdm_transitionController;
    [Export ("mdm_transitionController", ArgumentSemantic.Strong)]
    MDMTransitionController Mdm_transitionController { get; }
}