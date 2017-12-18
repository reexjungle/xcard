using reexjungle.xcard.core.domain.contracts.models.values;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IANNIVERSAY
    {
        VALUETYPE ValueType { get; }
        DATE_TIME Value { get; }
    }
}
