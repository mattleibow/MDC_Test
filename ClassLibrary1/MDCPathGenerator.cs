using System;
using CoreGraphics;
using Foundation;

[BaseType (typeof(NSObject))]
interface MDCPathGenerator
{
    // @property (readonly, nonatomic) CGPoint startPoint;
    [Export ("startPoint")]
    CGPoint StartPoint { get; }

    // @property (readonly, nonatomic) CGPoint endPoint;
    [Export ("endPoint")]
    CGPoint EndPoint { get; }

    // +(instancetype _Nonnull)pathGenerator;
    [Static]
    [Export ("pathGenerator")]
    MDCPathGenerator PathGenerator ();

    // +(instancetype _Nonnull)pathGeneratorWithStartPoint:(CGPoint)startPoint;
    [Static]
    [Export ("pathGeneratorWithStartPoint:")]
    MDCPathGenerator PathGeneratorWithStartPoint (CGPoint startPoint);

    // -(void)addLineToPoint:(CGPoint)point;
    [Export ("addLineToPoint:")]
    void AddLineToPoint (CGPoint point);

    // -(void)addArcWithCenter:(CGPoint)center radius:(CGFloat)radius startAngle:(CGFloat)startAngle endAngle:(CGFloat)endAngle clockwise:(BOOL)clockwise;
    [Export ("addArcWithCenter:radius:startAngle:endAngle:clockwise:")]
    void AddArcWithCenter (CGPoint center, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise);

    // -(void)addArcWithTangentPoint:(CGPoint)tangentPoint toPoint:(CGPoint)toPoint radius:(CGFloat)radius;
    [Export ("addArcWithTangentPoint:toPoint:radius:")]
    void AddArcWithTangentPoint (CGPoint tangentPoint, CGPoint toPoint, nfloat radius);

    // -(void)addCurveWithControlPoint1:(CGPoint)controlPoint1 controlPoint2:(CGPoint)controlPoint2 toPoint:(CGPoint)toPoint;
    [Export ("addCurveWithControlPoint1:controlPoint2:toPoint:")]
    void AddCurveWithControlPoint1 (CGPoint controlPoint1, CGPoint controlPoint2, CGPoint toPoint);

    // -(void)addQuadCurveWithControlPoint:(CGPoint)controlPoint toPoint:(CGPoint)toPoint;
    [Export ("addQuadCurveWithControlPoint:toPoint:")]
    void AddQuadCurveWithControlPoint (CGPoint controlPoint, CGPoint toPoint);

    // -(void)appendToCGPath:(CGMutablePathRef _Nonnull)cgPath transform:(CGAffineTransform * _Nullable)transform;
    [Export ("appendToCGPath:transform:")]
    unsafe void AppendToCGPath (CGMutablePathRef* cgPath, [NullAllowed] CGAffineTransform* transform);
}