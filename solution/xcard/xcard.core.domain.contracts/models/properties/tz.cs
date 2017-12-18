using System;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface ITZ
    {
        VALUETYPE ValueType { get; }

        IALTID AltId { get; set; }

        IPID Pid { get; }

        IPREF Pref { get; }

        ITYPE Type { get; }

        IMEDIATYPE MediaType { get; }
    }

    public interface ITZ_TEXT
    {
        string Value { get; }
    }

    public interface ITZ_URI
    {
        Uri Value { get; }
    }
    public interface ITZ_UTC_OFFSET
    {
        Uri Value { get; }
    }
}
