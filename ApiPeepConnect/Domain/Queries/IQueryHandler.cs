namespace ApiPeepConnect.Domain.Queries.Interfaces
{
    public interface IQueryHandler<in TQuery, out TResponse> where TQuery : IQuery<TResponse>
    {
        TResponse Get();
    }
}