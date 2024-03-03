using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroProduto.Entities
{
    public class Fornecedor
    {
        #region Atributos 
        private Guid _idFornecedor;
        private string? _nome;
        private string? _cnpj;
        #endregion

        #region Propriedades
        // public Guid? IdFornecedor { get => _idFornecedor; set => _idFornecedor = value; }
       //origatório
        public Guid IdFornecedor
        {
            set => _idFornecedor = value;
            get => _idFornecedor;
        }


        //public string? Nome { get => _nome; set => _nome = value; }

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

        //public string? Cnpj { get => _cnpj; set => _cnpj = value; }
        public string? Cnpj
        {
            set
            {
             
                //Validar dados :Os caracteres que aceitam 
                var regex = new Regex("^[0-9\\s]{14,14}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Informe um CNPJ válido com 14 caracteres.");

                _cnpj = value;
            }
            get => _cnpj;
        }

        #endregion
    }


}
