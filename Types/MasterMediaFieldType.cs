using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class MasterMediaFieldType : MediaFieldType
    {
        private bool _isMaster;
        public virtual bool IsMaster { get { return _isMaster; } }
        
        public MasterMediaFieldType(int value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , bool isMaster
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , Dictionary<string, string> metadata
            , int width
            , int height = 0) : base(value, displayName, projectType, fieldHolderType, order, isForClient, isProdReady, defaultToDisabled, metadata, width, height = 0)
        {
            _isMaster = isMaster;
        }

    }
}
