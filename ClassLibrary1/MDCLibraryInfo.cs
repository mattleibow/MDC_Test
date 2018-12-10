using Foundation;

[BaseType (typeof(NSObject))]
interface MDCLibraryInfo
{
    // @property (readonly, nonatomic, class) NSString * _Nonnull versionString;
    [Static]
    [Export ("versionString")]
    string VersionString { get; }
}