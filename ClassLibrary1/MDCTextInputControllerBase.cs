using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCTextInputControllerBase : IMDCTextInputControllerFloatingPlaceholder
{
    // @property (nonatomic, strong) UIColor * _Nullable borderFillColor;
    [NullAllowed, Export ("borderFillColor", ArgumentSemantic.Strong)]
    UIColor BorderFillColor { get; set; }

    // @property (nonatomic, strong, class) UIColor * _Null_unspecified borderFillColorDefault;
    [Static]
    [Export ("borderFillColorDefault", ArgumentSemantic.Strong)]
    UIColor BorderFillColorDefault { get; set; }

    // @property (assign, nonatomic) BOOL expandsOnOverflow;
    [Export ("expandsOnOverflow")]
    bool ExpandsOnOverflow { get; set; }

    // @property (assign, nonatomic) NSUInteger minimumLines;
    [Export ("minimumLines")]
    nuint MinimumLines { get; set; }
}