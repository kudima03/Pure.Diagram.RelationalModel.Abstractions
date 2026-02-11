using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Diagram.RelationalModel.Abstractions;

public interface IDiagramTypeRelationalModel : IDiagramType
{
    public IGuid Id { get; }
}
