using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIApplication))]
interface UIApplication_AppExtensions
{
    // +(UIApplication *)mdc_safeSharedApplication;
    [Static]
    [Export ("mdc_safeSharedApplication")]
    [Verify (MethodToProperty)]
    UIApplication Mdc_safeSharedApplication { get; }

    // +(BOOL)mdc_isAppExtension;
    [Static]
    [Export ("mdc_isAppExtension")]
    [Verify (MethodToProperty)]
    bool Mdc_isAppExtension { get; }
}