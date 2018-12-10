using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFlexibleHeaderColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
    [Static]
    [Export ("applySemanticColorScheme:toFlexibleHeaderView:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFlexibleHeaderView flexibleHeaderView);

    // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
    [Static]
    [Export ("applySurfaceVariantWithColorScheme:toFlexibleHeaderView:")]
    void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCFlexibleHeaderView flexibleHeaderView);
}