using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace projeto_destino_certo.Models
{
    public class Usuario
    {   
        public int id {get; set;}
        public string nome {get; set;}
        public string data_nascimento {get; set;}
        public string senha {get; set;}
        public string conta {get; set;}
        public string login {get; set;}
    }
}