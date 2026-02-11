using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Diagram.RelationalModel.Abstractions;

public interface ISeriesRelationalModel : ISeries
{
    public IGuid Id { get; }

    public IGuid DiagramId { get; }
}
