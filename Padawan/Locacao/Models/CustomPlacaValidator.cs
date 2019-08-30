
using Locacao.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Locacao.Models
{
    public class CustomPlacaValidator : ValidationAttribute
    {
        private ContextDB db = new ContextDB();

        private ValidFields typeField;

        public CustomPlacaValidator(ValidFields type)
        {
            typeField = type;

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaPlaca:
                        {
                            return ValidarPlaca(value, validationContext.DisplayName);
                        }
                    case ValidFields.ValidaTipo:
                        {
                            return ValidarTipo(value, validationContext.DisplayName);
                        }
                    
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext} é obrigatorio");
        }
        private ValidationResult ValidarTipo(object tipo, string displayField)
        {
            if(db.TipoVeiculos.Where(x => x.Codigo == (int)tipo) != null)
            {
                if ((int)tipo == 1)
                {
                    var marcaCarro = db.AutomovelMarcas.FirstOrDefault(x => x.Codigo == (int)tipo);
                    if(marcaCarro != null)
                    {
                        return new ValidationResult($"o campo {displayField} é obrigatorio.");

                    }
                    var modeloCarro = db.AutomovelModelos.FirstOrDefault(x => x.CodigoFK == (int)tipo);
                    if (modeloCarro != null)
                    {
                        return new ValidationResult($"o campo {displayField} é obrigatorio.");

                    }
                    var corCarro = db.Cores.FirstOrDefault(x => x.Codigo == (int)tipo);
                    if (corCarro != null)
                    {
                        return new ValidationResult($"o campo {displayField} é obrigatorio.");

                    }
                }
                if ((int)tipo == 2)
                {
                    var marcaCarro = db.AutomovelMarcas.FirstOrDefault(x => x.Codigo == (int)tipo);
                    if (marcaCarro != null)
                    {
                        return new ValidationResult($"o campo {displayField} é obrigatorio.");

                    }
                    var modeloCarro = db.AutomovelModelos.FirstOrDefault(x => x.CodigoFK == (int)tipo);
                    if (modeloCarro != null)
                    {
                        return new ValidationResult($"o campo {displayField} é obrigatorio.");

                    }
                    var corCarro = db.Cores.FirstOrDefault(x => x.Codigo == (int)tipo);
                    if (corCarro != null)
                    {
                        return new ValidationResult($"o campo {displayField} é obrigatorio.");

                    }
                }
            }
            return new ValidationResult($"o campo {displayField} é invalido.");
        }
        private ValidationResult ValidarPlaca(object placa, string displayField)
        {
            bool placaCarro = Regex.IsMatch(placa.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$");

            bool placaCarroMC = Regex.IsMatch(placa.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");

            bool placaMoto = Regex.IsMatch(placa.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$");


            if (placaCarro || placaCarroMC || placaMoto)
            {
               var validacao = db.Veiculos.FirstOrDefault(x => x.Placa == placa.ToString());


               if (validacao != null)
                {
                    return new ValidationResult($"Carro ja registrado.");
                }
                else
                {
                   return ValidationResult.Success;
                }

            }
            return new ValidationResult($"A placa informada não está no formato aceitável.");
        }
        
    }
}