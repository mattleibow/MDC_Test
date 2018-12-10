using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_more_horiz
{
    // +(NSString * _Nonnull)pathFor_ic_more_horiz;
    [Static]
    [Export ("pathFor_ic_more_horiz")]
    [Verify (MethodToProperty)]
    string PathFor_ic_more_horiz { get; }

    // +(UIImage * _Nullable)imageFor_ic_more_horiz;
    [Static]
    [NullAllowed, Export ("imageFor_ic_more_horiz")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_more_horiz { get; }
}