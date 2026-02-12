using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel.Abstractions;

public interface IDiagramTypeRelationalModel
{
    public IGuid Id { get; }

    public IString Name { get; }
}
