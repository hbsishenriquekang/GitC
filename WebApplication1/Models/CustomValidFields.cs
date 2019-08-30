using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WebApplication1.Enum;

namespace WebApplication1.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        private ContextDB db = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields (ValidFields type)
        {
            typeField = type;

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        {
                            ValidarLogin(value, validationContext.DisplayName);
                        }
                        break;
                    case ValidFields.ValidaEmail:
                        {
                            ValidarEmail(value, validationContext.DisplayName);
                        }
                        break;
                    case ValidFields.ValidaSenha:
                        {
                            ValidarSenha(value, validationContext.DisplayName);
                        }
                        break;
                    case ValidFields.ValidaNome:
                        {
                            ValidarNome(value, validationContext.DisplayName);
                        }
                        break;
                    default:
                        break;
                }
            }
            
            return new ValidationResult($"O campo {validationContext} é obrigatorio");

        }
        private ValidationResult ValidarEmail(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(),
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
            {
                return ValidationResult.Success;

            }
            return new ValidationResult($"o campo {displayField} é invalido.");
        }
        private ValidationResult ValidarSenha(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(),
                "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])");

            if (result)
            {
                return ValidationResult.Success;

            }
            return new ValidationResult($"o campo {displayField} é invalido.");
        }
        private ValidationResult ValidarLogin(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(),
                @"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            if (result)
            {
                return ValidationResult.Success;

            }
            return new ValidationResult($"o campo {displayField} é invalido.");
        }
        private ValidationResult ValidarNome(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(),
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
            {

                return ValidationResult.Success;

            }
            return new ValidationResult($"o campo {displayField} é invalido.");
        }
    }
}