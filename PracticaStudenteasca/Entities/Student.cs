using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaStudenteasca.Entities
{
    class Student:User
    {
        Grupa grupa;
        Firma firma;
        int nota;

        public Grupa Grupa { get => grupa; set => grupa = value; }
        public Firma Firma { get => firma; set => firma = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
