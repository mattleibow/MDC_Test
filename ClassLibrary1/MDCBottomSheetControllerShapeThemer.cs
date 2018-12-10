using Foundation;

[BaseType (typeof(NSObject))]
interface MDCBottomSheetControllerShapeThemer
{
    // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toBottomSheetController:(MDCBottomSheetController * _Nonnull)bottomSheetController;
    [Static]
    [Export ("applyShapeScheme:toBottomSheetController:")]
    void ApplyShapeScheme (MDCShapeScheming shapeScheme, MDCBottomSheetController bottomSheetController);
}