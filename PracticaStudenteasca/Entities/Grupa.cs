namespace PracticaStudenteasca.Entities
{
    internal class Grupa
    {
        string grupa;
        Profesor indrumator;

        public string NumeGrupa { get => grupa; set => grupa = value; }
        public Profesor Indrumator { get => indrumator; set => indrumator = value; }
    }
}