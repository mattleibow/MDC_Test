using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCCardScheme : IMDCCardScheming
{
    // @property (readwrite, nonatomic) MDCSemanticColorScheme * _Nonnull colorScheme;
    [Export ("colorScheme", ArgumentSemantic.Assign)]
    MDCSemanticColorScheme ColorScheme { get; set; }

    // @property (readwrite, nonatomic) MDCShapeScheme * _Nonnull shapeScheme;
    [Export ("shapeScheme", ArgumentSemantic.Assign)]
    MDCShapeScheme ShapeScheme { get; set; }
}