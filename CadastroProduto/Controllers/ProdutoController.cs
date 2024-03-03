using CadastroProduto.Entities;
using CadastroProduto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Controllers
{
    public class ProdutoController
    {
        //classe realiza fluxo de cadastro de produto realiza entrada(captura) de dados
        
        //public void : método que não retorna nenhum valor
        public void CadastrarProduto() 
        {
            //Trata erro em tempo de execução do projeto try e catch 

            //2º- try: Caminho feliz 
            try
            {

                /// <summary>
                ///3ºDigitar: Console.WriteLine("\nCADASTRO DE PRODUTO\n");
                ///Console.WriteLine : método statico
                /// </summary>
                Console.WriteLine("\nCADASTRO DE PRODUTO\n");


                /// <summary>
                ///4º-Digitar: var produto = new Produto()
                ///EXPLICAÇÃO:
                ///4º.1- Declarando variavel produto:  var produto 
                ///4º.2-Recebendo a Classe produto: = new Produto()
                ///OBS.:Criando objeto(variável de instãncia),
                ///é a mesma coisa que Instanciando produto (criando espaço de memória
                ///
                /// 4º.3-Inserir using entities :using CadastroProduto.Entities;
                /// </summary>
                var produto = new Produto()
                {
                    /// <summary>
                    ///5º-Digitar:IdProduto = Guid.NewGuid(),
                    ///5º.1-Digitar:  DataCompra = DateTime.Now };
                    ///OBS.:Campos seram gerados automaticamente
                    ///OBS.: Método statico:  Guid.NewGuid()
                    /// </summary>
                    IdProduto = Guid.NewGuid(),
                    DataCompra = DateTime.Now
                };


                    /// <summary>
                    ///6º-Digitar: Console.Write("NOME DO CLIENTE...:");
                    ///OBS.:Imprimir e manter cursor na mesma linha : Console.Write
                    /// </summary>
                    Console.Write("NOME DO PRODUTO...:");

                    /// <summary>
                   ///7º-Digitar: cliente.Nome = Console.ReadLine();
                   ///OBS.:Captura o que o usuário digitou depois do enter ReadLine();
                  /// </summary>
                  produto.Nome = Console.ReadLine();

                /// <summary>
                ///8º-Digitar: Console.Write("PREÇO DO PRODUTO...:");
                ///OBS.:Imprimir e manter cursor na mesma linha : Console.Write
                /// </summary>
                Console.Write("PREÇO DO PRODUTO...:");

                /// <summary>
                ///9º-Digitar:  produto.Preco = double.Parse(Console.ReadLine());
                ///OBS.:Captura o que o usuário digitou depois do enter ReadLine();
                /// </summary>
                produto.Preco =double.Parse(Console.ReadLine());

                /// <summary>
                ///10º-Digitar: Console.Write("QUANTIDADE DO PRODUTO...:");
                ///OBS.:Imprimir e manter cursor na mesma linha : Console.Write
                /// </summary>
                Console.Write("QUANTIDADE DO PRODUTO...:");

                /// <summary>
                ///11º-Digitar:  produto.Quantidade = double.Parse(Console.ReadLine());
                ///OBS.:Captura o que o usuário digitou depois do enter ReadLine();
                /// </summary>
                produto.Quantidade = int.Parse(Console.ReadLine());

                /// <summary>
                ///13º e 13º.1 - Digito
                ///14º coloco o using: using CadastroProduto.Repositories;
                /// </summary>

                //Gerando os dados em XML
                var profissionalRepositoryXml //13º
               = new ProdutoRepositoryXml();
                profissionalRepositoryXml.Exportar(produto);

                //Gerando os dados em JSON
                var profissionalRepositoryJson //13º.1
               = new ProdutoRepositoryJson();
                profissionalRepositoryJson.Exportar(produto);
                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO.");


            }
            /// <summary>
            ///12º-Digitar:Todos os  catchs(pega erros)
            ///OBS.: PRIMEIRO catch usado p/ erro EXPECÍFICO neste caso na vaildação: catch (ArgumentException e) 
            ///OBS.: SEGUNDO catch p/ erro GENÉRICO : catch (Exception e) 
            ///OBS.: catch genérico se coloca por último
            /// </summary>
            catch (ArgumentException e)
            {
                Console.WriteLine("\nOCORREU UM ERRO DE VALIDAÇÃO!");
                Console.WriteLine(e.Message);
            
            }
            catch(Exception e) 
            {
                Console.WriteLine("\nFALHA AO CADASTRAR PRODUTO!");
                Console.WriteLine(e.Message);
            
            }

            
        
        }
        

    }
}
