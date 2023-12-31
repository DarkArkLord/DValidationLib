﻿using DValidationLib.Interfaces;
using DValidationLib.Iternal;
using DValidationLib.Results;

namespace DValidationLib
{
    public enum ActionAtError
    {
        Continue,
        Break,
        Stop
    }

    public class PropertyValidator : IPropertyValidator
    {
        private Predicate<object> predicate;

        public ValidationError Error { get; protected set; }

        public ActionAtError AtError { get; set; }

        public PropertyValidator(Predicate<object> predicate, ValidationError error, ActionAtError at_error)
        {
            predicate.CheckNull(nameof(predicate));
            error.CheckNull(nameof(error));

            this.predicate = predicate;
            Error = error;
            AtError = at_error;
        }

        protected PropertyValidator() { }

        public virtual bool IsValid(object value)
        {
            value.CheckNull(nameof(value));
            return predicate(value);
        }
    }
}
