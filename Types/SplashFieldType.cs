using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class SplashFieldType : MasterMediaFieldType
    {
        private MediaOrientationType _mediaOrientationType;
        public MediaOrientationType MediaOrientationType {  get { return _mediaOrientationType;  } }

        private SplashFieldType _inheritsFromDefault;
        public SplashFieldType InheritsFromDefault;

        public SplashFieldType(int value
            , string displayName
            , ProjectType projectType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , MediaOrientationType mediaOrientationType
            , SplashFieldType inheritsFromDefault
            , Dictionary<string, string> metadata
            , int width
            , int height)
                : base(value: value
                      , displayName: displayName
                      , projectType: projectType
                      , fieldHolderType: FieldHolderType.Splash
                      , order: order
                      , isForClient: isForClient
                      , isProdReady: isProdReady
                      , defaultToDisabled: defaultToDisabled
                      , metadata: metadata
                      , width: width
                      , height: height)
        {
            _mediaOrientationType = mediaOrientationType;
            _inheritsFromDefault = inheritsFromDefault;
        }

        public class Shared : SplashFieldType
        {
            public Shared(int value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , MediaOrientationType mediaOrientationType
                , SplashFieldType inheritsFromDefault
                , Dictionary<string, string> metadata
                , int width
                , int height)
                : base(value: value
                      , displayName: displayName
                      , projectType: ProjectType.Shared
                      , order: order
                      , isForClient: isForClient
                      , isProdReady: isProdReady
                      , defaultToDisabled: defaultToDisabled
                      , mediaOrientationType: mediaOrientationType
                      , inheritsFromDefault:  inheritsFromDefault
                      , metadata: metadata
                      , width: width
                      , height: height)
            {
            }
        }

        public class Droid : SplashFieldType
        {
            public Droid(int value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , MediaOrientationType mediaOrientationType
                , SplashFieldType inheritsFromDefault
                , Dictionary<string, string> metadata
                , int width
                , int height)
                : base(value: value
                      , displayName: displayName
                      , projectType: ProjectType.Droid
                      , order: order
                      , isForClient: isForClient
                      , isProdReady: isProdReady
                      , defaultToDisabled: defaultToDisabled
                      , mediaOrientationType: mediaOrientationType
                      , inheritsFromDefault: inheritsFromDefault
                      , metadata: metadata
                      , width: width
                      , height: height)
            {
            }
        }

        public class Ios : SplashFieldType
        {
            public Ios(int value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , MediaOrientationType mediaOrientationType
                , SplashFieldType inheritsFromDefault
                , Dictionary<string, string> metadata
                , int width
                , int height)
                : base(value: value
                      , displayName: displayName
                      , projectType: ProjectType.Ios
                      , order: order
                      , isForClient: isForClient
                      , isProdReady: isProdReady
                      , defaultToDisabled: defaultToDisabled
                      , mediaOrientationType: mediaOrientationType
                      , inheritsFromDefault: inheritsFromDefault
                      , metadata: metadata
                      , width: width
                      , height: height)
            {
            }
        }
    }
}
