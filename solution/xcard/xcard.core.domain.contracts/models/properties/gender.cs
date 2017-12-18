namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IGENDER
    {
        VALUETYPE ValueType { get; }

        GENDERTYPE GenderType { get; }

        string Text { get; }
    }
}
