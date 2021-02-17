using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.WebApp.Dados
{
   public interface ILeilaoDao
    {
        public IEnumerable<Leilao> BuscarLeiloes();
        public IEnumerable<Categoria> BuscarCategorias();
        public Leilao BuscarPorId(int id);
        public void Excluir(Leilao leilao);
        public void Incluir(Leilao leilao);
        public void Alterar(Leilao leilao);
    }
}
