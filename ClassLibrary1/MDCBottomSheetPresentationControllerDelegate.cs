using Foundation;
using UIKit;

[Protocol, Model]
interface MDCBottomSheetPresentationControllerDelegate : IUIAdaptivePresentationControllerDelegate
{
    // @optional -(void)prepareForBottomSheetPresentation:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet;
    [Export ("prepareForBottomSheetPresentation:")]
    void PrepareForBottomSheetPresentation (MDCBottomSheetPresentationController bottomSheet);

    // @optional -(void)bottomSheetPresentationControllerDidDismissBottomSheet:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet;
    [Export ("bottomSheetPresentationControllerDidDismissBottomSheet:")]
    void BottomSheetPresentationControllerDidDismissBottomSheet (MDCBottomSheetPresentationController bottomSheet);

    // @optional -(void)bottomSheetWillChangeState:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet sheetState:(MDCSheetState)sheetState;
    [Export ("bottomSheetWillChangeState:sheetState:")]
    void BottomSheetWillChangeState (MDCBottomSheetPresentationController bottomSheet, MDCSheetState sheetState);
}