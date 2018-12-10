using System;
using Foundation;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCTypography
{
    // +(id<MDCTypographyFontLoading> _Nonnull)fontLoader;
    // +(void)setFontLoader:(id<MDCTypographyFontLoading> _Nonnull)fontLoader;
    [Static]
    [Export ("fontLoader")]
    [Verify (MethodToProperty)]
    MDCTypographyFontLoading FontLoader { get; set; }

    // +(UIFont * _Nonnull)display4Font;
    [Static]
    [Export ("display4Font")]
    [Verify (MethodToProperty)]
    UIFont Display4Font { get; }

    // +(CGFloat)display4FontOpacity;
    [Static]
    [Export ("display4FontOpacity")]
    [Verify (MethodToProperty)]
    nfloat Display4FontOpacity { get; }

    // +(UIFont * _Nonnull)display3Font;
    [Static]
    [Export ("display3Font")]
    [Verify (MethodToProperty)]
    UIFont Display3Font { get; }

    // +(CGFloat)display3FontOpacity;
    [Static]
    [Export ("display3FontOpacity")]
    [Verify (MethodToProperty)]
    nfloat Display3FontOpacity { get; }

    // +(UIFont * _Nonnull)display2Font;
    [Static]
    [Export ("display2Font")]
    [Verify (MethodToProperty)]
    UIFont Display2Font { get; }

    // +(CGFloat)display2FontOpacity;
    [Static]
    [Export ("display2FontOpacity")]
    [Verify (MethodToProperty)]
    nfloat Display2FontOpacity { get; }

    // +(UIFont * _Nonnull)display1Font;
    [Static]
    [Export ("display1Font")]
    [Verify (MethodToProperty)]
    UIFont Display1Font { get; }

    // +(CGFloat)display1FontOpacity;
    [Static]
    [Export ("display1FontOpacity")]
    [Verify (MethodToProperty)]
    nfloat Display1FontOpacity { get; }

    // +(UIFont * _Nonnull)headlineFont;
    [Static]
    [Export ("headlineFont")]
    [Verify (MethodToProperty)]
    UIFont HeadlineFont { get; }

    // +(CGFloat)headlineFontOpacity;
    [Static]
    [Export ("headlineFontOpacity")]
    [Verify (MethodToProperty)]
    nfloat HeadlineFontOpacity { get; }

    // +(UIFont * _Nonnull)titleFont;
    [Static]
    [Export ("titleFont")]
    [Verify (MethodToProperty)]
    UIFont TitleFont { get; }

    // +(CGFloat)titleFontOpacity;
    [Static]
    [Export ("titleFontOpacity")]
    [Verify (MethodToProperty)]
    nfloat TitleFontOpacity { get; }

    // +(UIFont * _Nonnull)subheadFont;
    [Static]
    [Export ("subheadFont")]
    [Verify (MethodToProperty)]
    UIFont SubheadFont { get; }

    // +(CGFloat)subheadFontOpacity;
    [Static]
    [Export ("subheadFontOpacity")]
    [Verify (MethodToProperty)]
    nfloat SubheadFontOpacity { get; }

    // +(UIFont * _Nonnull)body2Font;
    [Static]
    [Export ("body2Font")]
    [Verify (MethodToProperty)]
    UIFont Body2Font { get; }

    // +(CGFloat)body2FontOpacity;
    [Static]
    [Export ("body2FontOpacity")]
    [Verify (MethodToProperty)]
    nfloat Body2FontOpacity { get; }

    // +(UIFont * _Nonnull)body1Font;
    [Static]
    [Export ("body1Font")]
    [Verify (MethodToProperty)]
    UIFont Body1Font { get; }

    // +(CGFloat)body1FontOpacity;
    [Static]
    [Export ("body1FontOpacity")]
    [Verify (MethodToProperty)]
    nfloat Body1FontOpacity { get; }

    // +(UIFont * _Nonnull)captionFont;
    [Static]
    [Export ("captionFont")]
    [Verify (MethodToProperty)]
    UIFont CaptionFont { get; }

    // +(CGFloat)captionFontOpacity;
    [Static]
    [Export ("captionFontOpacity")]
    [Verify (MethodToProperty)]
    nfloat CaptionFontOpacity { get; }

    // +(UIFont * _Nonnull)buttonFont;
    [Static]
    [Export ("buttonFont")]
    [Verify (MethodToProperty)]
    UIFont ButtonFont { get; }

    // +(CGFloat)buttonFontOpacity;
    [Static]
    [Export ("buttonFontOpacity")]
    [Verify (MethodToProperty)]
    nfloat ButtonFontOpacity { get; }

    // +(UIFont * _Nonnull)boldFontFromFont:(UIFont * _Nonnull)font;
    [Static]
    [Export ("boldFontFromFont:")]
    UIFont BoldFontFromFont (UIFont font);

    // +(UIFont * _Nonnull)italicFontFromFont:(UIFont * _Nonnull)font;
    [Static]
    [Export ("italicFontFromFont:")]
    UIFont ItalicFontFromFont (UIFont font);

    // +(BOOL)isLargeForContrastRatios:(UIFont * _Nonnull)font;
    [Static]
    [Export ("isLargeForContrastRatios:")]
    bool IsLargeForContrastRatios (UIFont font);
}