using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ATIVIDADE
{
    public class Cliente : Endereco
    {
        public string nome { get; set; }
        
        public string cpf { get; set; }
    }
}
