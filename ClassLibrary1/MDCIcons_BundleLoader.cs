using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCIcons))]
interface MDCIcons_BundleLoader
{
    // +(NSString * _Nonnull)pathForIconName:(NSString * _Nonnull)iconName withBundleName:(NSString * _Nonnull)bundleName;
    [Static]
    [Export ("pathForIconName:withBundleName:")]
    string PathForIconName (string iconName, string bundleName);

    // +(NSBundle * _Nullable)bundleNamed:(NSString * _Nonnull)bundleName;
    [Static]
    [Export ("bundleNamed:")]
    [return: NullAllowed]
    NSBundle BundleNamed (string bundleName);
}