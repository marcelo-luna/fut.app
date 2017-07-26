using geradorTimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace geradorTimes.DAO
{
    public class TimeDAO
    {
        public void Adiciona(Time time)
        {
            using (var context = new GeradorContext())
            {
                context.Times.Add(time);
                context.SaveChanges();
            }
        }

        public IList<Time> Lista()
        {
            using (var context = new GeradorContext())
            {
                return context.Times.ToList();
            }
        }

        public IList<Jogador> ListaTimeJogador()
        {
            using (var context = new GeradorContext())
            {
                return context.Jogadores.Include("Time").ToList();
            }
        }
    }
}