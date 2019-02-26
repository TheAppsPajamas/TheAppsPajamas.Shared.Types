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
            , PackagingFieldVersionType fieldVersionType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , PackagingFieldType inheritsFromDefault
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue) 
            : base(value
                  , displayName
                  , projectType
                  , FieldHolderType.Packaging
                  , fieldVersionType
                  , order
                  , isForClient
                  , isProdReady
                  , defaultToDisabled
                  , inheritsFromDefault
                  , fieldDisplayType
                  , defaultValue
                  )
        {
        }

        public class Shared : PackagingFieldType
        {
            public Shared(string value
                , string displayName
                , PackagingFieldVersionType fieldVersionType
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , PackagingFieldType inheritsFromDefault
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                ) : base(value
                    , displayName
                    , ProjectType.Shared
                    , fieldVersionType
                    , order
                    , isForClient
                    , isProdReady
                    , defaultToDisabled
                    , inheritsFromDefault
                    , fieldDisplayType
                    , defaultValue)
            {
            }
        }

        public class Droid : PackagingFieldType
        {
            public Droid(string value
                , string displayName
                , PackagingFieldVersionType fieldVersionType
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , PackagingFieldType inheritsFromDefault
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                ) : base(value
                    , displayName
                    , ProjectType.Shared
                    , fieldVersionType
                    , order
                    , isForClient
                    , isProdReady
                    , defaultToDisabled
                    , inheritsFromDefault
                    , fieldDisplayType
                    , defaultValue)
            {
            }
        }

        public class Ios : PackagingFieldType
        {
            public Ios(string value
                , string displayName
                , StringFieldDisplayType fieldDisplayType
                , PackagingFieldVersionType fieldVersionType
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , PackagingFieldType inheritsFromDefault
                , string defaultValue
                ) : base(value
                    , displayName
                    , ProjectType.Shared
                    , fieldVersionType
                    , order
                    , isForClient
                    , isProdReady
                    , defaultToDisabled
                    , inheritsFromDefault
                    , fieldDisplayType
                    , defaultValue)
            {
            }
        }

    }
}
