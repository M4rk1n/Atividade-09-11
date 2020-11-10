using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ATIVIDADE
{
    public class Endereco :  Cidade
    {
        public string  Rua { get; set; }
        public int numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

       
        
    }
}
