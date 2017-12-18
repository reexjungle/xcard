using System;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IIMPP
    {
        VALUETYPE ValueType { get; }

        IPID Pid { get; }

        IPREF Pref { get; }

        ITYPE Type { get; }

        IMEDIATYPE MediaType { get; }

        Uri Value { get; }
    }
}
