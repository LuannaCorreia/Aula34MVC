using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Models;
using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Views;

namespace Aula_34_Aplicando_MVC_em_um_projeto_de_console.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar() {
            produtoView.MostrarNoConsole( produtoModel.Ler() );
        }
    }
}