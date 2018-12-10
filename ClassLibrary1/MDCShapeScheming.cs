using Foundation;

[Protocol, Model]
interface MDCShapeScheming
{
    // @required @property (readonly, nonatomic) MDCShapeCategory * _Nonnull smallComponentShape;
    [Abstract]
    [Export ("smallComponentShape")]
    MDCShapeCategory SmallComponentShape { get; }

    // @required @property (readonly, nonatomic) MDCShapeCategory * _Nonnull mediumComponentShape;
    [Abstract]
    [Export ("mediumComponentShape")]
    MDCShapeCategory MediumComponentShape { get; }

    // @required @property (readonly, nonatomic) MDCShapeCategory * _Nonnull largeComponentShape;
    [Abstract]
    [Export ("largeComponentShape")]
    MDCShapeCategory LargeComponentShape { get; }
}