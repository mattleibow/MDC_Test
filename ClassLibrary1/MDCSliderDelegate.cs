using System;
using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCSliderDelegate
{
    // @optional -(BOOL)slider:(MDCSlider * _Nonnull)slider shouldJumpToValue:(CGFloat)value;
    [Export ("slider:shouldJumpToValue:")]
    bool Slider (MDCSlider slider, nfloat value);

    // @optional -(NSString * _Nonnull)slider:(MDCSlider * _Nonnull)slider displayedStringForValue:(CGFloat)value;
    [Export ("slider:displayedStringForValue:")]
    string Slider (MDCSlider slider, nfloat value);

    // @optional -(NSString * _Nonnull)slider:(MDCSlider * _Nonnull)slider accessibilityLabelForValue:(CGFloat)value;
    [Export ("slider:accessibilityLabelForValue:")]
    string Slider (MDCSlider slider, nfloat value);
}