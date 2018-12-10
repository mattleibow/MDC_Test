using Foundation;

[BaseType (typeof(NSObject))]
interface MDCSnackbarFontThemer
{
    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toSnackbarMessageView:(MDCSnackbarMessageView * _Nonnull)snackbarMessageView;
    [Static]
    [Export ("applyFontScheme:toSnackbarMessageView:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, MDCSnackbarMessageView snackbarMessageView);

    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme;
    [Static]
    [Export ("applyFontScheme:")]
    void ApplyFontScheme (MDCFontScheme fontScheme);
}