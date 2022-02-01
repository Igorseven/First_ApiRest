using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace SaveCars.Domain.Extention
{
    public static class ValidationExtention
    {
        public static Dictionary<string, string> ToDictionary(this IList<ValidationFailure> errors)
        {
            var result = new Dictionary<string, string>();

            foreach (var error in errors)
            {
                if (result.ContainsKey(error.PropertyName))
                    result[error.PropertyName] = $"{result[error.PropertyName]}{Environment.NewLine}{error.ErrorMessage}";
                else
                    result.Add(error.PropertyName, error.ErrorMessage);
            }

            return result;
        }
    }
}
