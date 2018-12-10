using System;
using CoreGraphics;
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTextInputPositioningDelegate
{
    // @optional -(UIEdgeInsets)textInsets:(UIEdgeInsets)defaultInsets;
    [Export ("textInsets:")]
    UIEdgeInsets TextInsets (UIEdgeInsets defaultInsets);

    // @optional -(CGRect)editingRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
    [Export ("editingRectForBounds:defaultRect:")]
    CGRect EditingRectForBounds (CGRect bounds, CGRect defaultRect);

    // @optional -(CGRect)leadingViewRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
    [Export ("leadingViewRectForBounds:defaultRect:")]
    CGRect LeadingViewRectForBounds (CGRect bounds, CGRect defaultRect);

    // @optional -(CGFloat)leadingViewTrailingPaddingConstant;
    [Export ("leadingViewTrailingPaddingConstant")]
    [Verify (MethodToProperty)]
    nfloat LeadingViewTrailingPaddingConstant { get; }

    // @optional -(void)textInputDidLayoutSubviews;
    [Export ("textInputDidLayoutSubviews")]
    void TextInputDidLayoutSubviews ();

    // @optional -(void)textInputDidUpdateConstraints;
    [Export ("textInputDidUpdateConstraints")]
    void TextInputDidUpdateConstraints ();

    // @optional -(CGRect)trailingViewRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
    [Export ("trailingViewRectForBounds:defaultRect:")]
    CGRect TrailingViewRectForBounds (CGRect bounds, CGRect defaultRect);

    // @optional -(CGFloat)trailingViewTrailingPaddingConstant;
    [Export ("trailingViewTrailingPaddingConstant")]
    [Verify (MethodToProperty)]
    nfloat TrailingViewTrailingPaddingConstant { get; }
}