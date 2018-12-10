using CoreGraphics;
using Foundation;

[Protocol, Model]
interface MDCShapeGenerating : INSCopying
{
    // @required -(CGPathRef _Nullable)pathForSize:(CGSize)size;
    [Abstract]
    [Export ("pathForSize:")]
    [return: NullAllowed]
    unsafe CGPathRef* PathForSize (CGSize size);
}