using System;
using Foundation;

[BaseType (typeof(NSObject))]
interface MDCEdgeTreatment : INSCopying
{
    // -(MDCPathGenerator * _Nonnull)pathGeneratorForEdgeWithLength:(CGFloat)length;
    [Export ("pathGeneratorForEdgeWithLength:")]
    MDCPathGenerator PathGeneratorForEdgeWithLength (nfloat length);
}