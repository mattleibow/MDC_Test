using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCCardScheme : IMDCCardScheming
{
    // @property (readwrite, nonatomic) MDCSemanticColorScheme * _Nonnull colorScheme;
    [Export ("colorScheme", ArgumentSemantic.Assign)]
    MDCSemanticColorScheme ColorScheme { get; set; }
}