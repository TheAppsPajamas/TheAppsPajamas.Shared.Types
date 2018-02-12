using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Build.Shared.Types
{
    public class FieldType : Enumeration<FieldType>
    {
        #region Properties
        private ProjectType _projectType;
        public ProjectType ProjectType { get { return _projectType; } }

        private FieldHolderType _fieldHolderType;
        public FieldHolderType FieldHolderType { get { return _fieldHolderType; } }

        private int _order;
        public int Order { get { return _order; } }

        private bool _isForClient;
        public bool IsForClient { get { return _isForClient; } }

        private bool _isProdReady;
        public bool IsProdReady { get { return _isProdReady; } }

        private bool _defaultToDisabled;
        public bool DefaultToDisabled { get { return _defaultToDisabled; } }

        private FieldType _inheritsFromDefault;
        public FieldType InheritsFromDefault { get { return _inheritsFromDefault; } }

        private Dictionary<string, string> _metadata;
        public Dictionary<string, string> Metadata { get { return _metadata; } }

        #endregion

        #region Fields
        #region AppIconShared
        public static readonly AppIconFieldType AppIconSharedMaster
            = new AppIconFieldType.Shared(-1, "Shared master app icon", 10, false, true, false, null, null, 1024);

        #endregion

        #region AppIconDroid
        public static readonly AppIconFieldType AppIconDroidMaster
            = new AppIconFieldType.Droid(-100, "Droid master app icon", 10, false, true, false, AppIconSharedMaster, null, 1024);
        public static readonly AppIconFieldType AppIconDroidPlaystore
            = new AppIconFieldType.Droid(-105, "Droid playstore app icon", 20, false, true, false, AppIconDroidMaster, null, 1024);
        public static readonly AppIconFieldType AppIconDroidLdpi
            = new AppIconFieldType.Droid(-110, "Droid ldpi app icon", 30, true, true, false, AppIconDroidMaster
                , new Dictionary<string, string> { { "folder", "mipmap-ldpi" } }, 36);
        public static readonly AppIconFieldType AppIconDroidMdpi
            = new AppIconFieldType.Droid(-115, "Droid mdpi app icon", 40, true, true, false, AppIconDroidMaster
                , new Dictionary<string, string> { { "folder", "mipmap-mdpi" } }, 48);
        public static readonly AppIconFieldType AppIconDroidHdpi
        = new AppIconFieldType.Droid(-120, "Droid hdpi app icon", 50, true, true, false, AppIconDroidMaster
            , new Dictionary<string, string> { { "folder", "mipmap-hdpi" } }, 72);
        public static readonly AppIconFieldType AppIconDroidXhdpi
        = new AppIconFieldType.Droid(-125, "Droid xhdpi app icon", 60, true, true, false, AppIconDroidMaster
            , new Dictionary<string, string> { { "folder", "mipmap-xhdpi" } }, 96);
        public static readonly AppIconFieldType AppIconDroidXxhdpi
        = new AppIconFieldType.Droid(-130, "Droid xxhdpi app icon", 70, true, true, false, AppIconDroidMaster
            , new Dictionary<string, string> { { "folder", "mipmap-xxhdpi" } }, 144);
        public static readonly AppIconFieldType AppIconDroidXxxhdpi
        = new AppIconFieldType.Droid(-135, "Droid xxxhdpi app icon", 80, true, true, false, AppIconDroidMaster
            , new Dictionary<string, string> { { "folder", "mipmap-xxxhdpi" } }, 192);

        #endregion

        #region AppIconIos
        public static readonly AppIconFieldType AppIconIosMaster
        = new AppIconFieldType.Ios(-200, "Ios master app icon", 10, false, true, false, AppIconSharedMaster, null, 1024);

        public static readonly AppIconFieldType AppIconIosITunesArtwork
            = new AppIconFieldType.Ios(-205, "Ios iTunesArtwork", 20, true, true, false, AppIconIosMaster
                , new Dictionary<string, string> { { "filename", "iTunesArtwork" } }, 512);

        public static readonly AppIconFieldType AppIconIosITunesArtwork_2x
            = new AppIconFieldType.Ios(-210, "Ios iTunesArtwork@2x", 30, true, true, false, AppIconIosMaster
                , new Dictionary<string, string> { { "filename", "iTunesArtwork@2x" } }, 1024);

        public static readonly AppIconFieldType AppIconIosMarketingIcon
            = new AppIconFieldType.Ios(-215, "Ios marketing icon", 40, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "1024x1024"},
                                        {"idiom", "ios-marketing"},
                                        {"scale", "1x"},
                                        { "filename", "Icon-Marketing.png" }
                                    }, 1024);

        public static readonly AppIconFieldType AppIconIosIcon20_1x
            = new AppIconFieldType.Ios(-220, "Ios icon-20@1x", 50, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "20x20"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "filename", "Icon-20@1x.png" }
                                    }, 20);

        public static readonly AppIconFieldType AppIconIosIcon20_2x
            = new AppIconFieldType.Ios(-225, "Ios icon-20@2x", 60, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "20x20"},
                                        {"idiom", "iphone"},
                                        {"idiom2", "ipad"},
                                        {"scale", "2x"},
                                        { "filename", "Icon-20@2x.png" }
                                    }, 40);

        public static readonly AppIconFieldType AppIconIosIcon20_3x
            = new AppIconFieldType.Ios(-230, "Ios icon-20@3x", 70, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "20x20"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        { "filename", "Icon-20@3x.png" }
                                    }, 60);

        public static readonly AppIconFieldType AppIconIosIcon60_2x
            = new AppIconFieldType.Ios(-235, "Ios icon-60@2x", 80, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "60x60"},
                                        {"idiom", "iphone"},
                                        {"scale", "2x"},
                                        { "filename", "Icon-60@2x.png" }
                                    }, 120);

        public static readonly AppIconFieldType AppIconIosIcon60_3x
            = new AppIconFieldType.Ios(-240, "Ios icon-60@3x", 90, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "60x60"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        { "filename", "Icon-60@3x.png" }
                                    }, 180);

        public static readonly AppIconFieldType AppIconIosIcon76
            = new AppIconFieldType.Ios(-245, "Ios icon-76", 100, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "76x76"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "filename", "Icon-76.png" }
                                    }, 76);

        public static readonly AppIconFieldType AppIconIosIcon76_2x
            = new AppIconFieldType.Ios(-250, "Ios icon-76@2x", 110, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "76x76"},
                                        {"idiom", "ipad"},
                                        {"scale", "2x"},
                                        { "filename", "Icon-76@2x.png" }
                                    }, 152);

        public static readonly AppIconFieldType AppIconIosIcon83_5_2x
            = new AppIconFieldType.Ios(-255, "Ios icon-83.5@2x", 120, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "83.5x83.5"},
                                        {"idiom", "ipad"},
                                        {"scale", "2x"},
                                        { "filename", "Icon-83.5@2x.png" }
                                    }, 167);

        public static readonly AppIconFieldType AppIconIosIconSmall40
            = new AppIconFieldType.Ios(-260, "Ios icon-small-40", 130, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "filename", "Icon-Small-40.png" }
                                    }, 40);

        public static readonly AppIconFieldType AppIconIosIconSmall40_2x
            = new AppIconFieldType.Ios(-265, "Ios icon-small-40@2x", 140, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "iphone"},
                                        {"scale", "2x"},
                                        {"idiom2", "ipad"},
                                        { "filename", "Icon-Small-40@2x.png" }
                                    }, 80);

        public static readonly AppIconFieldType AppIconIosIconSmall40_3x
            = new AppIconFieldType.Ios(-270, "Ios icon-small-40@3x", 150, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        { "filename", "Icon-Small-40@3x.png" }
                                    }, 120);

        public static readonly AppIconFieldType AppIconIosIconSmall
            = new AppIconFieldType.Ios(-275, "Ios icon-small", 160, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "filename", "Icon-Small.png" }
                                    }, 29);

        public static readonly AppIconFieldType AppIconIosIconSmall_2x
            = new AppIconFieldType.Ios(-280, "Ios icon-small@2x", 170, true, true, false, AppIconIosMaster
                                   , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "iphone"},
                                        {"scale", "2x"},
                                        {"idiom2", "ipad"},
                                        { "filename", "Icon-Small@2x.png" }
                                    }, 58);

        public static readonly AppIconFieldType AppIconIosIconSmall_3x
            = new AppIconFieldType.Ios(-285, "Ios icon-small@3x", 180, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        {"idiom2", "ipad"},
                                        { "filename", "Icon-Small@3x.png" }
                                    }, 87);

        #region watch
        public static readonly AppIconFieldType AppIconIosAppIcon40x40_2x
            = new AppIconFieldType.Ios(-300, "Ios icon-watch-40@2x", 190, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "appLauncher" },
                                        { "subtype", "38mm" },
                                        { "filename", "AppIcon40x40@2x.png" }
                                    }, 80);

        public static readonly AppIconFieldType AppIconIosAppIcon44x44_2x
            = new AppIconFieldType.Ios(-305, "Ios icon-watch-44@2x", 200, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "44x44"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "longLook" },
                                        { "subtype", "42mm" },
                                        { "filename", "AppIcon44x44@2x.png" }
                                    }, 88);

        public static readonly AppIconFieldType AppIconIosAppIcon86x86_2x
            = new AppIconFieldType.Ios(-310, "Ios icon-watch-86@2x", 210, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "86x86"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "quickLook" },
                                        { "subtype", "38mm" },
                                        { "filename", "AppIcon86x86@2x.png" }
                                    }, 172);

        public static readonly AppIconFieldType AppIconIosAppIcon98x98_2x
            = new AppIconFieldType.Ios(-315, "Ios icon-watch-98@2x", 220, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "98x98"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "quickLook" },
                                        { "subtype", "42mm" },
                                        { "filename", "AppIcon98x98@2x.png" }
                                    }, 196);

        public static readonly AppIconFieldType AppIconIosAppIcon24x24_2x
            = new AppIconFieldType.Ios(-320, "Ios icon-watch-24@2x", 230, true, true, false, AppIconIosMaster
                                   , new Dictionary<string, string>{
                                        {"size", "24x24"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "notificationCenter" },
                                        { "subtype", "38mm" },
                                        { "filename", "AppIcon24x24@2x.png" }
                                    }, 48);

        public static readonly AppIconFieldType AppIcon27_5x27_5_2x
            = new AppIconFieldType.Ios(-325, "Ios icon-watch-27-5@2x", 240, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "27.5x27.5"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "notificationCenter" },
                                        { "subtype", "42mm" },
                                        { "filename", "AppIcon27.5x27.5@2x.png" }
                                    }, 55);

        public static readonly AppIconFieldType AppIcon29x29_2x
            = new AppIconFieldType.Ios(-330, "Ios icon-watch-29@2x", 250, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "companionSettings" },
                                        { "filename", "AppIcon29x29@2x.png" }
                                    }, 58);

        public static readonly AppIconFieldType AppIcon29x29_3x
            = new AppIconFieldType.Ios(-335, "Ios icon-watch-29@3x", 260, true, true, false, AppIconIosMaster
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "watch"},
                                        {"scale", "3x"},
                                        { "role", "companionSettings" },
                                        { "filename", "AppIcon29x29@3x.png" }
                                    }, 87);

        #endregion
        #endregion

        #region Packaging
        public static PackagingFieldType PackagingSharedName
            = new PackagingFieldType(-1000, "Shared name", ProjectType.Shared, 10, false, true, false, null, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingSharedIdentifier
            = new PackagingFieldType(-1005, "Shared identifier", ProjectType.Shared, 20, false, true, false, null, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingSharedVersionText
            = new PackagingFieldType(-1010, "Shared version", ProjectType.Shared, 30, false, true, false, null, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingSharedVersionNumber
            = new PackagingFieldType(-1015, "Shared version number", ProjectType.Shared, 40, false, true, false, null, StringFieldDisplayType.Number, String.Empty);


        public static PackagingFieldType PackagingDroidName
            = new PackagingFieldType(-1100, "Droid name", ProjectType.Droid, 10, true, true, false, PackagingSharedName, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingDroidIdentifier
            = new PackagingFieldType(-1105, "Droid identifier", ProjectType.Droid, 20, true, true, false, PackagingSharedIdentifier, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingDroidVersionText
            = new PackagingFieldType(-1110, "Droid version", ProjectType.Droid, 30, true, true, false, PackagingSharedVersionText, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingDroidVersionNumber
            = new PackagingFieldType(-1115, "Droid version number", ProjectType.Droid, 40, true, true, false, PackagingSharedVersionNumber, StringFieldDisplayType.Number, String.Empty);
        public static PackagingFieldType PackagingDroidAppIconName
            = new PackagingFieldType(-1120, "Droid app icon name", ProjectType.Droid, 50, true, true, false, null, StringFieldDisplayType.Text, "ic_launcher");
        public static PackagingFieldType PackagingDroidSplashName
            = new PackagingFieldType(-1125, "Droid splash image name", ProjectType.Droid, 60, true, true, false, null, StringFieldDisplayType.Text, "ic_splash");

        public static PackagingFieldType PackagingIosName
            = new PackagingFieldType(-1200, "Ios name", ProjectType.Ios, 10, true, true, false, PackagingSharedName, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingIosIdentifier
            = new PackagingFieldType(-1205, "Ios identifier", ProjectType.Ios, 20, true, true, false, PackagingSharedIdentifier, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingIosVersionText
            = new PackagingFieldType(-1210, "Ios version", ProjectType.Ios, 30, true, true, false, PackagingSharedVersionText, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingIosVersionNumber
            = new PackagingFieldType(-1215, "Ios version number", ProjectType.Ios, 40, true, true, false, PackagingSharedVersionNumber, StringFieldDisplayType.Number, String.Empty);
        public static PackagingFieldType PackagingIosAssetCatalogueName
            = new PackagingFieldType(-1220, "Ios asset catalogue name", ProjectType.Ios, 50, true, true, false, null, StringFieldDisplayType.Text, "theappspajamas");

        public static PackagingFieldType PackagingIosAppIconXcAssetsName
            = new PackagingFieldType(-1225, "Ios app icon xcassets name", ProjectType.Ios, 60, true, true, false, null, StringFieldDisplayType.Text, "AppIcon");

        public static PackagingFieldType PackagingIosUseLaunchStoryboard
            = new PackagingFieldType(-1230, "Ios use launch storyboard", ProjectType.Ios, 70, true, true, false, null, StringFieldDisplayType.Bool, "0");
        public static PackagingFieldType PackagingIosLaunchStoryboardName
            = new PackagingFieldType(-1235, "Ios launch storyboard name", ProjectType.Ios, 80, true, true, false, null, StringFieldDisplayType.Text, "LaunchScreen");
        public static PackagingFieldType PackagingIosLaunchStoryboardPortraitXcAssetsName
            = new PackagingFieldType(-1240, "Ios portrait launch storyboard xcassets name", ProjectType.Ios, 90, true, true, false, null, StringFieldDisplayType.Text, "LaunchScreenPortrait");
        public static PackagingFieldType PackagingIosLaunchStoryboardLandscapeXcAssetsName
            = new PackagingFieldType(-1245, "Ios landscape launch storyboard xcassets name", ProjectType.Ios, 100, true, true, false, null, StringFieldDisplayType.Text, "LaunchScreenLandscape");
        public static PackagingFieldType PackagingIosLaunchImageXcAssetsName
            = new PackagingFieldType(-1250, "Ios launch image xcassets name", ProjectType.Ios, 110, true, true, false, null, StringFieldDisplayType.Text, "Launch");
        public static PackagingFieldType PackagingIosUsesNonExemptEncryption
            = new PackagingFieldType(-1255, "Ios uses non exempt encryption", ProjectType.Ios, 120, true, true, false, null, StringFieldDisplayType.Bool, "0");

        #endregion

        #region BuildConfig

        public static BuildConfigRecordSetFieldType BuildConfigFieldSetCompilerConstants
            = new BuildConfigRecordSetFieldType(-2000, "Compiler constants", ProjectType.Shared, 10, true, true, false, StringFieldDisplayType.Text, String.Empty);

        #endregion

        #region SplashShared
        public static readonly SplashFieldType SplashSharedMaster
           = new SplashFieldType.Shared(value: -3000, displayName: "Shared master portrait splash screen"
                , order: 10, isForClient: false, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: null
                , metadata: null
                , width: 2048, height: 2048);

        public static readonly SplashFieldType SplashSharedMasterLand
           = new SplashFieldType.Shared(value: -3010, displayName: "Shared master landscape splash screen"
                , order: 20, isForClient: false, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashSharedMaster
                , metadata: null
                , width: 2048, height: 2048);

        #endregion

        #region SplashDroid

        #region SplashDroidMaster
        public static readonly SplashFieldType SplashDroidMaster
            = new SplashFieldType.Droid(value: -3100, displayName: "Droid master portrait splash screen"
                , order: 10, isForClient: false, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashSharedMaster
                , metadata: null
                , width: 2048, height: 2048);

        public static readonly SplashFieldType SplashDroidMasterLand
            = new SplashFieldType.Droid(value: -3105, displayName: "Droid master landscape splash screen"
                , order: 20, isForClient: false, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashSharedMasterLand
                , metadata: null
                , width: 2048, height: 2048);
        #endregion

        #region SplashDroidPortrait
        public static readonly SplashFieldType SplashDroidDrawable
            = new SplashFieldType.Droid(value: -3200, displayName: "Droid drawable portrait splash screen"
                , order: 30, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable" }
                }, width: 480, height: 800);

        public static readonly SplashFieldType SplashDroidDrawableLdpi
            = new SplashFieldType.Droid(value: -3205, displayName: "Droid drawable portrait ldpi splash screen"
                , order: 40, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-ldpi" }
                }, width: 200, height: 320);

        public static readonly SplashFieldType SplashDroidDrawableMdpi
            = new SplashFieldType.Droid(value: -3210, displayName: "Droid drawable portrait mdpi splash screen"
                , order: 50, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-mdpi" }
                }, width: 320, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableHdpi
            = new SplashFieldType.Droid(value: -3215, displayName: "Droid drawable portrait hpi splash screen"
                , order: 60, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-hdpi" }
                }, width: 480, height: 800);

        public static readonly SplashFieldType SplashDroidDrawableXhdpi
            = new SplashFieldType.Droid(value: -3220, displayName: "Droid drawable portrait xhdpi splash screen"
                , order: 70, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-xhdpi" }
                }, width: 720, height: 1280);

        public static readonly SplashFieldType SplashDroidDrawableXxhdpi
            = new SplashFieldType.Droid(value: -3225, displayName: "Droid drawable portrait xxhdpi splash screen"
                , order: 80, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-xxhdpi" }
                }, width: 960, height: 1600);

        public static readonly SplashFieldType SplashDroidDrawableXxxhdpi
            = new SplashFieldType.Droid(value: -3230, displayName: "Droid drawable portrait xxxhdpi splash screen"
                , order: 90, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-xxxhdpi" }
                }, width: 1280, height: 1920);


        #endregion

        #region SplashDroidLandscape
        public static readonly SplashFieldType SplashDroidDrawableLand
            = new SplashFieldType.Droid(value: -3400, displayName: "Droid drawable landscape splash screen"
                , order: 210, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land" }
                }, width: 800, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableLandLdpi
            = new SplashFieldType.Droid(value: -3405, displayName: "Droid drawable landscape ldpi splash screen"
                , order: 220, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-ldpi" }
                }, width: 320, height: 200);

        public static readonly SplashFieldType SplashDroidDrawableLandMdpi
            = new SplashFieldType.Droid(value: -3410, displayName: "Droid drawable landscape mdpi splash screen"
                , order: 230, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-mdpi" }
                }, width: 480, height: 320);

        public static readonly SplashFieldType SplashDroidDrawableLandHdpi
            = new SplashFieldType.Droid(value: -3415, displayName: "Droid drawable landscape hdpi splash screen"
                , order: 240, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-hdpi" }
                }, width: 800, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableLandXhdpi
            = new SplashFieldType.Droid(value: -3420, displayName: "Droid drawable landscape xhdpi splash screen"
                , order: 250, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-xhdpi" }
                }, width: 1280, height: 720);

        public static readonly SplashFieldType SplashDroidDrawableLandXxhdpi
            = new SplashFieldType.Droid(value: -3425, displayName: "Droid drawable landscape xxhdpi splash screen"
                , order: 260, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-xxhdpi" }
                }, width: 1600, height: 960);

        public static readonly SplashFieldType SplashDroidDrawableLandXxxhdpi
            = new SplashFieldType.Droid(value: -3430, displayName: "Droid drawable landscape xxxhdpi splash screen"
                , order: 270, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-xxxhdpi" }
                }, width: 1920, height: 1280);

        #endregion

        #region SplashDroidPortraitOptional
        public static readonly SplashFieldType SplashDroidDrawableSw480dpMdpi
            = new SplashFieldType.Droid(value: -3300, displayName: "Droid drawable portrait sw480dp mdpi splash screen"
                , order: 410, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw480dp-mdpi" }
                }, width: 480, height: 800);

        public static readonly SplashFieldType SplashDroidDrawableSw600dpMdpi
            = new SplashFieldType.Droid(value: -3305, displayName: "Droid drawable portrait sw600dp mdpi splash screen"
                , order: 420, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw600dp-mdpi" }
                }, width: 600, height: 1024);

        public static readonly SplashFieldType SplashDroidDrawableSw720dpMdpi
            = new SplashFieldType.Droid(value: -3310, displayName: "Droid drawable portrait sw720dp mdpi splash screen"
                , order: 430, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw720dp-mdpi" }
                }, width: 720, height: 1280);

        public static readonly SplashFieldType SplashDroidDrawableSw800dpMdpi
            = new SplashFieldType.Droid(value: -3315, displayName: "Droid drawable portrait sw800dp mdpi splash screen"
                , order: 440, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashDroidMaster
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw800dp-mdpi" }
                }, width: 800, height: 1280);
        #endregion

        #region SplashDroidLandscapeOptional
        public static readonly SplashFieldType SplashDroidDrawableLandSw480dpMdpi
            = new SplashFieldType.Droid(value: -3500, displayName: "Droid drawable landscape sw480dp mdpi splash screen"
                , order: 610, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw480dp-land-mdpi" }
                }, width: 800, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableLandSw600dpMdpi
            = new SplashFieldType.Droid(value: -3505, displayName: "Droid drawable landscape sw600dp mdpi splash screen"
                , order: 620, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw600dp-land-mdpi" }
                }, width: 1024, height: 600);

        public static readonly SplashFieldType SplashDroidDrawableLandSw720dpMdpi
            = new SplashFieldType.Droid(value: -3510, displayName: "Droid drawable landscape sw720dp mdpi splash screen"
                , order: 630, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw720dp-land-mdpi" }
                }, width: 1280, height: 720);

        public static readonly SplashFieldType SplashDroidDrawableLandSw800dpMdpi
            = new SplashFieldType.Droid(value: -3515, displayName: "Droid drawable landscape sw800dp mdpi splash screen"
                , order: 640, isForClient: true, isProdReady: true, defaultToDisabled: true
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashDroidMasterLand
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw800dp-land-mdpi" }
                }, width: 1280, height: 800);
        #endregion

        #endregion

        #region SplashIos
        //TODO this might need a scale type / crop or strech, because these ones would need to shrink down to aspect ratio lower to get to @1x (for example)
        public static readonly SplashFieldType SplashIosStoryboard_3x
            = new SplashFieldType.Ios(value: -3600, displayName: "Ios launch storyboard portrait splash screen"
                , order: 10, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Portrait
                , inheritsFromDefault: SplashSharedMaster
                , metadata: new Dictionary<string, string>{
                         { "idiom" , "universal" },
                         { "scale" , "3x" }
                }, width: 2048, height: 2048);

        public static readonly SplashFieldType SplashIosMasterLand_3x
            = new SplashFieldType.Ios(value: -3605, displayName: "Ios launch storyboard landscape splash screen"
                , order: 20, isForClient: true, isProdReady: true, defaultToDisabled: false
                , mediaOrientationType: MediaOrientationType.Landscape
                , inheritsFromDefault: SplashSharedMasterLand
                //filename specified by packaging
                , metadata: new Dictionary<string, string>{
                         { "idiom" , "universal" },
                         { "scale" , "3x" }
                }, width: 2048, height: 2048);

        #endregion

        #region SplashIosPortrait
        public static readonly SplashFieldType SplashIosIphone
              = new SplashFieldType.Ios(value: -3700, displayName: "Ios iPhone (iOS 5, 6) portrait splash screen"
                  , order: 30, isForClient: true, isProdReady: true, defaultToDisabled: false
                  , mediaOrientationType: MediaOrientationType.Portrait
                  , inheritsFromDefault: SplashIosStoryboard_3x
                  , metadata: new Dictionary<string, string>{
                         { "orientation" , "portrait" },
                         { "idiom" , "iphone" },
                         { "size", "320x480" },
                         { "filename" , "LaunchImage~iphone.png" },
                         { "extent" , "full-screen" },
                         { "scale" , "1x" }
                  }, width: 320, height: 480);

        public static readonly SplashFieldType SplashIosIphone_2x
             = new SplashFieldType.Ios(value: -3705, displayName: "Ios iPhone@2x (iOS 5, 6) portrait splash screen"
                 , order: 40, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "portrait" },
                     { "idiom" , "iphone" },
                     { "size", "320x480" },
                     { "filename" , "LaunchImage@2x~iphone.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "2x" }
                 }, width: 640, height: 960);

        public static readonly SplashFieldType SplashIos700_2x
             = new SplashFieldType.Ios(value: -3710, displayName: "Ios 700@2x portrait splash screen"
                 , order: 50, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "fileName", "LaunchImage-700-Portrait@2x~iphone.png" },
                     { "size", "320x480" },
                     { "scale", "2x" },
                     { "idiom", "iphone" }
                 }, width: 320, height: 480);

        public static readonly SplashFieldType SplashIos568h_2x
             = new SplashFieldType.Ios(value: -3715, displayName: "Ios 568h@2x (iPhone Retina 4 inch) portrait splash screen"
                 , order: 60, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "fileName", "LaunchImage-Portrait-568h@2x.png" },
                     { "size", "320x568" },
                     { "subtype", "retina4" },
                     { "scale", "2x" },
                     { "idiom", "iphone" }
                 }, width: 640, height: 1136);

        public static readonly SplashFieldType SplashIos568h_3x
             = new SplashFieldType.Ios(value: -3720, displayName: "Ios 568h@3x (iPhone Retina 4 inch) portrait splash screen"
                 , order: 70, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "fileName", "LaunchImage-Portrait-568h@3x.png" },
                     { "size", "320x568" },
                     { "subtype", "retina4" },
                     { "scale", "2x" },
                     { "idiom", "iphone" }
                 }, width: 640, height: 1136);

        public static readonly SplashFieldType SplashIos667h_2x
             = new SplashFieldType.Ios(value: -3725, displayName: "Ios 667h@2x (iPhone 6) portrait splash screen"
                 , order: 80, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "8.0" },
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "filename", "LaunchImage-Portrait-667h@2x.png" },
                     { "size", "375x667" },
                     { "subtype", "667h" },
                     { "scale", "2x" },
                     { "idiom", "iphone" }
                 }, width: 750, height: 1134);

        public static readonly SplashFieldType SplashIos736h_3x
             = new SplashFieldType.Ios(value: -3730, displayName: "Ios 736h@3x (iPhone 6plus) portrait splash screen"
                 , order: 90, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "8.0" },
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "filename", "LaunchImage-Portrait-736h@3x.png" },
                     { "size", "414x736" },
                     { "subtype", "736h" },
                     { "scale", "3x" },
                     { "idiom", "iphone" }
                 }, width: 1242, height: 2208);



        public static readonly SplashFieldType SplashIosIpad_1x
             = new SplashFieldType.Ios(value: -3735, displayName: "Ios iPad@1x portrait splash screen"
                 , order: 100, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "filename", "LaunchImage-Portrait~ipad.png" },
                     { "size", "768x1024" },
                     { "scale", "1x" },
                     { "idiom", "ipad" }
                 }, width: 768, height: 1024);


        public static readonly SplashFieldType SplashIosIpad700_1x
             = new SplashFieldType.Ios(value: -3740, displayName: "Ios iPad@1x (iOS 7+) portrait splash screen"
                 , order: 110, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "filename", "LaunchImage-700-Portrait~ipad.png" },
                     { "size", "768x1024" },
                     { "scale", "1x" },
                     { "idiom", "ipad" }
                 }, width: 768, height: 1024);

        public static readonly SplashFieldType SplashIosIpad_2x
             = new SplashFieldType.Ios(value: -3745, displayName: "Ios iPad@2x portrait splash screen"
                 , order: 120, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "filename", "LaunchImage-Portrait@2x~ipad.png" },
                     { "size", "768x1024" },
                     { "scale", "2x" },
                     { "idiom", "ipad" }
                 }, width: 1536, height: 2048);

        public static readonly SplashFieldType SplashIosIpad700_2x
             = new SplashFieldType.Ios(value: -3750, displayName: "Ios iPad@2x (iOS 7+) portrait splash screen"
                 , order: 130, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation", "portrait" },
                     { "extent", "full-screen" },
                     { "filename", "LaunchImage-700-Portrait@2x~ipad.png" },
                     { "size", "768x1024" },
                     { "scale", "2x" },
                     { "idiom", "ipad" }
                 }, width: 1536, height: 2048);

        public static readonly SplashFieldType SplashIosIpad_1xNoStatusBar
             = new SplashFieldType.Ios(value: -3755, displayName: "Ios iPad@1x portrait without status bar splash screen"
                 , order: 140, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "portrait" },
                     { "idiom" , "ipad" },
                     { "filename" , "LaunchImage~ipad.png" },
                     { "extent" , "to-status-bar" },
                     { "minimum-system-version", "7.0" },
                     { "scale" , "1x" }
                 }, width: 768, height: 1004);

        public static readonly SplashFieldType SplashIosIpad_2xNoStatusBar
             = new SplashFieldType.Ios(value: -3760, displayName: "Ios iPad@2x portrait splash screen"
                 , order: 150, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Portrait
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "portrait" },
                     { "idiom" , "iphone" },
                     { "filename" , "LaunchImage@2x~ipad.png" },
                     { "minimum-system-version", "7.0" },
                     { "extent" , "full-screen" },
                     { "scale" , "2x" }
                 }, width: 1536, height: 2008);



        public static readonly SplashFieldType SplashIosIpadPro_2x
             = new SplashFieldType.Ios(value: -3765, displayName: "Ios iPadPro@2x (12\") portrait splash screen"
                 , order: 160, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation" , "portrait" },
                     { "idiom" , "ipad" },
                     { "size", "1024x1366" },
                     { "filename" , "LaunchImage-Portrait~ipad@2x_2048x2732.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "2x" }
                 }, width: 2048, height: 2732);


        #endregion

        #region SplashIosLandscape
        public static readonly SplashFieldType SplashIosIphoneLand_3x
             = new SplashFieldType.Ios(value: -3800, displayName: "Ios iPhone@3x (iPhone 6plus) landscape splash screen"
                 , order: 300, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "8.0" },
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "736x414" },
                     { "filename" , "LaunchImage-800-Landscape-736h@3x.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "3x" }
                 }, width: 2208, height: 1242);

        public static readonly SplashFieldType SplashIosIpadLand_1x
             = new SplashFieldType.Ios(value: -3805, displayName: "Ios iPad@1x (iOS 5, 6) landscape splash screen"
                 , order: 310, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "1024x768" },
                     { "filename" , "LaunchImage-Landscape~ipad_1024x768.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "1x" }
                 }, width: 1024, height: 768);

        public static readonly SplashFieldType SplashIosIpadLand_2x
             = new SplashFieldType.Ios(value: -3810, displayName: "Ios iPad@2x (iOS 5, 6) landscape splash screen"
                 , order: 320, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "1024x768" },
                     { "filename" , "LaunchImage-Landscape~ipad_2048x1536.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "2x" }
                 }, width: 2048, height: 1536);




        public static readonly SplashFieldType SplashIosIpad700Land_2x
             = new SplashFieldType.Ios(value: -3815, displayName: "Ios iPad@2x (iOS 7-10) landscape splash screen"
                 , order: 330, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "1024x768" },
                     { "filename" , "LaunchImage-700-Landscape~ipad_2048x1536.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "2x" }
                 }, width: 2048, height: 1536);

        public static readonly SplashFieldType SplashIosIpad700Land_1x
             = new SplashFieldType.Ios(value: -3820, displayName: "Ios iPad@1x (iOS 7-10) landscape splash screen"
                 , order: 340, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "7.0" },
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "1024x768" },
                     { "filename" , "LaunchImage-700-Landscape~ipad_1024x768.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "1x" }
                 }, width: 1024, height: 768);

        public static readonly SplashFieldType SplashIosIpadLand_1xNoStatusBar
             = new SplashFieldType.Ios(value: -3825, displayName: "Ios iPad@1x (iOS 5, 6) landscape without status bar splash screen"
                 , order: 350, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "1024x748" },
                     { "filename" , "LaunchImage-Landscape~ipad_1024x748.png" },
                     { "extent" , "to-status-bar" },
                     { "scale" , "1x" }
                 }, width: 1024, height: 748);

        public static readonly SplashFieldType SplashIosIpadLand_2xNoStatusBar
             = new SplashFieldType.Ios(value: -3830, displayName: "Ios iPad@2x (iOS 5, 6) landscape without status bar splash screen"
                 , order: 360, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "orientation" , "landscape" },
                     { "idiom" , "ipad" },
                     { "size", "1024x748" },
                     { "filename" , "LaunchImage-Landscape@2x~ipad_2048x1496.png" },
                     { "extent" , "to-status-bar" },
                     { "scale" , "2x" }
                 }, width: 2048, height: 1496);

        public static readonly SplashFieldType SplashIosAppleTv
             = new SplashFieldType.Ios(value: -3835, displayName: "Ios Apple TV landscape splash screen"
                 , order: 370, isForClient: true, isProdReady: true, defaultToDisabled: false
                 , mediaOrientationType: MediaOrientationType.Landscape
                 , inheritsFromDefault: SplashIosStoryboard_3x
                 , metadata: new Dictionary<string, string>{
                     { "minimum-system-version", "9.0" },
                     { "orientation" , "landscape" },
                     { "idiom" , "tv" },
                     { "size", "1920x1080" },
                     { "filename" , "LaunchImage~tv.png" },
                     { "extent" , "full-screen" },
                     { "scale" , "1x" }
                 }, width: 1920, height: 1080);

        #endregion

        #endregion

        #region Constructor
        protected FieldType(int value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , FieldType inheritsFromDefault
            , Dictionary<string, string> metadata = null) : base(value, displayName)
        {
            _projectType = projectType;
            _fieldHolderType = fieldHolderType;
            _isForClient = isForClient;
            _metadata = metadata;
            _order = order;
            _isProdReady = isProdReady;
            _defaultToDisabled = defaultToDisabled;
            _inheritsFromDefault = inheritsFromDefault;
        }
        #endregion

        #region Helpers
        public static IEnumerable<AppIconFieldType> AppIcons()
        {
            var ret = GetAllOf<AppIconFieldType>().Where(x => x.IsProdReady == true).OrderBy(x => x.Order);
            return ret;
        }

        public static IEnumerable<PackagingFieldType> Packaging()
        {
            var ret = GetAllOf<PackagingFieldType>().Where(x => x.IsProdReady == true).OrderBy(x => x.Order);
            return ret;
        }

        public static IEnumerable<BuildConfigRecordSetFieldType> BuildConfigRecordSet()
        {
            var ret = GetAllOf<BuildConfigRecordSetFieldType>().Where(x => x.IsProdReady == true).OrderBy(x => x.Order);
            return ret;
        }

        public static IEnumerable<SplashFieldType> Splash()
        {
            var ret = GetAllOf<SplashFieldType>().Where(x => x.IsProdReady == true).OrderBy(x => x.Order);
            return ret;
        }
        #endregion

    }
}
