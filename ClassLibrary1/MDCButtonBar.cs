using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCButtonBar
{
    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable items;
    [NullAllowed, Export ("items", ArgumentSemantic.Copy)]
    UIBarButtonItem[] Items { get; set; }

    // @property (nonatomic) CGFloat buttonTitleBaseline;
    [Export ("buttonTitleBaseline")]
    nfloat ButtonTitleBaseline { get; set; }

    // -(void)setButtonsTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state;
    [Export ("setButtonsTitleFont:forState:")]
    void SetButtonsTitleFont ([NullAllowed] UIFont font, UIControlState state);

    // -(UIFont * _Nullable)buttonsTitleFontForState:(UIControlState)state;
    [Export ("buttonsTitleFontForState:")]
    [return: NullAllowed]
    UIFont ButtonsTitleFontForState (UIControlState state);

    // -(void)setButtonsTitleColor:(UIColor * _Nullable)color forState:(UIControlState)state;
    [Export ("setButtonsTitleColor:forState:")]
    void SetButtonsTitleColor ([NullAllowed] UIColor color, UIControlState state);

    // -(UIColor * _Nullable)buttonsTitleColorForState:(UIControlState)state;
    [Export ("buttonsTitleColorForState:")]
    [return: NullAllowed]
    UIColor ButtonsTitleColorForState (UIControlState state);

    // @property (nonatomic) MDCButtonBarLayoutPosition layoutPosition;
    [Export ("layoutPosition", ArgumentSemantic.Assign)]
    MDCButtonBarLayoutPosition LayoutPosition { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable inkColor;
    [NullAllowed, Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // -(CGSize)sizeThatFits:(CGSize)size;
    [Export ("sizeThatFits:")]
    CGSize SizeThatFits (CGSize size);
}