using System;
using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCThumbTrackDelegate
{
    // @optional -(NSString * _Nonnull)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack stringForValue:(CGFloat)value;
    [Export ("thumbTrack:stringForValue:")]
    string ThumbTrack (MDCThumbTrack thumbTrack, nfloat value);

    // @optional -(BOOL)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack shouldJumpToValue:(CGFloat)value;
    [Export ("thumbTrack:shouldJumpToValue:")]
    bool ThumbTrack (MDCThumbTrack thumbTrack, nfloat value);

    // @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack willJumpToValue:(CGFloat)value;
    [Export ("thumbTrack:willJumpToValue:")]
    void ThumbTrack (MDCThumbTrack thumbTrack, nfloat value);

    // @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack willAnimateToValue:(CGFloat)value;
    [Export ("thumbTrack:willAnimateToValue:")]
    void ThumbTrack (MDCThumbTrack thumbTrack, nfloat value);

    // @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack didAnimateToValue:(CGFloat)value;
    [Export ("thumbTrack:didAnimateToValue:")]
    void ThumbTrack (MDCThumbTrack thumbTrack, nfloat value);
}