using System;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface ITEL
    {
        VALUETYPE ValueType { get; }

        ITYPE Type { get; }
        IPID Pid { get; }
        IPREF Pref { get; }
        IALTID AltId { get; }

    }

    public interface ITEL_URI
    {
        Uri Value { get; }
    }

    public interface ITEL_TEXT
    {
        string Value { get; }

    }
}
