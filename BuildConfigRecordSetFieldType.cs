using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class BuildConfigRecordSetFieldType : StringFieldType
    {
        public BuildConfigRecordSetFieldType(int value
            , string displayName
            , ProjectType projectType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue) : base(value, displayName, projectType, FieldHolderType.Packaging, order, isForClient, isProdReady, defaultToDisabled, null, fieldDisplayType, defaultValue)
        {
        }

        public class Shared : BuildConfigRecordSetFieldType
        {
            public Shared(int value
                , string displayName
                , int order
                , bool isForClient
                , bool isProdReady
                , bool defaultToDisabled
                , StringFieldDisplayType fieldDisplayType
                , string defaultValue)
                : base(value, displayName, ProjectType.Shared, order, isForClient, isProdReady, defaultToDisabled, fieldDisplayType, defaultValue)
            {
            }
        }
    }
}
