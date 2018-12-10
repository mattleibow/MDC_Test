using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCNumericValueLabel
{
    // @property (retain, nonatomic) UIColor * backgroundColor;
    [Export ("backgroundColor", ArgumentSemantic.Retain)]
    UIColor BackgroundColor { get; set; }

    // @property (retain, nonatomic) UIColor * textColor;
    [Export ("textColor", ArgumentSemantic.Retain)]
    UIColor TextColor { get; set; }

    // @property (nonatomic) CGFloat fontSize;
    [Export ("fontSize")]
    nfloat FontSize { get; set; }

    // @property (copy, nonatomic) NSString * text;
    [Export ("text")]
    string Text { get; set; }
}