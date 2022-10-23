namespace ConsoleObserverPatternExample
{
    public interface IObservable<TypeDefinition>
    {
        void Subscribe(IObserver<TypeDefinition> observer);
        void Unsubscribe(IObserver<TypeDefinition> observer);
        void Notify(TypeDefinition data);
    }
}