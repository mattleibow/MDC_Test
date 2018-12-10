using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCListScheme : IMDCListScheming
{
    // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Export ("colorScheme", ArgumentSemantic.Assign)]
    MDCColorScheming ColorScheme { get; set; }

    // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
    [Export ("typographyScheme", ArgumentSemantic.Assign)]
    MDCTypographyScheming TypographyScheme { get; set; }
}