using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface ITITLE
    {
        VALUETYPE ValueType { get; }

        ITYPE Type { get; }
        IPID Pid { get; }
        IPREF Pref { get; }
        IALTID AltId { get; }

        string Value { get; }
    }
}
