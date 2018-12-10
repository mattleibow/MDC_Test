using CoreGraphics;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCRectangleShapeGenerator : IMDCShapeGenerating
{
    // @property (nonatomic, strong) MDCCornerTreatment * topLeftCorner;
    [Export ("topLeftCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment TopLeftCorner { get; set; }

    // @property (nonatomic, strong) MDCCornerTreatment * topRightCorner;
    [Export ("topRightCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment TopRightCorner { get; set; }

    // @property (nonatomic, strong) MDCCornerTreatment * bottomLeftCorner;
    [Export ("bottomLeftCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment BottomLeftCorner { get; set; }

    // @property (nonatomic, strong) MDCCornerTreatment * bottomRightCorner;
    [Export ("bottomRightCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment BottomRightCorner { get; set; }

    // @property (assign, nonatomic) CGPoint topLeftCornerOffset;
    [Export ("topLeftCornerOffset", ArgumentSemantic.Assign)]
    CGPoint TopLeftCornerOffset { get; set; }

    // @property (assign, nonatomic) CGPoint topRightCornerOffset;
    [Export ("topRightCornerOffset", ArgumentSemantic.Assign)]
    CGPoint TopRightCornerOffset { get; set; }

    // @property (assign, nonatomic) CGPoint bottomLeftCornerOffset;
    [Export ("bottomLeftCornerOffset", ArgumentSemantic.Assign)]
    CGPoint BottomLeftCornerOffset { get; set; }

    // @property (assign, nonatomic) CGPoint bottomRightCornerOffset;
    [Export ("bottomRightCornerOffset", ArgumentSemantic.Assign)]
    CGPoint BottomRightCornerOffset { get; set; }

    // @property (nonatomic, strong) MDCEdgeTreatment * topEdge;
    [Export ("topEdge", ArgumentSemantic.Strong)]
    MDCEdgeTreatment TopEdge { get; set; }

    // @property (nonatomic, strong) MDCEdgeTreatment * rightEdge;
    [Export ("rightEdge", ArgumentSemantic.Strong)]
    MDCEdgeTreatment RightEdge { get; set; }

    // @property (nonatomic, strong) MDCEdgeTreatment * bottomEdge;
    [Export ("bottomEdge", ArgumentSemantic.Strong)]
    MDCEdgeTreatment BottomEdge { get; set; }

    // @property (nonatomic, strong) MDCEdgeTreatment * leftEdge;
    [Export ("leftEdge", ArgumentSemantic.Strong)]
    MDCEdgeTreatment LeftEdge { get; set; }

    // -(void)setCorners:(MDCCornerTreatment *)cornerShape;
    [Export ("setCorners:")]
    void SetCorners (MDCCornerTreatment cornerShape);

    // -(void)setEdges:(MDCEdgeTreatment *)edgeShape;
    [Export ("setEdges:")]
    void SetEdges (MDCEdgeTreatment edgeShape);
}