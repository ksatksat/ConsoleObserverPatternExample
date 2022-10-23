namespace ConsoleObserverPatternExample
{
    public interface IObserver<TypeDefinition>
    {
        void Update(TypeDefinition data);
    }
}