using geradorTimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace geradorTimes.DAO
{
    public class JogadorDAO
    {
        public void Adiciona(Jogador jogador)
        {
            using (var context = new GeradorContext())
            {
                context.Jogadores.Add(jogador);
                context.SaveChanges();
            }
        }

        public IList<Jogador> Lista()
        {
            using (var context = new GeradorContext())
            {
                return context.Jogadores.ToList();
            }
        }
    }
}