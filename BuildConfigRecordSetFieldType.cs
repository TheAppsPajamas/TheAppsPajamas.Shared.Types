using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class BuildConfigRecordSetFieldType : StringFieldType
    {
        public BuildConfigRecordSetFieldType(string value
            , string displayName
            , ProjectType projectType
            , BuildConfigRecordSetFieldVersionType fieldVersionType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue
            ) : base(value
                , displayName
                , projectType
                , FieldHolderType.Packaging
                , fieldVersionType
                , order
                , isForClient
                , isProdReady
                , defaultToDisabled
                , null
                , fieldDisplayType
                , defaultValue)
        {
        }

        public class Shared : BuildConfigRecordSetFieldType
        {
            public Shared(string value
                , string displayName
                , BuildConfigRecordSetFieldVersionType fieldVersionType
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                )
                : base(value
                      , displayName
                      , ProjectType.Shared
                      , fieldVersionType
                      , order
                      , isForClient
                      , isProdReady
                      , defaultToDisabled
                      , fieldDisplayType
                      , defaultValue)
            {
            }
        }
    }
}
