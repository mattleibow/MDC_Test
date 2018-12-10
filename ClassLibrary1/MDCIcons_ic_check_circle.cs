using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_check_circle
{
    // +(NSString * _Nonnull)pathFor_ic_check_circle;
    [Static]
    [Export ("pathFor_ic_check_circle")]
    [Verify (MethodToProperty)]
    string PathFor_ic_check_circle { get; }

    // +(UIImage * _Nullable)imageFor_ic_check_circle;
    [Static]
    [NullAllowed, Export ("imageFor_ic_check_circle")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_check_circle { get; }
}