using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_project.Models;

namespace Final_project.Logic
{
    public class AddPersons
    {
        public bool AddPerson(string PersonName, 
                              string PersonSurname, 
                              string PersonAge,
                              string PersonHeight,
                              string PersonWeight, 
                              string ImagePath,
                              string PersonLegLength,
                              string PersonShoeSize, 
                              string PersonGender)
        {
            var myPerson = new Person();
            myPerson.PersonName = PersonName;
            myPerson.PersonSurname = PersonSurname;
            myPerson.PersonAge = Convert.ToInt32(PersonAge);
            myPerson.PersonHeight = Convert.ToInt32(PersonHeight);
            myPerson.PersonWeight = Convert.ToInt32(PersonWeight);
            myPerson.ImagePath = ImagePath;
            myPerson.PersonLegLength = Convert.ToInt32(PersonLegLength);
            myPerson.PersonShoeSize = Convert.ToInt32(PersonShoeSize);
            myPerson.GenderID = Convert.ToInt32(PersonGender);

            using (PersonContext _db = new PersonContext())
            {
                _db.Persons.Add(myPerson);
                _db.SaveChanges();
            }

            return true;
        }
    }
}