using Foundation;

[BaseType (typeof(NSObject))]
interface MDCButtonShapeThemer
{
    // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toButton:(MDCButton * _Nonnull)button;
    [Static]
    [Export ("applyShapeScheme:toButton:")]
    void ApplyShapeScheme (MDCShapeScheming shapeScheme, MDCButton button);
}