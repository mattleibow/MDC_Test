using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCButtonColorThemer))]
interface MDCButtonColorThemer_ToBeDeprecated
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
    [Static]
    [Export ("applySemanticColorScheme:toButton:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButton button);

    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlatButton:(MDCButton * _Nonnull)flatButton;
    [Static]
    [Export ("applySemanticColorScheme:toFlatButton:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButton flatButton);

    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toRaisedButton:(MDCButton * _Nonnull)raisedButton;
    [Static]
    [Export ("applySemanticColorScheme:toRaisedButton:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButton raisedButton);

    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFloatingButton:(MDCFloatingButton * _Nonnull)floatingButton;
    [Static]
    [Export ("applySemanticColorScheme:toFloatingButton:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFloatingButton floatingButton);

    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
    [Static]
    [Export ("applyColorScheme:toButton:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCButton button);
}