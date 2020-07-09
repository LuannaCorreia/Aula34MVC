using System;
using Aula_34_Aplicando_MVC_em_um_projeto_de_console.Controllers;

namespace Aula_34_Aplicando_MVC_em_um_projeto_de_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // O controller é utilizado aqui pois ele é a classe que controla todo o projeto
            ProdutoController controller = new ProdutoController();
            controller.Listar();
        }
    }
}