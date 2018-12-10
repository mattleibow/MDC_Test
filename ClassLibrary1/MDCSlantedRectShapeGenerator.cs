using System;
using Foundation;

[BaseType (typeof(NSObject))]
interface MDCSlantedRectShapeGenerator : IMDCShapeGenerating
{
    // @property (assign, nonatomic) CGFloat slant;
    [Export ("slant")]
    nfloat Slant { get; set; }
}