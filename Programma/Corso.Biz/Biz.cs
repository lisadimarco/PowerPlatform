namespace Corso.Person
{
    public class PersonDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public PersonDTO(int id, string nome, string cognome, int punteggio)
        {
            ID = id;
            Nome = nome;
            Cognome = cognome;
            Eta = punteggio;
        }
    }
}
