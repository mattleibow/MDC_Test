using CoreAnimation;
using Foundation;

[BaseType (typeof(CALayer))]
interface MDCShadowLayer
{
    // @property (assign, nonatomic) MDCShadowElevation elevation;
    [Export ("elevation")]
    double Elevation { get; set; }

    // @property (getter = isShadowMaskEnabled, assign, nonatomic) BOOL shadowMaskEnabled;
    [Export ("shadowMaskEnabled")]
    bool ShadowMaskEnabled { [Bind ("isShadowMaskEnabled")] get; set; }
}