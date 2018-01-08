using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class AppIconFieldType : MasterMediaFieldType
    {
        public AppIconFieldType(int value
            , string displayName
            , ProjectType projectType
            , bool isMaster
            , int order
            , bool isForClient
            , Dictionary<string, string> metadata
            , int width) 
            : base(value, displayName, projectType, FieldHolderType.AppIcon, isMaster, order, isForClient, metadata, width)
        {
        }

        public class Shared : AppIconFieldType
        {
            public Shared(int value
            , string displayName
            , bool isMaster
            , int order
            , bool isForClient
            , Dictionary<string, string> metadata
            , int width)
                : base(value, displayName, ProjectType.Shared, isMaster, order, isForClient, metadata, width)
            {
            }
        }

        public class Droid : AppIconFieldType
        {
            public Droid(int value
                , string displayName
                , bool isMaster
                , int order
                , bool isForClient
                , Dictionary<string, string> metadata
                , int width)
                : base(value, displayName, ProjectType.Droid, isMaster, order, isForClient, metadata, width)
            {
            }
        }

        public class Ios : AppIconFieldType
        {
            public Ios(int value
                , string displayName
                , bool isMaster
                , int order
                , bool isForClient
                , Dictionary<string, string> metadata
                , int width)
                : base(value, displayName, ProjectType.Ios, isMaster, order, isForClient, metadata, width)
            {
            }
        }
    }
}
