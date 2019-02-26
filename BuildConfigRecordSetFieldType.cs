using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class BuildConfigRecordSetFieldType : StringFieldType
    {
        public BuildConfigRecordSetFieldVersionType BuildConfigRecordSetFieldVersionType { get; }

        public BuildConfigRecordSetFieldType(string value
            , string displayName
            , ProjectType projectType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue
            , BuildConfigRecordSetFieldVersionType fieldVersionType) : base(value, displayName, projectType, FieldHolderType.Packaging, order, isForClient, isProdReady, defaultToDisabled, null, fieldDisplayType, defaultValue)
        {
        }

        public class Shared : BuildConfigRecordSetFieldType
        {
            public Shared(string value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue
                , BuildConfigRecordSetFieldVersionType fieldVersionType)
                : base(value, displayName, ProjectType.Shared, order, isForClient, isProdReady, defaultToDisabled, fieldDisplayType, defaultValue, fieldVersionType)
            {
            }
        }
    }
}
