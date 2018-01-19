namespace reexjungle.xcard.core.domain.contracts.models.parameters
{
    public interface IMEDIATYPE
    {
        string TypeName { get; }
        string SubTypeName { get; }

        (string attribute, string value) Pair { get; }

    }
}
