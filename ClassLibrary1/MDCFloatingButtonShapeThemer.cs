using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFloatingButtonShapeThemer
{
    // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toButton:(MDCFloatingButton * _Nonnull)button;
    [Static]
    [Export ("applyShapeScheme:toButton:")]
    void ApplyShapeScheme (MDCShapeScheming shapeScheme, MDCFloatingButton button);
}