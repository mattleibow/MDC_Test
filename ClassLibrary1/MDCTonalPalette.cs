using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCTonalPalette : INSCopying, INSSecureCoding
{
    // @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
    [Export ("colors", ArgumentSemantic.Copy)]
    UIColor[] Colors { get; }

    // @property (readonly, nonatomic) NSUInteger mainColorIndex;
    [Export ("mainColorIndex")]
    nuint MainColorIndex { get; }

    // @property (readonly, nonatomic) NSUInteger lightColorIndex;
    [Export ("lightColorIndex")]
    nuint LightColorIndex { get; }

    // @property (readonly, nonatomic) NSUInteger darkColorIndex;
    [Export ("darkColorIndex")]
    nuint DarkColorIndex { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull mainColor;
    [Export ("mainColor", ArgumentSemantic.Strong)]
    UIColor MainColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull lightColor;
    [Export ("lightColor", ArgumentSemantic.Strong)]
    UIColor LightColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull darkColor;
    [Export ("darkColor", ArgumentSemantic.Strong)]
    UIColor DarkColor { get; }

    // -(instancetype _Nonnull)initWithColors:(NSArray<UIColor *> * _Nonnull)colors mainColorIndex:(NSUInteger)mainColorIndex lightColorIndex:(NSUInteger)lightColorIndex darkColorIndex:(NSUInteger)darkColorIndex __attribute__((objc_designated_initializer));
    [Export ("initWithColors:mainColorIndex:lightColorIndex:darkColorIndex:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIColor[] colors, nuint mainColorIndex, nuint lightColorIndex, nuint darkColorIndex);

    // -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder coder);
}