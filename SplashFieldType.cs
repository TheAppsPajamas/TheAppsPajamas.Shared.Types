using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class SplashFieldType : MediaFieldType
    {
        private MediaOrientationType _mediaOrientationType;
        public MediaOrientationType MediaOrientationType {  get { return _mediaOrientationType;  } }
        
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
                      , inheritsFromDefault: inheritsFromDefault
                      , metadata: metadata
                      , width: width
                      , height: height)
        {
            _mediaOrientationType = mediaOrientationType;
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
