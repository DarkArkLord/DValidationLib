using DValidationLib.Results;

namespace DValidationLib.Interfaces
{
    public interface IValidationRule<T>
    {
        List<IPropertyValidator> Validators { get; }
        void AddValidator(IPropertyValidator validator);
        IEnumerable<ValidationError> Validate(T instance);
        IProperty<T> Property { get; }
    }
}
