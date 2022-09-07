using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateEnderecoDto
    {
        [Required(ErrorMessage = "O campo de Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo de Bairro é obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo de Numero é obrigatório")]
        public int Numero { get; set; }
    }
}
