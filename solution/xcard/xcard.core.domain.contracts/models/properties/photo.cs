using System;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IPHOTO
    {
        VALUETYPE ValueType { get; }

        IALTID AltId { get; set; }

        ITYPE Type { get; }

        IMEDIATYPE MediaType { get; }

        IPID Pid { get; }

        IPREF Pref { get; }

    }

    public interface IPHOTO_URI
    {
        Uri Value { get; }
    }

    public interface IPHOTO_DATA
    {
        string Value { get; }
    }
}
