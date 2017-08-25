using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Final_project.Models
{
    //Initializing database with 8 person and 3 genders.
    public class PersonDatabaseInitializer : DropCreateDatabaseIfModelChanges<DefaultContext>
    {
        protected override void Seed(DefaultContext context)
        {
            GetPersons().ForEach(p => context.Persons.Add(p));
            GetGenders().ForEach(p => context.Genders.Add(p));
        }

        private static List<Person> GetPersons()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    PersonID =1,
                    PersonName = "Kasia",
                    PersonSurname = "Mróz",
                    PersonAge = 25,
                    PersonHeight = 175,
                    PersonWeight = 54,
                    GenderID = 1,
                    ImagePath = "black_excited.png",
                    PersonLegLength = 88,
                    PersonShoeSize = 8,
                },
                new Person
                {
                    PersonID =2,
                    PersonName = "Robert",
                    PersonSurname = "Powiński",
                    PersonAge = 25,
                    PersonHeight = 193,
                    PersonWeight = 90,
                    GenderID = 2,
                    ImagePath = "big_smile.png",
                    PersonLegLength = 98,
                    PersonShoeSize = 5,
                },
                new Person
                {
                    PersonID =3,
                    PersonName = "Arthas",
                    PersonSurname = "Opacz",
                    PersonAge = 21,
                    PersonHeight = 163,
                    PersonWeight = 60,
                    GenderID = 2,
                    ImagePath = "forever_alone_face_only.png",
                    PersonLegLength = 88,
                    PersonShoeSize = 4,
                },
                new Person
                {
                    PersonID =4,
                    PersonName = "Piotr",
                    PersonSurname = "Kosibor",
                    PersonAge = 18,
                    PersonHeight = 180,
                    PersonWeight = 70,
                    GenderID = 2,
                    ImagePath = "happy_smile.png",
                    PersonLegLength = 78,
                    PersonShoeSize = 12,
                },
                new Person
                {
                    PersonID =5,
                    PersonName = "Katarzyna",
                    PersonSurname = "Bobicz",
                    PersonAge = 19,
                    PersonHeight = 175,
                    PersonWeight = 50,
                    GenderID = 1,
                    ImagePath = "blonde_fake_smile.png",
                    PersonLegLength = 68,
                    PersonShoeSize = 10,
                },
                new Person
                {
                    PersonID =6,
                    PersonName = "Olena",
                    PersonSurname = "Olenowa",
                    PersonAge = 13,
                    PersonHeight = 155,
                    PersonWeight = 45,
                    GenderID = 3,
                    ImagePath = "brunette_dude.png",
                    PersonLegLength = 56,
                    PersonShoeSize = 5,
                },
                new Person
                {
                    PersonID =7,
                    PersonName = "Paweł",
                    PersonSurname = "Pucz",
                    PersonAge = 18,
                    PersonHeight = 180,
                    PersonWeight = 70,
                    GenderID = 2,
                    ImagePath = "suspicious.png",
                    PersonLegLength = 98,
                    PersonShoeSize = 7,
                },
                new Person
                {
                    PersonID =8,
                    PersonName = "Krzysztof",
                    PersonSurname = "Bok",
                    PersonAge = 15,
                    PersonHeight = 190,
                    PersonWeight = 70,
                    GenderID = 3,
                    ImagePath = "horror.png",
                    PersonLegLength = 58,
                    PersonShoeSize = 8,
                }
            };
            return persons;
        }
        private static List<Gender> GetGenders()
        {
            var genders = new List<Gender>
            {
                new Gender
                {
                    GenderID = 1,
                    GenderName = "Female",           
                },
                new Gender
                {
                    GenderID = 2,
                    GenderName = "Male",
                },
                new Gender
                {
                    GenderID = 3,
                    GenderName = "Child",
                }
            };
            return genders;
        }
    }
}