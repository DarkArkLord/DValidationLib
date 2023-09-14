using DValidationLib.Results.ValidationErrorChilds;

namespace DValidationLib.PropertyValidatorChilds
{
    public class NotNullValidator : PropertyValidator
    {
        public NotNullValidator(string property_name)
            : base()
        {
            Error = new NotNullError(property_name);
            AtError = ActionAtError.Break;
        }

        public override bool IsValid(object value)
        {
            return !(value is null);
        }
    }
}
