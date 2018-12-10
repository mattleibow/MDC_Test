using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIViewController))]
interface UIViewController_MaterialDialogs
{
    // @property (readonly, nonatomic) MDCDialogPresentationController * _Nullable mdc_dialogPresentationController;
    [NullAllowed, Export ("mdc_dialogPresentationController")]
    MDCDialogPresentationController Mdc_dialogPresentationController { get; }
}