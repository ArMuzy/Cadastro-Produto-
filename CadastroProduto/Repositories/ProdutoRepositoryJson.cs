using CadastroProduto.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Repositories
{
    /// <summary>
    /// 1º public: troca visibilidade p/ public
    /// 2º ProdutoRepository => Herda 
    /// 3º implementa classe abstrata override (clica em ctrl + ponto) seleciona => implementar interface para aparecer o método
    /// 4º Instala biblioteca : Newtonsoft.Json
    /// Passos: Direito mouse em projeto (CadastroProduto) > Gerencioado de pacotes do Nuget> aba Procurar> digtar na lupa o nome 
    /// 5º.=> Apaga => throw new NotImplementedException();
    /// 5º.1=> No lugar digita: 
    /// 6ºTEMOS QUE VOLTAR NO ProdutoController para terminar o programa
    /// 
    /// </summary>
    public class ProdutoRepositoryJson : ProdutoRepository //1º e 2º
    {
        public override void Exportar(Produto produto) //3º
        {
            

            // 5º e 5º.1 => serializando os dados do profissional para formato JSON
            var json = JsonConvert.SerializeObject
           (produto, Formatting.Indented);
            //gravar em arquivo
            var streamWriter = new StreamWriter
           ("c:\\temp\\produto.json");
            streamWriter.WriteLine(json);
            streamWriter.Close(); //4º e 4º.1

        }
    }
}
