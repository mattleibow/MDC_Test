using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_chevron_right
{
    // +(NSString * _Nonnull)pathFor_ic_chevron_right;
    [Static]
    [Export ("pathFor_ic_chevron_right")]
    [Verify (MethodToProperty)]
    string PathFor_ic_chevron_right { get; }

    // +(UIImage * _Nullable)imageFor_ic_chevron_right;
    [Static]
    [NullAllowed, Export ("imageFor_ic_chevron_right")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_chevron_right { get; }
}