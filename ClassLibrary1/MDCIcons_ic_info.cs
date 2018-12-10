using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_info
{
    // +(NSString * _Nonnull)pathFor_ic_info;
    [Static]
    [Export ("pathFor_ic_info")]
    [Verify (MethodToProperty)]
    string PathFor_ic_info { get; }

    // +(UIImage * _Nullable)imageFor_ic_info;
    [Static]
    [NullAllowed, Export ("imageFor_ic_info")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_info { get; }
}