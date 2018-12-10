using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_reorder
{
    // +(NSString * _Nonnull)pathFor_ic_reorder;
    [Static]
    [Export ("pathFor_ic_reorder")]
    [Verify (MethodToProperty)]
    string PathFor_ic_reorder { get; }

    // +(UIImage * _Nullable)imageFor_ic_reorder;
    [Static]
    [NullAllowed, Export ("imageFor_ic_reorder")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_reorder { get; }
}