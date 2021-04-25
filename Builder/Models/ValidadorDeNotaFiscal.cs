using FluentValidation;
using System;

namespace Builder.Models
{
    public class ValidadorDeNotaFiscal : AbstractValidator<NotaFiscal>
    {
        public ValidadorDeNotaFiscal()
        {
            validaRazaoSocial();
            validaCnpj();
            validaItens();
            validaDataDeEmissao();
            validaValorBruto();
        }

        private void validaValorBruto()
        {
            RuleFor(x => x.ValorBruto)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Valor deve ser maior que 0");
        }

        private void validaDataDeEmissao()
        {
            RuleFor(x => x.DataDeEmissao)
                .NotEmpty()
                .WithMessage("Deve ser a data atual");
        }

        private void validaItens()
        {
            RuleFor(x => x.Itens)
                .NotNull()
                .NotEmpty()
                .WithMessage("Lista não pode estar vazia");
        }

        private void validaCnpj()
        {
            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .Length(14)
                .WithMessage("Cnpj inválido");
        }

        private void validaRazaoSocial()
        {
            RuleFor(x => x.RazaoSocial)
                .NotEmpty()
                .Length(3, 60)
                .WithMessage("Razão social inválida");
        }
    }
}
