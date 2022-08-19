using MediatR;

namespace CINEMATRIX.API.Application.Commands.Abstractions
{
    public class CommandBase<TResponse, TEntity> : IRequest<TResponse>
    {
        public TEntity Entity { get; set; }
        public long Id { get; set; }
        protected CommandBase(long id, TEntity entity)
        {
            Id = id;
            Entity = entity;
        }

        protected CommandBase(TEntity entity)
        {
            Entity = entity;
        }
    }
}
