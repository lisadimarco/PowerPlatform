using System;
using System.Collections.Generic;
using System.IO;
using Corso.Person;

namespace Corso.DataLayer
{
    public class PersonReader
    {
        public List<PersonDTO> GetPerson()
        {
            string filePath = @"C:\Coding\EserciziEsamatic\persone.txt";
            List<PersonDTO> people = new List<PersonDTO>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Il file delle persone non esiste.", filePath);
            }

            string[] righe = File.ReadAllLines(filePath);

            if (righe.Length > 0)
            {
                foreach (string riga in righe)
                {
                    string[] parti = riga.Split('|');

                    if (parti.Length == 4)
                    {
                        int id = int.Parse(parti[0]);
                        string nome = parti[1];
                        string cognome = parti[2];
                        int eta = int.Parse(parti[3]);

                        PersonDTO person = new PersonDTO(id, nome, cognome, eta);
                        people.Add(person);
                    }
                }
            }
            return people;
        }
    }
}
