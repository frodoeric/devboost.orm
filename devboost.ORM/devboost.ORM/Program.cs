using devboost.ORM.Data.Context;
using devboost.ORM.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace devboost.ORM
{
    public class Program
    {
        static void Main(string[] args)
        {
            OpenSqlConnection();
        }

        private static void OpenSqlConnection()
        {
            using (var context = new DataContext())
            {
                var jogador = new Jogador
                {
                    Nome = "Shakespeare",
                    Clube = new Clube()
                    {
                        Nome = "Palmeiras"
                    },
                    Posicao = new Posicao()
                    {
                        Nome = "Goleiro"
                    }
                };
                context.Add(jogador);
                context.SaveChanges();
            }
        }

    }
}
