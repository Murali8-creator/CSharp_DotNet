namespace CrudOperations.Service
{
    public interface ICommandHandler<TCommand>
    {
        int Handle(TCommand command);

        
    }
}
