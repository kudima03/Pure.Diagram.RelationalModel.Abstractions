using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel.Abstractions;

public interface ISeriesRelationalModel
{
    public IGuid Id { get; }

    public IGuid DiagramId { get; }

    public IString Label { get; }

    public IString Source { get; }
}
