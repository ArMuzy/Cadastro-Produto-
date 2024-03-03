using CadastroProduto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Controllers
{
    public class FornecedorController
    {
        public void CadastrarFornecedor()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE FORNECEDOR\n");

                var fornecedor = new Fornecedor()
                {
                    IdFornecedor = Guid.NewGuid()
                };

                Console.WriteLine("\nINFORME NOME DO FORNECEDOR\n");
                fornecedor.Nome = Console.ReadLine();
            } 
            catch(Exception e)
            {
                Console.WriteLine("\nFALHA AO CADASTRAR FORNECEDOR\n");
                Console.WriteLine(e.Message); 
            }
           
                

                    
        }
    }
}

