using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroProduto.Entities
{
    public class Produto //1º troca visibilidade internal p/ public
    {
        /// <summary>
        ///2ºDigito os atributos
        ///Modificador de visibilidade:private
        ///Tipo da variável temos: Guid,string,double,int e DateTime
        ///Sinal de interrogação(p/ falar q/ aceita campo vazio): ?
        ///Nome da variável: _idProduto,_nome, _preco, _quantidade,_dataCompra.
        ///OBS.: COMO VISIBILIDADE É private O ATIBUTO COMEÇA COM:
        ///*UNDERLINE (-)
        ///*LETRA MINÚSCULA
        ///*USA NOTAÇÃO DO CAMELO
        /// </summary>
        /// 
        #region Atributos

        private Guid _idProduto;
        private string? _nome;
        private double? _preco;
        private int? _quantidade;
        private DateTime _dataCompra;

        /// <summary>
        /// 3ºRelacionamento de composição (TER)
        /// Explicação : Classe Produto tem uma Categoria
        /// (por isso classe categoria vira um tipo ex.: Categoria?)
        /// SINTAXE :
        /// </summary>
        private Categoria? _categoria;

        /// <summary>
        /// 4ºRelacionamento de composição (TER)
        /// Explicação : Classe Produto tem um Fornecedor
        /// (por isso classe Fornecedor vira um tipo ex.: Fornecedor?)
        /// </summary>
        private Fornecedor? _fornecedor;

        #endregion

        #region Propriedades
        /// <summary>
        /// 5ºPropriedades ( p/ acessar atributos q/ estão c/ visibilidade privada(private)
        /// Explicação : 
        /// -set : envia dados 
        /// - get : recbe dados
        /// </summary>
        /// 
        
        //Lambida
        //public Guid IdProduto { get => _idProduto; set => _idProduto = value;}

        public Guid IdProduto
        {
            set => _idProduto = value;
            get => _idProduto;
        }

        //Lambida
        //public string? Nome { get => _nome; set => _nome = value;}

        public string? Nome
        {
            set
            {
               
                //Validar dados :Os caracteres que aceitam 
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Informe nome válido somente texto, de 6 a 150 caracteres");

                _nome = value;
            }
            get => _nome;
        }


        //public double? Preco { get => _preco; set => _preco = value;}

        public double? Preco
        {
            set
            {
                //validação
                if (value < 0)
                    throw new ArgumentException("Infome preço maior que zero");
                _preco = value;
            }
                get => _preco;
        }

        //public int? Quantidade { get => _quantidade; set => _quantidade = value;}

        public int? Quantidade
        {
            set
            {
                //validação
                if (value < 0)
                    throw new ArgumentException("Infome preço maior que zero");
                _quantidade = value;
            }
            get => _quantidade;
        }


        // public DateTime? DataCompra { get => _dataCompra; set => _dataCompra = value;}    
        public DateTime DataCompra
        {
            set => _dataCompra = value;
            get => _dataCompra;
        }

        #endregion


    }
}
