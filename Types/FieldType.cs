using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Build.Shared.Types
{
    public class FieldType : Enumeration<FieldType>
    {
        private ProjectType _projectType;
        public ProjectType ProjectType { get { return _projectType; } }

        private FieldHolderType _fieldHolderType;
        public FieldHolderType FieldHolderType { get { return _fieldHolderType; } }

        private int _order;
        public int Order { get { return _order; } }

        private bool _isForClient;
        public bool IsForClient { get { return _isForClient; } }

        private bool _isProdReady;
        public bool IsProdReady {  get { return _isProdReady; } }

        private bool _defaultToDisabled;
        public bool DefaultToDisabled {  get { return _defaultToDisabled;  } }

        public Dictionary<string, string> Metadata;

        #region AppIconShared
        public static readonly AppIconFieldType AppIconSharedMaster
            = new AppIconFieldType.Shared(-1, "Shared master app icon", true, 10, false, true, false, null, 1024);

        #endregion

        #region AppIconDroid
        public static readonly AppIconFieldType AppIconDroidMaster
            = new AppIconFieldType.Droid(-5, "Droid master app icon", true, 10, false, true, false, null, 1024);
        public static readonly AppIconFieldType AppIconDroidPlaystore
            = new AppIconFieldType.Droid(-6, "Droid playstore app icon", false, 20, false, true, false, null, 1024);
        public static readonly AppIconFieldType AppIconDroidLdpi
            = new AppIconFieldType.Droid(-7, "Droid ldpi app icon", false, 30, true, true, false, new Dictionary<string, string> { { "folder", "mipmap-ldpi" } }, 36);
        public static readonly AppIconFieldType AppIconDroidMdpi
            = new AppIconFieldType.Droid(-8, "Droid mdpi app icon", false, 40, true, true, false, new Dictionary<string, string> { { "folder", "mipmap-mdpi" } }, 48);
        public static readonly AppIconFieldType AppIconDroidHdpi
        = new AppIconFieldType.Droid(-9, "Droid hdpi app icon", false, 50, true, true, false, new Dictionary<string, string> { { "folder", "mipmap-hdpi" } }, 72);
        public static readonly AppIconFieldType AppIconDroidXhdpi
        = new AppIconFieldType.Droid(-10, "Droid xhdpi app icon", false, 60, true, true, false, new Dictionary<string, string> { { "folder", "mipmap-xhdpi" } }, 96);
        public static readonly AppIconFieldType AppIconDroidXxhdpi
        = new AppIconFieldType.Droid(-11, "Droid xxhdpi app icon", false, 70, true, true, false, new Dictionary<string, string> { { "folder", "mipmap-xxhdpi" } }, 144);
        public static readonly AppIconFieldType AppIconDroidXxxhdpi
        = new AppIconFieldType.Droid(-12, "Droid xxxhdpi app icon", false, 80, true, true, false, new Dictionary<string, string> { { "folder", "mipmap-xxxhdpi" } }, 192);

        #endregion

        #region AppIconIos
        public static readonly AppIconFieldType AppIconIosMaster
        = new AppIconFieldType.Ios(-15, "Ios master app icon", true, 10, false, true, false, null, 1024);

        public static readonly AppIconFieldType AppIconIosITunesArtwork
            = new AppIconFieldType.Ios(-16, "Ios iTunesArtwork", false, 20, true, true, false
                , new Dictionary<string, string> { { "osFileName", "iTunesArtwork" } }, 512);

        public static readonly AppIconFieldType AppIconIosITunesArtwork_2x
            = new AppIconFieldType.Ios(-17, "Ios iTunesArtwork@2x", false, 30, true, true, false
                , new Dictionary<string, string> { { "osFileName", "iTunesArtwork" } }, 1024);

        public static readonly AppIconFieldType AppIconIosMarketingIcon
            = new AppIconFieldType.Ios(-18, "Ios marketing icon", false, 40, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "1024x1024"},
                                        {"idiom", "ios-marketing"},
                                        {"scale", "1x"},
                                        { "osFileName", "Icon-Marketing.png" }
                                    }, 1024);

        public static readonly AppIconFieldType AppIconIosIcon20_1x
            = new AppIconFieldType.Ios(-19, "Ios icon-20@1x", false, 50, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "20x20"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "osFileName", "Icon-20@1x.png" }
                                    }, 20);
        
        public static readonly AppIconFieldType AppIconIosIcon20_2x
            = new AppIconFieldType.Ios(-20, "Ios icon-20@2x", false, 60, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "20x20"},
                                        {"idiom", "iphone"},
                                        {"idiom2", "ipad"},
                                        {"scale", "2x"},
                                        { "osFileName", "Icon-20@2x.png" }
                                    }, 40);

        public static readonly AppIconFieldType AppIconIosIcon20_3x
            = new AppIconFieldType.Ios(-21, "Ios icon-20@3x", false, 70, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "20x20"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        { "osFileName", "Icon-20@3x.png" }
                                    }, 60);

        public static readonly AppIconFieldType AppIconIosIcon60_2x
            = new AppIconFieldType.Ios(-22, "Ios icon-60@2x", false, 80, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "60x60"},
                                        {"idiom", "iphone"},
                                        {"scale", "2x"},
                                        { "osFileName", "Icon-60@2x.png" }
                                    }, 120);
 
        public static readonly AppIconFieldType AppIconIosIcon60_3x
            = new AppIconFieldType.Ios(-23, "Ios icon-60@3x", false, 90, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "60x60"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        { "osFileName", "Icon-60@3x.png" }
                                    }, 180);
  
        public static readonly AppIconFieldType AppIconIosIcon76
            = new AppIconFieldType.Ios(-24, "Ios icon-76", false, 100, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "76x76"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "osFileName", "Icon-76.png" }
                                    }, 76);
 
        public static readonly AppIconFieldType AppIconIosIcon76_2x
            = new AppIconFieldType.Ios(-25, "Ios icon-76@2x", false, 110, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "76x76"},
                                        {"idiom", "ipad"},
                                        {"scale", "2x"},
                                        { "osFileName", "Icon-76@2x.png" }
                                    }, 152);
   
        public static readonly AppIconFieldType AppIconIosIcon83_5_2x
            = new AppIconFieldType.Ios(-26, "Ios icon-83.5@2x", false, 120, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "83.5x83.5"},
                                        {"idiom", "ipad"},
                                        {"scale", "2x"},
                                        { "osFileName", "Icon-83.5@2x.png" }
                                    }, 167);

        public static readonly AppIconFieldType AppIconIosIconSmall40
            = new AppIconFieldType.Ios(-27, "Ios icon-small-40", false, 130, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "osFileName", "Icon-Small-40.png" }
                                    }, 40);

        public static readonly AppIconFieldType AppIconIosIconSmall40_2x
            = new AppIconFieldType.Ios(-28, "Ios icon-small-40@2x", false, 140, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "iphone"},
                                        {"scale", "2x"},
                                        {"idiom2", "ipad"},
                                        { "osFileName", "Icon-Small-40@2x.png" }
                                    }, 80);

        public static readonly AppIconFieldType AppIconIosIconSmall40_3x
            = new AppIconFieldType.Ios(-29, "Ios icon-small-40@3x", false, 150, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        { "osFileName", "Icon-Small-40@3x.png" }
                                    }, 120);

        public static readonly AppIconFieldType AppIconIosIconSmall
            = new AppIconFieldType.Ios(-30, "Ios icon-small", false, 160, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "ipad"},
                                        {"scale", "1x"},
                                        { "osFileName", "Icon-Small.png" }
                                    }, 29);

        public static readonly AppIconFieldType AppIconIosIconSmall_2x
            = new AppIconFieldType.Ios(-31, "Ios icon-small@2x", false, 170, true, true, false
                                   , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "iphone"},
                                        {"scale", "2x"},
                                        {"idiom2", "ipad"},
                                        { "osFileName", "Icon-Small@2x.png" }
                                    }, 58);

        public static readonly AppIconFieldType AppIconIosIconSmall_3x
            = new AppIconFieldType.Ios(-32, "Ios icon-small@3x", false, 180, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "iphone"},
                                        {"scale", "3x"},
                                        {"idiom2", "ipad"},
                                        { "osFileName", "Icon-Small@3x.png" }
                                    }, 87);

        #region watch
        public static readonly AppIconFieldType AppIconIosAppIcon40x40_2x
            = new AppIconFieldType.Ios(-33, "Ios icon-watch-40@2x", false, 190, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "40x40"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "appLauncher" },
                                        { "subtype", "38mm" },
                                        { "osFileName", "AppIcon40x40@2x.png" }
                                    }, 80);

        public static readonly AppIconFieldType AppIconIosAppIcon44x44_2x
            = new AppIconFieldType.Ios(-34, "Ios icon-watch-44@2x", false, 200, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "44x44"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "longLook" },
                                        { "subtype", "42mm" },
                                        { "osFileName", "AppIcon44x44@2x.png" }
                                    }, 88);

        public static readonly AppIconFieldType AppIconIosAppIcon86x86_2x
            = new AppIconFieldType.Ios(-35, "Ios icon-watch-86@2x", false, 210, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "86x86"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "quickLook" },
                                        { "subtype", "38mm" },
                                        { "osFileName", "AppIcon86x86@2x.png" }
                                    }, 172);

        public static readonly AppIconFieldType AppIconIosAppIcon98x98_2x
            = new AppIconFieldType.Ios(-36, "Ios icon-watch-98@2x", false, 220, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "98x98"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "quickLook" },
                                        { "subtype", "42mm" },
                                        { "osFileName", "AppIcon98x98@2x.png" }
                                    }, 196);

        public static readonly AppIconFieldType AppIconIosAppIcon24x24_2x
            = new AppIconFieldType.Ios(-37, "Ios icon-watch-24@2x", false, 230, true, true, false
                                   , new Dictionary<string, string>{
                                        {"size", "24x24"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "notificationCenter" },
                                        { "subtype", "38mm" },
                                        { "osFileName", "AppIcon24x24@2x.png" }
                                    }, 48);

        public static readonly AppIconFieldType AppIcon27_5x27_5_2x
            = new AppIconFieldType.Ios(-38, "Ios icon-watch-27-5@2x", false, 240, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "27.5x27.5"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "notificationCenter" },
                                        { "subtype", "42mm" },
                                        { "osFileName", "AppIcon27.5x27.5@2x.png" }
                                    }, 55);

        public static readonly AppIconFieldType AppIcon29x29_2x
            = new AppIconFieldType.Ios(-39, "Ios icon-watch-29@2x", false, 250, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "watch"},
                                        {"scale", "2x"},
                                        { "role", "companionSettings" },
                                        { "osFileName", "AppIcon29x29@2x.png" }
                                    }, 58);

        public static readonly AppIconFieldType AppIcon29x29_3x
            = new AppIconFieldType.Ios(-40, "Ios icon-watch-29@3x", false, 260, true, true, false
                , new Dictionary<string, string>{
                                        {"size", "29x29"},
                                        {"idiom", "watch"},
                                        {"scale", "3x"},
                                        { "role", "companionSettings" },
                                        { "osFileName", "AppIcon29x29@3x.png" }
                                    }, 87);

        #endregion
        #endregion

        #region Packaging
        public static PackagingFieldType PackagingSharedName
            = new PackagingFieldType(-50, "Shared name", ProjectType.Shared, true, 10, false, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingSharedIdentifier
            = new PackagingFieldType(-51, "Shared identifier", ProjectType.Shared, true, 20, false, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingSharedVersionText
            = new PackagingFieldType(-52, "Shared version", ProjectType.Shared, true, 30, false, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingSharedVersionNumber
            = new PackagingFieldType(-53, "Shared version number", ProjectType.Shared, true, 40, false, true, false, StringFieldDisplayType.Number, String.Empty);


        public static PackagingFieldType PackagingDroidName
            = new PackagingFieldType(-54, "Droid name", ProjectType.Droid, true, 10, true, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingDroidIdentifier
            = new PackagingFieldType(-55, "Droid identifier", ProjectType.Droid, true, 20, true, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingDroidVersionText
            = new PackagingFieldType(-56, "Droid version", ProjectType.Droid, true, 30, true, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingDroidVersionNumber
            = new PackagingFieldType(-57, "Droid version number", ProjectType.Droid, true, 40, true, true, false, StringFieldDisplayType.Number, String.Empty);
        public static PackagingFieldType PackagingDroidAppIconName
            = new PackagingFieldType(-63, "Droid app icon name", ProjectType.Droid, false, 50, true, true, false, StringFieldDisplayType.Text, "ic_launcher");
        public static PackagingFieldType PackagingDroidSplashName
            = new PackagingFieldType(-64, "Droid splash image name", ProjectType.Droid, false, 60, true, true, false, StringFieldDisplayType.Text, "ic_splash");

        public static PackagingFieldType PackagingIosName
            = new PackagingFieldType(-58, "Ios name", ProjectType.Ios, true, 10, true, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingIosIdentifier
            = new PackagingFieldType(-59, "Ios identifier", ProjectType.Ios, true, 20, true, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingIosVersionText
            = new PackagingFieldType(-60, "Ios version", ProjectType.Ios, true, 30, true, true, false, StringFieldDisplayType.Text, String.Empty);
        public static PackagingFieldType PackagingIosVersionNumber
            = new PackagingFieldType(-61, "Ios version number", ProjectType.Ios, true, 40, true, true, false, StringFieldDisplayType.Number, String.Empty);
        public static PackagingFieldType PackagingIosAssetCatalogueName
            = new PackagingFieldType(-67, "Ios asset catalogue name", ProjectType.Ios, false, 50, true, true, false, StringFieldDisplayType.Text, "BuildAssets");
        public static PackagingFieldType PackagingIosAppIconXcAssetsName
            = new PackagingFieldType(-65, "Ios app icon xcassets name", ProjectType.Ios, false, 60, true, true, false, StringFieldDisplayType.Text, "AppIcon");
        public static PackagingFieldType PackagingIosLaunchImageXcAssetsName
            = new PackagingFieldType(-66, "Ios launch image xcassets name", ProjectType.Ios, false, 70, true, true, false, StringFieldDisplayType.Text, "Launch");
        public static PackagingFieldType PackagingIosUsesNonExemptEncryption
            = new PackagingFieldType(-62, "Ios uses non exempt encryption", ProjectType.Ios, false, 80, true, true, false, StringFieldDisplayType.Bool, "0");

        #endregion

        #region BuildConfig

        public static BuildConfigRecordSetFieldType BuildConfigFieldSetCompilerConstants
            = new BuildConfigRecordSetFieldType(-70, "Compiler constants", ProjectType.Shared, 10, true, true, false, StringFieldDisplayType.Text, String.Empty);

        #endregion

        #region SplashShared
        public static readonly SplashFieldType SplashSharedMaster
            = new SplashFieldType.Shared(-80, "Shared master splash screen", true, 10, false, true, false, null, 2048, 2048);

        #endregion

        #region SplashDroid
        public static readonly SplashFieldType SplashDroidMaster
            = new SplashFieldType.Droid(-85, "Droid master splash screen", true, 10, false, true, false, null, 2048, 2048);

        #region SplashDroidPortrait
        public static readonly SplashFieldType SplashDroidDrawable
            = new SplashFieldType.Droid(value: -1200, displayName: "Droid drawable portrait splash screen"
                , isMaster: false, order: 20, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable" }
                } , width: 480, height: 800);

        public static readonly SplashFieldType SplashDroidDrawableLdpi
            = new SplashFieldType.Droid(value: -1201, displayName: "Droid drawable portrait ldpi splash screen"
                , isMaster: false, order: 20, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-ldpi" }
                }, width: 200, height: 320);

        public static readonly SplashFieldType SplashDroidDrawableMdpi
            = new SplashFieldType.Droid(value: -1202, displayName: "Droid drawable portrait mdpi splash screen"
                , isMaster: false, order: 30, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-mdpi" }
                }, width: 320, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableHdpi
            = new SplashFieldType.Droid(value: -1203, displayName: "Droid drawable portrait hpi splash screen"
                , isMaster: false, order: 40, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-hdpi" }
                }, width: 480, height: 800);

        public static readonly SplashFieldType SplashDroidDrawableXhdpi
            = new SplashFieldType.Droid(value: -1204, displayName: "Droid drawable portrait xhdpi splash screen"
                , isMaster: false, order: 50, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-xhdpi" }
                }, width: 720, height: 1280);

        public static readonly SplashFieldType SplashDroidDrawableXxhdpi
            = new SplashFieldType.Droid(value: -1205, displayName: "Droid drawable portrait xxhdpi splash screen"
                , isMaster: false, order: 60, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-xxhdpi" }
                }, width: 960, height: 1600);

        public static readonly SplashFieldType SplashDroidDrawableXxxhdpi
            = new SplashFieldType.Droid(value: -1206, displayName: "Droid drawable portrait xxxhdpi splash screen"
                , isMaster: false, order: 70, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-xxxhdpi" }
                }, width: 1280, height: 1920);


        #endregion

        #region SplashDroidPortraitOptional
        public static readonly SplashFieldType SplashDroidDrawableSw480dpMdpi
            = new SplashFieldType.Droid(value: -1300, displayName: "Droid drawable portrait sw480dp mdpi splash screen"
                , isMaster: false, order: 200, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw480dp-mdpi" }
                }, width: 480, height: 800);

        public static readonly SplashFieldType SplashDroidDrawableSw600dpMdpi
            = new SplashFieldType.Droid(value: -1301, displayName: "Droid drawable portrait sw600dp mdpi splash screen"
                , isMaster: false, order: 210, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw600dp-mdpi" }
                }, width: 600, height: 1024);

        public static readonly SplashFieldType SplashDroidDrawableSw720dpMdpi
            = new SplashFieldType.Droid(value: -1302, displayName: "Droid drawable portrait sw720dp mdpi splash screen"
                , isMaster: false, order: 220, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw720dp-mdpi" }
                }, width: 720, height: 1280);

        public static readonly SplashFieldType SplashDroidDrawableSw800dpMdpi
            = new SplashFieldType.Droid(value: -1303, displayName: "Droid drawable portrait sw800dp mdpi splash screen"
                , isMaster: false, order: 230, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw800dp-mdpi" }
                }, width: 800, height: 1280);
        #endregion

        #region SplashDroidLandscape
        public static readonly SplashFieldType SplashDroidDrawableLand
            = new SplashFieldType.Droid(value: -1400, displayName: "Droid drawable landscape splash screen"
                , isMaster: false, order: 500, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land" }
                }, width: 800, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableLandLdpi
            = new SplashFieldType.Droid(value: -1401, displayName: "Droid drawable landscape ldpi splash screen"
                , isMaster: false, order: 510, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-ldpi" }
                }, width: 320, height: 200);

        public static readonly SplashFieldType SplashDroidDrawableLandMdpi
            = new SplashFieldType.Droid(value: -1402, displayName: "Droid drawable landscape mdpi splash screen"
                , isMaster: false, order: 520, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-mdpi" }
                }, width: 480, height: 320);

        public static readonly SplashFieldType SplashDroidDrawableLandHdpi
            = new SplashFieldType.Droid(value: -1403, displayName: "Droid drawable landscape hdpi splash screen"
                , isMaster: false, order: 530, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-hdpi" }
                }, width: 800, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableLandXhdpi
            = new SplashFieldType.Droid(value: -1404, displayName: "Droid drawable landscape xhdpi splash screen"
                , isMaster: false, order: 540, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-xhdpi" }
                }, width: 1280, height: 720);

        public static readonly SplashFieldType SplashDroidDrawableLandXxhdpi
            = new SplashFieldType.Droid(value: -1405, displayName: "Droid drawable landscape xxhdpi splash screen"
                , isMaster: false, order: 550, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-xxhdpi" }
                }, width: 1600, height: 960);

        public static readonly SplashFieldType SplashDroidDrawableLandXxxhdpi
            = new SplashFieldType.Droid(value: -1405, displayName: "Droid drawable landscape xxxhdpi splash screen"
                , isMaster: false, order: 560, isForClient: true, isProdReady: false, defaultToDisabled: false
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-land-xxxhdpi" }
                }, width: 1920, height: 1280);


        #endregion

        #region SplashDroidLandscapeOptional
        public static readonly SplashFieldType SplashDroidDrawableLandSw480dpMdpi
            = new SplashFieldType.Droid(value: -1500, displayName: "Droid drawable landscape sw480dp mdpi splash screen"
                , isMaster: false, order: 200, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw480dp-land-mdpi" }
                }, width: 800, height: 480);

        public static readonly SplashFieldType SplashDroidDrawableLandSw600dpMdpi
            = new SplashFieldType.Droid(value: -1501, displayName: "Droid drawable landscape sw600dp mdpi splash screen"
                , isMaster: false, order: 210, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw600dp-land-mdpi" }
                }, width: 1024, height: 600);

        public static readonly SplashFieldType SplashDroidDrawableLandSw720dpMdpi
            = new SplashFieldType.Droid(value: -1502, displayName: "Droid drawable landscape sw720dp mdpi splash screen"
                , isMaster: false, order: 220, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw720dp-land-mdpi" }
                }, width: 1280, height: 720);

        public static readonly SplashFieldType SplashDroidDrawableLandSw800dpMdpi
            = new SplashFieldType.Droid(value: -1503, displayName: "Droid drawable landscape sw800dp mdpi splash screen"
                , isMaster: false, order: 230, isForClient: true, isProdReady: false, defaultToDisabled: true
                , metadata: new Dictionary<string, string> {
                    { "folder", "drawable-sw800dp-land-mdpi" }
                }, width: 1280, height: 800);
        #endregion

        #endregion

        #region SplashIos

        public static readonly SplashFieldType SplashIosMaster
            = new SplashFieldType.Ios(-125, "Ios master splash screen", true, 10, false, true, false, null, 2048, 2048);

        #endregion

        protected FieldType(int value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , Dictionary<string, string> metadata = null) : base(value, displayName)
        {
            _projectType = projectType;
            _fieldHolderType = fieldHolderType;
            _isForClient = isForClient;
            Metadata = metadata;
            _order = order;
            _isProdReady = isProdReady;
            _defaultToDisabled = defaultToDisabled;
        }

        public static IEnumerable<AppIconFieldType> AppIcons()
        {
            var ret = GetAllOf<AppIconFieldType>().Where(x => x.IsProdReady == true).OrderByDescending(x => x.Order);
            return ret;
        }

        public static IEnumerable<PackagingFieldType> Packaging()
        {
            var ret = GetAllOf<PackagingFieldType>().Where(x => x.IsProdReady == true).OrderByDescending(x => x.Order);
            return ret;
        }

        public static IEnumerable<BuildConfigRecordSetFieldType> BuildConfigRecordSet()
        {
            var ret = GetAllOf<BuildConfigRecordSetFieldType>().Where(x => x.IsProdReady == true).OrderByDescending(x => x.Order);
            return ret;
        }

        public static IEnumerable<SplashFieldType> Splash()
        {
            var ret = GetAllOf<SplashFieldType>().Where(x => x.IsProdReady == true).OrderByDescending(x => x.Order);
            return ret;
        }


    }
}
