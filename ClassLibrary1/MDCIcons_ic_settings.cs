using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_settings
{
    // +(NSString * _Nonnull)pathFor_ic_settings;
    [Static]
    [Export ("pathFor_ic_settings")]
    [Verify (MethodToProperty)]
    string PathFor_ic_settings { get; }

    // +(UIImage * _Nullable)imageFor_ic_settings;
    [Static]
    [NullAllowed, Export ("imageFor_ic_settings")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_settings { get; }
}