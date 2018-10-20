using System;
using SQLite;

namespace ExemploBD
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("id"), PrimaryKey(), AutoIncrement()]
        public string Id
        {
            get;
            set;
        }
        [Column("nome")]
        public string Nome
        {
            get;
            set;
        }
        [Column("cidade")]
        public string Cidade
        {
            get;
            set;
        }
        [Column("classe")]
        public string Classe
        {
            get;
            set;
        }
    }
}
