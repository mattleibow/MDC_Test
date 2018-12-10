using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTabBarIndicatorTemplate
{
    // @required -(MDCTabBarIndicatorAttributes * _Nonnull)indicatorAttributesForContext:(id<MDCTabBarIndicatorContext> _Nonnull)context;
    [Abstract]
    [Export ("indicatorAttributesForContext:")]
    MDCTabBarIndicatorAttributes IndicatorAttributesForContext (MDCTabBarIndicatorContext context);
}