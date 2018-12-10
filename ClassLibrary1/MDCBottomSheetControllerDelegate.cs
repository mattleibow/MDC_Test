using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCBottomSheetControllerDelegate
{
    // @required -(void)bottomSheetControllerDidDismissBottomSheet:(MDCBottomSheetController * _Nonnull)controller;
    [Abstract]
    [Export ("bottomSheetControllerDidDismissBottomSheet:")]
    void BottomSheetControllerDidDismissBottomSheet (MDCBottomSheetController controller);
}