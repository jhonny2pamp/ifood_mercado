using System.Collections.Generic;
using System;

namespace IfoodMercado.Models
{
    public class Order
    {
        public int idLoja { get; set; }
        public int idCliente { get; set; }
        public string idPedido { get; set; }
        public string codigo { get; set; }
        public string codigoLoja { get; set; }
        public DateTime data { get; set; }
        public string hora { get; set; }
        public DateTime dataHora { get; set; }
        public DateTime agendamentoDataInicio { get; set; }
        public string agendamentoHoraInicio { get; set; }
        public DateTime agendamentoDataFim { get; set; }
        public string agendamentoHoraFim { get; set; }
        public bool entrega { get; set; }
        public bool retirada { get; set; }
        public bool cpfNaNota { get; set; }
        public string status { get; set; }
        public string statusDescricao { get; set; }
        public string pessoaAutorizadaRecebimento { get; set; }
        public int quantidadeItemUnico { get; set; }
        public decimal valorMercado { get; set; }
        public decimal valorConveniencia { get; set; }
        public int quantidadeSacolaResfriada { get; set; }
        public int quantidadeSacolaSeca { get; set; }
        public decimal valorEntrega { get; set; }
        public decimal valorRetirada { get; set; }
        public decimal valorTroco { get; set; }
        public decimal valorDesconto { get; set; }
        public decimal valorTotal { get; set; }
        public decimal valorCorrigido { get; set; }
        public IfoodParceiro parceiro { get; set; }
        public string plataforma { get; set; }
        public IfoodEnderecoEntrega enderecoEntrega { get; set; }
        public IfoodCupom cupom { get; set; }
        public IfoodLoja loja { get; set; }
        public IfoodCliente cliente { get; set; }
        public List<IfoodItem> items { get; set; }
        public List<IfoodPagamento> pagamentos { get; set; }
        public List<IfoodBeneficio> beneficios { get; set; }
    }

    public class IfoodBeneficio
    {
        public string patrocinio { get; set; }
        public decimal valor { get; set; }
        public string tipo { get; set; }
        public int itemId { get; set; }
    }

    public class IfoodCliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public string tipo { get; set; }
        public bool publicidadeEmail { get; set; }
        public bool publicidadeSms { get; set; }
        public string telefoneCelular { get; set; }
        public List<object> enderecos { get; set; }
    }

    public class IfoodCupom
    {
        public string codigo { get; set; }
        public bool beneficioTaxaServico { get; set; }
        public bool beneficioTaxaEntrega { get; set; }
        public bool beneficioTaxaRetirada { get; set; }
        public decimal valorBeneficioTaxaServico { get; set; }
        public decimal valorBeneficioTaxaEntrega { get; set; }
        public decimal valorBeneficioTaxaRetirada { get; set; }
    }

    public class IfoodEndereco
    {
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
    }

    public class IfoodEnderecoEntrega
    {
        public int id { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }

    public class IfoodItem
    {
        public int id { get; set; }
        public string uniqueId { get; set; }
        public int index { get; set; }
        public string codigo { get; set; }
        public string codigoLoja { get; set; }
        public bool pesoVariavel { get; set; }
        public string codigoBarra { get; set; }
        public string plu { get; set; }
        public string produto { get; set; }
        public string observacao { get; set; }
        public decimal quantidade { get; set; }
        public decimal quantidade3 { get; set; }
        public decimal valor { get; set; }
        public decimal valorTotal { get; set; }
        public bool indisponivel { get; set; }
        public bool desistencia { get; set; }
        public decimal valorOriginal { get; set; }
        public bool pesoVariavelVendidoPorUnidade { get; set; }
    }

    public class IfoodLoja
    {
        public int id { get; set; }
        public string storeId { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string status { get; set; }
        public IfoodEndereco endereco { get; set; }
        public IfoodRede rede { get; set; }
    }

    public class IfoodPagamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal valor { get; set; }
        public decimal valorCorrigido { get; set; }
        public string tipo { get; set; }
        public List<string> transacoes { get; set; }
    }

    public class IfoodParceiro
    {
        public string codigoEntrega { get; set; }
        public string codigoPedido { get; set; }
        public bool agendado { get; set; }
    }

    public class IfoodRede
    {
        public int id { get; set; }
        public string nome { get; set; }
    }
}