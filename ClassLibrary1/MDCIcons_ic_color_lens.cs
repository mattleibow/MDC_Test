using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_ic_color_lens
{
    // +(NSString * _Nonnull)pathFor_ic_color_lens;
    [Static]
    [Export ("pathFor_ic_color_lens")]
    [Verify (MethodToProperty)]
    string PathFor_ic_color_lens { get; }

    // +(UIImage * _Nullable)imageFor_ic_color_lens;
    [Static]
    [NullAllowed, Export ("imageFor_ic_color_lens")]
    [Verify (MethodToProperty)]
    UIImage ImageFor_ic_color_lens { get; }
}