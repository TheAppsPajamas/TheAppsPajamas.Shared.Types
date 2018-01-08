using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class SplashFieldType : MasterMediaFieldType
    {
        public SplashFieldType(int value
            , string displayName
            , ProjectType projectType
            , bool isMaster
            , int order
            , bool isForClient
            , Dictionary<string, string> metadata
            , int width
            , int height) 
            : base(value, displayName, projectType, FieldHolderType.AppIcon, isMaster, order, isForClient, metadata, width, height)
        {
        }

        public class Shared : SplashFieldType
        {
            public Shared(int value
                , string displayName
                , bool isMaster
                , int order
                , bool isForClient
                , Dictionary<string, string> metadata
                , int width
                , int height)
                : base(value, displayName, ProjectType.Shared, isMaster, order, isForClient, metadata, width, height)
            {
            }
        }

        public class Droid : SplashFieldType
        {
            public Droid(int value
                , string displayName
                , bool isMaster
                , int order
                , bool isForClient
                , Dictionary<string, string> metadata
                , int width
                , int height)
                : base(value, displayName, ProjectType.Droid, isMaster, order, isForClient, metadata, width, height)
            {
            }
        }

        public class Ios : SplashFieldType
        {
            public Ios(int value
                , string displayName
                , bool isMaster
                , int order
                , bool isForClient
                , Dictionary<string, string> metadata
                , int width
                , int height)
                : base(value, displayName, ProjectType.Ios, isMaster, order, isForClient, metadata, width, height)
            {
            }
        }
    }
}
