using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Diagram.RelationalModel.Abstractions;

public interface IDiagramRelationalModel : IDiagram
{
    public IGuid Id { get; }

    public IGuid TypeId { get; }
}
