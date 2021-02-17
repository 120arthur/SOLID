using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Controllers;
using System.Collections.Generic;
using System.Linq;


namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    class LeilaoDaoComEfCore : ILeilaoDao
    {
        AppDbContext _context;

        public LeilaoDaoComEfCore ()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes
                 .Include(l => l.Categoria)
                .ToList();
        }
        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(l => l.Id == id);
        }
        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }
        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }
    }
}
