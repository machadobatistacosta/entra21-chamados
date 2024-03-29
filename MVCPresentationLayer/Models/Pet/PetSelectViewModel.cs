﻿using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVCPresentationLayer.Models.Pet
{
    public class PetSelectViewModel
    {
        public int ID { get; set; }

        public string Nome { get; set; }
        public TipoPet Tipo { get; set; }
        [Display(Name = "Raça")]
        public string Raca { get; set; }

        public double Peso { get; set; }
        public string Cor { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
