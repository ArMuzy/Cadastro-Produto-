using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroProduto.Entities
{
    public class Categoria
    {
        #region Atributos
        private Guid _idCategoria;
        private string? _descricao;
        #endregion

        #region Propriedades
        //public Guid? IdCategoria { get => _idCategoria; set => _idCategoria = value;}

        public Guid IdCategoria
        {
            set => _idCategoria = value;
            get => _idCategoria;
        }

        //public string? Descricao { get => _descricao; set => _descricao = value;}

        public string? Descricao
        {
            set
            {

                //Validar dados :Os caracteres que aceitam 
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Informe nome válido somente texto, de 6 a 150 caracteres");

                _descricao = value;
            }
            get => _descricao;
        }
        #endregion

    }
}
