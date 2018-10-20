using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ExampleWebServices
{
    [DataContract]
    public class ListagemFotos
    {
        [DataMember(Name = "photos")]
        public List<String> Fotos;
    }
}
