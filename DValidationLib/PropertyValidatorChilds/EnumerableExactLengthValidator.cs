﻿using DValidationLib.Results.ValidationErrorChilds;

namespace DValidationLib.PropertyValidatorChilds
{
    class EnumerableExactLengthValidator<TProp> : PropertyValidator
    {
        private int len;
        public EnumerableExactLengthValidator(string prop_name, int len)
        {
            Error = new EnumerableExactLengthError(prop_name, len);
            AtError = ActionAtError.Continue;
            this.len = len;
        }

        public override bool IsValid(object value)
        {
            if (value is null) return false;

            return ((IEnumerable<TProp>)value).Count() == len;
        }
    }
}
