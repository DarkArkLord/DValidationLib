using DValidationLib.Results;

namespace DValidationLib.Interfaces
{
    public interface IPropertyValidator
    {
        ActionAtError AtError { get; }
        bool IsValid(object value);
        ValidationError Error { get; }
    }
}
