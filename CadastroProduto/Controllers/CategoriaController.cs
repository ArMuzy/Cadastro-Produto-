using CadastroProduto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Controllers
{
    public class CategoriaController
    {
        public void CadastrarCategoria()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE CATEGORIA\n");

                var categoria = new Categoria()
                {
                    IdCategoria = Guid.NewGuid()
                };
                Console.WriteLine("\nINFORME DESCRIÇÃO DO PRODUTO:\n");
                categoria.Descricao = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("\nFALHA AO CADASTRAR  DESCRIÇÃO DO PRODUTO:");
                Console.WriteLine(e.Message);
            }
            
            

                

        }
    }
}
    

