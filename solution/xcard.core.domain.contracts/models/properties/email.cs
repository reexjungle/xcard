using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IEMAIL
    {
        VALUETYPE ValueType { get; }

        IALTID AltId { get; set; }

        IPID Pid { get; }

        IPREF Pref { get; }

        ITYPE Type { get; }

        string Value { get; }
    }
}
