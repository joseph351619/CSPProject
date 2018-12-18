using System.Collections.Generic;

namespace CSPProject{
public class CspDirective
{
    private readonly string _directive;
    internal CspDirective(string directive)
    {
        _directive = directive;
    }
    private List<string> _source {get; set;} = new List<string>();
    public virtual CspDirective AllowAny() => Allow("*");
    public virtual CspDirective Disallow() => Allow("'none'");
    public virtual CspDirective AllowSelf() => Allow("'self'");
    public virtual CspDirective Allow(string source)
    {
        _source.Add(source);
        return this;
    }
    public override string ToString() => _source.Count > 0
        ? $"{_directive} {string.Join(" ", _source)}; " : "";
}
}