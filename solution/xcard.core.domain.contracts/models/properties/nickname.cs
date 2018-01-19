using System.Collections.Generic;
using reexjungle.xcard.core.domain.contracts.models.parameters;

namespace reexjungle.xcard.core.domain.contracts.models.properties
{
    public interface INickname
    {
        VALUETYPE Type { get; }

        ILANGUAGE Language { get; }

        IALTID AltId { get; set; }

        IPID Pid { get; }

        IPREF Pref { get; }

        List<string> Values { get; }
    }
}
