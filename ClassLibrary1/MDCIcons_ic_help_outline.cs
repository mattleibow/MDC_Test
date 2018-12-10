using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_help_outline
{
    // +(NSString * _Nonnull)pathFor_ic_help_outline;
    [Static]
    [Export ("pathFor_ic_help_outline")]
    [Verify (MethodToProperty)]
    string PathFor_ic_help_outline { get; }

    // +(UIImage * _Nullable)imageFor_ic_help_outline;
    [Static]
    [NullAllowed, Export ("imageFor_ic_help_outline")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_help_outline { get; }
}