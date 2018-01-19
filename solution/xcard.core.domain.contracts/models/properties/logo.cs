using System;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface ILOGO
    {
        VALUETYPE ValueType { get; }

        ITYPE Type { get; }
        IPID Pid { get; }
        IPREF Pref { get; }
        IALTID AltId { get; }
    }

    public interface ILOGO_URI
    {
        Uri Value { get; }
    }

    public interface ILOGO_DATA
    {
        string Value { get; }
    }
}
