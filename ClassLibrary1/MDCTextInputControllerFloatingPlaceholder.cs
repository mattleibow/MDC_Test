using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
interface MDCTextInputControllerFloatingPlaceholder : IMDCTextInputController
{
    // @required @property (nonatomic, strong) UIColor * _Null_unspecified floatingPlaceholderActiveColor;
    [Abstract]
    [Export ("floatingPlaceholderActiveColor", ArgumentSemantic.Strong)]
    UIColor FloatingPlaceholderActiveColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified floatingPlaceholderActiveColorDefault;
    [Static, Abstract]
    [Export ("floatingPlaceholderActiveColorDefault", ArgumentSemantic.Strong)]
    UIColor FloatingPlaceholderActiveColorDefault { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified floatingPlaceholderNormalColor;
    [Abstract]
    [Export ("floatingPlaceholderNormalColor", ArgumentSemantic.Strong)]
    UIColor FloatingPlaceholderNormalColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified floatingPlaceholderNormalColorDefault;
    [Static, Abstract]
    [Export ("floatingPlaceholderNormalColorDefault", ArgumentSemantic.Strong)]
    UIColor FloatingPlaceholderNormalColorDefault { get; set; }

    // @required @property (readonly, nonatomic) UIOffset floatingPlaceholderOffset;
    [Abstract]
    [Export ("floatingPlaceholderOffset")]
    UIOffset FloatingPlaceholderOffset { get; }

    // @required @property (nonatomic, strong) NSNumber * _Null_unspecified floatingPlaceholderScale;
    [Abstract]
    [Export ("floatingPlaceholderScale", ArgumentSemantic.Strong)]
    NSNumber FloatingPlaceholderScale { get; set; }

    // @required @property (assign, nonatomic, class) CGFloat floatingPlaceholderScaleDefault;
    [Static, Abstract]
    [Export ("floatingPlaceholderScaleDefault")]
    nfloat FloatingPlaceholderScaleDefault { get; set; }

    // @required @property (getter = isFloatingEnabled, assign, nonatomic) BOOL floatingEnabled;
    [Abstract]
    [Export ("floatingEnabled")]
    bool FloatingEnabled { [Bind ("isFloatingEnabled")] get; set; }

    // @required @property (getter = isFloatingEnabledDefault, assign, nonatomic, class) BOOL floatingEnabledDefault;
    [Static, Abstract]
    [Export ("floatingEnabledDefault")]
    bool FloatingEnabledDefault { [Bind ("isFloatingEnabledDefault")] get; set; }
}