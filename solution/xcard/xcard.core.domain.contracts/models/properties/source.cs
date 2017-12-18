using System;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface ISOURCE
    {
        VALUETYPE ValueType { get; }
        IPID Pid { get; }
        IPREF Pref { get; }

        IALTID AltId { get; }

        IMEDIATYPE MediaType { get; }

        Uri Value { get; }
    }
}
