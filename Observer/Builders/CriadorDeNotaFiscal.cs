using Observer.Interfaces;
using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.Builders
{
    public class CriadorDeNotaFiscal
    {
        private IList<ItemDaNota> _itens;
        private List<IAcaoAposGerarNota> _acoesAposGerarNF;

        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IReadOnlyCollection<ItemDaNota> Itens { get { return _itens.ToList(); } }
        public string Observacoes { get; private set; }

        public CriadorDeNotaFiscal(IList<IAcaoAposGerarNota> acoesAposGerarNota)
        {
            this.DataDeEmissao = DateTime.Now;
            this._itens = new List<ItemDaNota>();
            this._acoesAposGerarNF = new List<IAcaoAposGerarNota>();
            _acoesAposGerarNF.AddRange(acoesAposGerarNota);
        }

        public NotaFiscal Constroi()
        {
            ValidadorDeNotaFiscal validador = new ValidadorDeNotaFiscal();
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj,
                DataDeEmissao, ValorBruto, Impostos,
                _itens, Observacoes);

            if (validador.Validate(notaFiscal).IsValid)
            {
                ExecutaAcoesAposGerarNF(notaFiscal);
                return notaFiscal;
            }
            else
                throw new InvalidOperationException("Não é possível criar o objeto, parâmetros inválidos");
        }

        private void ExecutaAcoesAposGerarNF(NotaFiscal notaFiscal)
        {
            foreach (IAcaoAposGerarNota acao in _acoesAposGerarNF)
            {
                acao.Executa(notaFiscal);
            }
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this._acoesAposGerarNF.Add(novaAcao);
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

        public CriadorDeNotaFiscal Com(ItemDaNota itemNovo)
        {
            this._itens.Add(itemNovo);
            this.ValorBruto += itemNovo.Valor;
            this.Impostos = itemNovo.Valor * 0.05;
            return this;
        }

        public CriadorDeNotaFiscal NaData(DateTime data)
        {
            this.DataDeEmissao = data;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
    }
}
