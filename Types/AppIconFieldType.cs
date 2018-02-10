using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class AppIconFieldType : MediaFieldType
    {
        public AppIconFieldType(int value
            , string displayName
            , ProjectType projectType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , AppIconFieldType inheritsFromDefault
            , Dictionary<string, string> metadata
            , int width) 
            : base(value: value
                  , displayName: displayName
                  , projectType: projectType
                  , fieldHolderType: FieldHolderType.AppIcon
                  , order: order
                  , isForClient: isForClient
                  , isProdReady: isProdReady
                  , defaultToDisabled: defaultToDisabled
                  , inheritsFromDefault: inheritsFromDefault
                  , metadata: metadata
                  , width: width)
        {
        }

        public class Shared : AppIconFieldType
        {
            public Shared(int value
            , string displayName
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , AppIconFieldType inheritsFromDefault
            , Dictionary<string, string> metadata
            , int width)
            : base(value: value
                  , displayName: displayName
                  , projectType: ProjectType.Shared
                  , order: order
                  , isForClient: isForClient
                  , isProdReady: isProdReady
                  , defaultToDisabled: defaultToDisabled
                  , inheritsFromDefault: inheritsFromDefault
                  , metadata: metadata
                  , width: width)
            {
            }
        }

        public class Droid : AppIconFieldType
        {
            public Droid(int value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , AppIconFieldType inheritsFromDefault
                , Dictionary<string, string> metadata
                , int width)
                : base(value: value
                      , displayName: displayName
                      , projectType: ProjectType.Droid
                      , order: order
                      , isForClient: isForClient
                      , isProdReady: isProdReady
                      , defaultToDisabled: defaultToDisabled
                      , inheritsFromDefault: inheritsFromDefault
                      , metadata: metadata
                      , width: width)
            {
            }
        }

        public class Ios : AppIconFieldType
        {
            public Ios(int value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , AppIconFieldType inheritsFromDefault
                , Dictionary<string, string> metadata
                , int width)
                : base(value: value
                      , displayName: displayName
                      , projectType: ProjectType.Ios
                      , order: order
                      , isForClient: isForClient
                      , isProdReady: isProdReady
                      , defaultToDisabled: defaultToDisabled
                      , inheritsFromDefault: inheritsFromDefault
                      , metadata: metadata
                      , width: width)
            {
            }
        }
    }
}
