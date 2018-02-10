﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class AppIconFieldType : MasterMediaFieldType
    {
        private bool _isMaster;
        public virtual bool IsMaster { get { return _isMaster; } }

        public AppIconFieldType(int value
            , string displayName
            , ProjectType projectType
            , bool isMaster
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , Dictionary<string, string> metadata
            , int width) 
            : base(value, displayName, projectType, FieldHolderType.AppIcon, order, isForClient, isProdReady, defaultToDisabled, metadata, width)
        {
            _isMaster = isMaster;
        }

        public class Shared : AppIconFieldType
        {
            public Shared(int value
            , string displayName
            , bool isMaster
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , Dictionary<string, string> metadata
            , int width)
                : base(value, displayName, ProjectType.Shared, isMaster, order, isForClient, isProdReady, defaultToDisabled, metadata, width)
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
                , bool isProdReady
                , bool defaultToDisabled
                , Dictionary<string, string> metadata
                , int width)
                : base(value, displayName, ProjectType.Droid, isMaster, order, isForClient, isProdReady,  defaultToDisabled, metadata, width)
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
                , bool isProdReady
                , bool defaultToDisabled
                , Dictionary<string, string> metadata
                , int width)
                : base(value, displayName, ProjectType.Ios, isMaster, order, isForClient, isProdReady, defaultToDisabled, metadata, width)
            {
            }
        }
    }
}
