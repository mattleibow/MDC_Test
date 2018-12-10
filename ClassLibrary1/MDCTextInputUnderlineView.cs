using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCTextInputUnderlineView : INSCopying
{
    // @property (nonatomic, strong) UIColor * color;
    [Export ("color", ArgumentSemantic.Strong)]
    UIColor Color { get; set; }

    // @property (nonatomic, strong) UIColor * disabledColor;
    [Export ("disabledColor", ArgumentSemantic.Strong)]
    UIColor DisabledColor { get; set; }

    // @property (assign, nonatomic) BOOL enabled;
    [Export ("enabled")]
    bool Enabled { get; set; }

    // @property (assign, nonatomic) CGFloat lineHeight;
    [Export ("lineHeight")]
    nfloat LineHeight { get; set; }
}