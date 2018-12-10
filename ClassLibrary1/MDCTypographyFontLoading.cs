using System;
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTypographyFontLoading
{
    // @required -(UIFont * _Nullable)lightFontOfSize:(CGFloat)fontSize;
    [Abstract]
    [Export ("lightFontOfSize:")]
    [return: NullAllowed]
    UIFont LightFontOfSize (nfloat fontSize);

    // @required -(UIFont * _Nonnull)regularFontOfSize:(CGFloat)fontSize;
    [Abstract]
    [Export ("regularFontOfSize:")]
    UIFont RegularFontOfSize (nfloat fontSize);

    // @required -(UIFont * _Nullable)mediumFontOfSize:(CGFloat)fontSize;
    [Abstract]
    [Export ("mediumFontOfSize:")]
    [return: NullAllowed]
    UIFont MediumFontOfSize (nfloat fontSize);

    // @optional -(UIFont * _Nonnull)boldFontOfSize:(CGFloat)fontSize;
    [Export ("boldFontOfSize:")]
    UIFont BoldFontOfSize (nfloat fontSize);

    // @optional -(UIFont * _Nonnull)italicFontOfSize:(CGFloat)fontSize;
    [Export ("italicFontOfSize:")]
    UIFont ItalicFontOfSize (nfloat fontSize);

    // @optional -(UIFont * _Nullable)boldItalicFontOfSize:(CGFloat)fontSize;
    [Export ("boldItalicFontOfSize:")]
    [return: NullAllowed]
    UIFont BoldItalicFontOfSize (nfloat fontSize);

    // @optional -(UIFont * _Nonnull)boldFontFromFont:(UIFont * _Nonnull)font;
    [Export ("boldFontFromFont:")]
    UIFont BoldFontFromFont (UIFont font);

    // @optional -(UIFont * _Nonnull)italicFontFromFont:(UIFont * _Nonnull)font;
    [Export ("italicFontFromFont:")]
    UIFont ItalicFontFromFont (UIFont font);

    // @optional -(BOOL)isLargeForContrastRatios:(UIFont * _Nonnull)font;
    [Export ("isLargeForContrastRatios:")]
    bool IsLargeForContrastRatios (UIFont font);
}