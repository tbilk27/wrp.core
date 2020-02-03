using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum RelatorioParametroOrigem
    {
        [Display(Name = "Digitado")]
        Digitado = 0,
        [Display(Name = "Valor Padrão")]
        Fixo = 1,
        //[Display(Name = "Pedido")]
        //PedidoID = 2,
        [Display(Name = "Pessoa")]
        PessoaID = 3,
        //[Display(Name = "Usuário")]
        //UsuarioID = 4,
        [Display(Name = "Produto")]
        ProdutoID = 5,
        [Display(Name = "DatePicker")]
        DatePicker = 6,
        [Display(Name = "DateTimePicker")]
        DateTimePicker = 7,
        [Display(Name = "Checkbox")]
        Checkbox = 8,
        [Display(Name = "Automático")]
        Automatico = 9,
        [Display(Name = "Checkbox (Tri-State)")]
        Tristate = 10,
        [Display(Name = "Região de Venda")]
        RegiaoVendaID = 11,
        [Display(Name = "Cidade/UF")]
        CidadeID = 12,
        [Display(Name = "Fornecedor")]
        FornecedorID = 13,
        [Display(Name = "Transportadora")]
        TransportadoraID = 14,
        [Display(Name = "Cliente")]
        ClienteID = 15,
        [Display(Name = "Representante")]
        RepresentanteID = 16,
        [Display(Name = "Marca do Produto")]
        MarcaProdutoID = 17,
        [Display(Name = "Categoria do Produto")]
        CategoriaProdutoID = 18,
        [Display(Name = "Local")]
        LocalID = 19,
        [Display(Name = "Produto Item")]
        ProdutoItemID = 20,
        [Display(Name = "Rota de Entrega")]
        RotaID = 21,
        [Display(Name = "Logo da Empresa")]
        LogoEmpresa = 22,
        [Display(Name = "Pedido")]
        PedidoID = 23
    }
}
