using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio{
    public class Buses{
        public int id {get;set;}
        [Required, StringLength(10,  MinimumLength = 5, ErrorMessage = "Maximo 10 characters")]
        public string marca {get;set;}
        public int modelo {get;set;}
        public int kilometraje{get;set;}
        public int numero_asientos{get;set;}
        public string placa {get;set;}

    }

}