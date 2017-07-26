using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace geradorTimes.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Posicao { get; set; }

        [Required]
        public int Nivel { get; set; }

        public bool Ativo { get; set; }

        public Time Time { get; set; }
    }
}