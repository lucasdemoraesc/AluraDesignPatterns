using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.Builders
{
    public class CriadorDeNotaFiscal
    {
        private IList<ItemDaNota> _itens;

        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IReadOnlyCollection<ItemDaNota> Itens { get { return _itens.ToList(); } }
        public string Observacoes { get; private set; }

        public CriadorDeNotaFiscal()
        {
            this._itens = new List<ItemDaNota>();
        }

        public NotaFiscal Constroi()
        {
            ValidadorDeNotaFiscal validador = new ValidadorDeNotaFiscal();
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj,
                DataDeEmissao, ValorBruto, Impostos,
                _itens, Observacoes);

            if (validador.Validate(notaFiscal).IsValid)
                return notaFiscal;
            else
                throw new InvalidOperationException("Não é possível criar o objeto, parâmetros inválidos");
        }

        public CriadorDeNotaFiscal ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            this._itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos = item.Valor * 0.05;
            return this;
        }

        public CriadorDeNotaFiscal NaDataAtual()
        {
            this.DataDeEmissao = DateTime.Now;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
    }
}
