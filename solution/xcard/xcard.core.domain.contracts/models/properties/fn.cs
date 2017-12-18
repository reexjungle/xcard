namespace reexjungle.xcard.core.domain.contracts.models.parameters
{
    public interface IFN
    {
        VALUETYPE ValueType { get; }

        ILANGUAGE Language { get; }

        IALTID AltId { get; set; }

        IPID Pid { get; }

        IPREF Pref { get; }

        string Value { get; }
    }
}
