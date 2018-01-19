using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IADR
    {
        VALUETYPE ValueType { get; }

        string Label { get; }

        ILANGUAGE Language { get; }

        IGEO Geo { get; }

        ITZ Tz { get; }

        IALTID AltId { get; set; }

        IPID Pid { get; }

        IPREF Pref { get; }

        ITYPE Type { get; }

        string AdrComponentPobox { get; }

        string AdrConmponentExt { get; }

        string AdrComponentStreet { get; }

        string AdrComponentLocality { get; }

        string AdrComponentRegion { get; }

        string AdrComponentCode { get; }

        string AdrComponentCountry { get; }
    }
}
