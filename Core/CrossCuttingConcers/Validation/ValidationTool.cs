﻿using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ValidationException = FluentValidation.ValidationException;

namespace Core.CrossCuttingConcers.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity) // doğrulama kurallarının olduğu class ve doğrulanacak entity istiyor.
        {

            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }

    }
}
