using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIViewController))]
interface UIViewController_MaterialBottomSheet
{
    // @property (readonly, nonatomic) MDCBottomSheetPresentationController * _Nullable mdc_bottomSheetPresentationController;
    [NullAllowed, Export ("mdc_bottomSheetPresentationController")]
    MDCBottomSheetPresentationController Mdc_bottomSheetPresentationController { get; }
}