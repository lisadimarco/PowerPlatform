using System;
using System.Collections.Generic;
using Corso.DataLayer;
using Corso.Person;

namespace Corso.FrontC
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonReader personReader = new PersonReader();

            try
            {
                List<PersonDTO> people = personReader.GetPerson();

                if (people.Count > 0)
                {
                    Console.WriteLine("ID | Nome      | Cognome       | Eta' ");
                    Console.WriteLine("----------------------------------------");

                    foreach (var person in people)
                    {
                        Console.WriteLine($"{person.ID,-3} | {person.Nome,-10} | {person.Cognome,-12} | {person.Eta}");
                    }
                }
                else
                {
                    Console.WriteLine("Nessuna persona trovata.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
