namespace DValidationLib.Interfaces
{
    public interface IProperty<T>
    {
        object Value(T instance);
        string Name { get; }
    }
}
