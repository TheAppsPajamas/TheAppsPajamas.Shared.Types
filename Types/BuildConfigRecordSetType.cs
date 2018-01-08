using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class BuildConfigRecordSetType : StringFieldType
    {
        public BuildConfigRecordSetType(int value
            , string displayName
            , ProjectType projectType
            , int order
            , bool isForClient
            , StringFieldDisplayType fieldDisplayType) : base(value, displayName, projectType, FieldHolderType.Packaging, true, order, isForClient, fieldDisplayType)
        {
        }

        public class Shared : BuildConfigRecordSetType
        {
            public Shared(int value
                , string displayName
                , int order
                , bool isForClient
                , StringFieldDisplayType fieldDisplayType)
                : base(value, displayName, ProjectType.Shared, order, isForClient, fieldDisplayType)
            {
            }
        }
    }
}
