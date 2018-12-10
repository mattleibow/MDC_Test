using System;
using CoreGraphics;
using Foundation;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDFTextAccessibility
{
    // +(UIColor * _Nonnull)textColorOnBackgroundColor:(UIColor * _Nonnull)backgroundColor targetTextAlpha:(CGFloat)targetTextAlpha font:(UIFont * _Nullable)font;
    [Static]
    [Export ("textColorOnBackgroundColor:targetTextAlpha:font:")]
    UIColor TextColorOnBackgroundColor (UIColor backgroundColor, nfloat targetTextAlpha, [NullAllowed] UIFont font);

    // +(UIColor * _Nullable)textColorOnBackgroundImage:(UIImage * _Nonnull)backgroundImage inRegion:(CGRect)region targetTextAlpha:(CGFloat)targetTextAlpha font:(UIFont * _Nullable)font;
    [Static]
    [Export ("textColorOnBackgroundImage:inRegion:targetTextAlpha:font:")]
    [return: NullAllowed]
    UIColor TextColorOnBackgroundImage (UIImage backgroundImage, CGRect region, nfloat targetTextAlpha, [NullAllowed] UIFont font);

    // +(UIColor * _Nullable)textColorOnBackgroundColor:(UIColor * _Nonnull)backgroundColor targetTextAlpha:(CGFloat)targetTextAlpha options:(MDFTextAccessibilityOptions)options;
    [Static]
    [Export ("textColorOnBackgroundColor:targetTextAlpha:options:")]
    [return: NullAllowed]
    UIColor TextColorOnBackgroundColor (UIColor backgroundColor, nfloat targetTextAlpha, MDFTextAccessibilityOptions options);

    // +(UIColor * _Nullable)textColorFromChoices:(NSArray<UIColor *> * _Nonnull)choices onBackgroundColor:(UIColor * _Nonnull)backgroundColor options:(MDFTextAccessibilityOptions)options;
    [Static]
    [Export ("textColorFromChoices:onBackgroundColor:options:")]
    [return: NullAllowed]
    UIColor TextColorFromChoices (UIColor[] choices, UIColor backgroundColor, MDFTextAccessibilityOptions options);

    // +(CGFloat)minAlphaOfTextColor:(UIColor * _Nonnull)textColor onBackgroundColor:(UIColor * _Nonnull)backgroundColor options:(MDFTextAccessibilityOptions)options;
    [Static]
    [Export ("minAlphaOfTextColor:onBackgroundColor:options:")]
    nfloat MinAlphaOfTextColor (UIColor textColor, UIColor backgroundColor, MDFTextAccessibilityOptions options);

    // +(CGFloat)contrastRatioForTextColor:(UIColor * _Nonnull)textColor onBackgroundColor:(UIColor * _Nonnull)backgroundColor;
    [Static]
    [Export ("contrastRatioForTextColor:onBackgroundColor:")]
    nfloat ContrastRatioForTextColor (UIColor textColor, UIColor backgroundColor);

    // +(BOOL)textColor:(UIColor * _Nonnull)textColor passesOnBackgroundColor:(UIColor * _Nonnull)backgroundColor options:(MDFTextAccessibilityOptions)options;
    [Static]
    [Export ("textColor:passesOnBackgroundColor:options:")]
    bool TextColor (UIColor textColor, UIColor backgroundColor, MDFTextAccessibilityOptions options);

    // +(BOOL)isLargeForContrastRatios:(UIFont * _Nullable)font;
    [Static]
    [Export ("isLargeForContrastRatios:")]
    bool IsLargeForContrastRatios ([NullAllowed] UIFont font);
}