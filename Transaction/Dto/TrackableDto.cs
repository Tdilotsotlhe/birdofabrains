using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    [Serializable]
    public abstract class TrackableDto
    {
        [DataMember]
        public bool IsNew { get; set; }

        [DataMember]
        public bool IsInValid { get; set; }

        [DataMember]
        public bool MustSkipWorkflowOnSave { get; set; }

        [DataMember]
        public bool IgnoreRules { get; set; }
    }
}