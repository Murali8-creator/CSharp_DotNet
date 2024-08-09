namespace CrudOperations.Service
{
    public interface IQueryHandler<TQuery , TResult>
    {
        TResult Handle(TQuery query);
    }
}
