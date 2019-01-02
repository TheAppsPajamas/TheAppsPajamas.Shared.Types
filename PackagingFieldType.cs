using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class PackagingFieldType : StringFieldType
    {

        public PackagingFieldType(string value
            , string displayName
            , ProjectType projectType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , PackagingFieldType inheritsFromDefault
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue) 
            : base(value, displayName, projectType, FieldHolderType.Packaging, order, isForClient, isProdReady, defaultToDisabled, inheritsFromDefault, fieldDisplayType, defaultValue)
        {
        }

        public class Shared : PackagingFieldType
        {
            public Shared(string value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , PackagingFieldType inheritsFromDefault
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                ) : base(value, displayName, ProjectType.Shared, order, isForClient, isProdReady, defaultToDisabled, inheritsFromDefault, fieldDisplayType, defaultValue)
            {
            }
        }

        public class Droid : PackagingFieldType
        {
            public Droid(string value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , PackagingFieldType inheritsFromDefault
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                ) : base(value, displayName, ProjectType.Droid, order, isForClient, isProdReady, defaultToDisabled, inheritsFromDefault, fieldDisplayType, defaultValue)
            {
            }
        }

        public class Ios : PackagingFieldType
        {
            public Ios(string value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , PackagingFieldType inheritsFromDefault
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                ) : base(value, displayName, ProjectType.Ios, order, isForClient, isProdReady, defaultToDisabled, inheritsFromDefault, fieldDisplayType, defaultValue)
            {
            }
        }

    }
}
