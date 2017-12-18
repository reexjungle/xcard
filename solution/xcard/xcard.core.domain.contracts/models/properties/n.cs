using System.Collections.Generic;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface IN
    {
        VALUETYPE Type { get; }
        ISORT_AS SortAs { get; }

        ILANGUAGE Language { get; }

        IALTID AltId { get; set; }

        List<string> Values { get; }
    }
}
