using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCSnackbarColorThemer))]
interface MDCSnackbarColorThemer_Deprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toSnackbarMessageView:(MDCSnackbarMessageView * _Nonnull)snackbarMessageView __attribute__((deprecated("use applySemanticColorScheme: instead.")));
    [Static]
    [Export ("applyColorScheme:toSnackbarMessageView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCSnackbarMessageView snackbarMessageView);
}