using reexjungle.xcard.core.domain.contracts.models.values;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IBDAY
    {
        VALUETYPE ValueType { get; }

        CALSCALE Calscale { get; }
        DATE_TIME Value { get; }

    }
}
