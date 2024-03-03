using CadastroProduto.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastroProduto.Repositories
{
    //1ºDigitei para herdar => : ProdutoRepository
    public class ProdutoRepositoryXml : ProdutoRepository
    {
        public override void Exportar(Produto produto)
        {
            var xmlSerializer = new XmlSerializer(typeof(Produto));

            var streamWriter = new StreamWriter
            ("c:\\temp\\produtol.xml");
            xmlSerializer.Serialize(streamWriter, produto);
            streamWriter.Close();


        }
    }
}
