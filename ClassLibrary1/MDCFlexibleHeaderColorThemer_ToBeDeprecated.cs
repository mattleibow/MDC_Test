using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCFlexibleHeaderColorThemer))]
interface MDCFlexibleHeaderColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
    [Static]
    [Export ("applyColorScheme:toFlexibleHeaderView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCFlexibleHeaderView flexibleHeaderView);

    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toMDCFlexibleHeaderController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderController;
    [Static]
    [Export ("applyColorScheme:toMDCFlexibleHeaderController:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCFlexibleHeaderViewController flexibleHeaderController);
}