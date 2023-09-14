using DValidationLib.Results;

namespace DValidationLib.Interfaces
{
    public interface IValidator<T>
    {
        List<IValidationRule<T>> Rules { get; }
        ValidationResult Validate(T instance);
    }
}
