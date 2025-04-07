using MediatR;

namespace BuildingBlocks.CQRS;

public interface IQuery<out TResponnse> : IRequest<TResponnse>
    where TResponnse : notnull
{
}
