using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_project.Models;

namespace Final_project.Logic
{
    public class StashedActions : IDisposable
    {
        
        public string StashedID { get; set; }

        private PersonContext _db = new PersonContext();

        public const string StashedSessionKey = "StashedFavoriteID";

        //Adding to stash favoritePerson from Persons.
        public void AddToStash(int id)
        {
            StashedID = GetStashedID();

            //Get favoritepersons from db with StashedID and PersonID.
            var favoritePerson = _db.StashedFavoritePersons.SingleOrDefault(
                c => c.StashedFavoriteID == StashedID
                && c.PersonID == id);

            // Creating instance of FavoritePerson if it doesn't exist.
            if (favoritePerson == null)
            {
                favoritePerson = new FavoritePerson
                {
                    FavoritePersonID = Guid.NewGuid().ToString(),
                    StashedFavoriteID = StashedID,
                    PersonID = id,
                    Person = _db.Persons.SingleOrDefault(
                        p => p.PersonID == id),
                    DateCreated = DateTime.Now
                };
                _db.StashedFavoritePersons.Add(favoritePerson);
            }
            //VERY IMPORTANT - need to save changes in PersonContext.
            _db.SaveChanges();
        }

        //Removing person from stash.
        public void RemoveFromStash(string removeStashedFavoriteID, int removePersonID)
        {
            using (var _db = new Final_project.Models.PersonContext())
            {
                try
                {
                    //Finding myFavoritePerson in db if exists.
                    var myFavoritePerson = (from c 
                                            in _db.StashedFavoritePersons
                                            where c.PersonID == removePersonID && c.StashedFavoriteID == removeStashedFavoriteID
                                            select c).FirstOrDefault();
                    if (myFavoritePerson != null)
                    {
                        _db.StashedFavoritePersons.Remove(myFavoritePerson);
                        //Remember to save changes!
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to remove person - " + exp.Message.ToString(), exp);
                }
            }
        }

        //IDisposable - releasing resources immediately, when we don't use it. It's .net framework pattern.
        //It's like good practise to do it, if it doesn't need to cleanup it won't do nothing. 
        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        //Get StashedID depending of registered user or non registered user [session].
        public string GetStashedID()
        {
            //var stashedSession = HttpContext.Current.Session[StashedSessionKey];
            //var identity = HttpContext.Current.User.Identity.Name;
            if (HttpContext.Current.Session[StashedSessionKey] == null)
            {
                if(!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[StashedSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    //Ensures creation of one stash per user on session.
                    Guid tempStashedID = Guid.NewGuid();
                    HttpContext.Current.Session[StashedSessionKey] = tempStashedID.ToString();
                }
            }
            return HttpContext.Current.Session[StashedSessionKey].ToString();
        }
        
        //Get FavoritePersons with same StashedID.
        public List<FavoritePerson> GetFavoritePersons()
        {
            StashedID = GetStashedID();

            return _db.StashedFavoritePersons.Where(p => p.StashedFavoriteID == StashedID).ToList();
        }

        //Empty stash while logging or registering.
        public void EmptyStash()
        {
            StashedID = GetStashedID();
            var favoritePersons = _db.StashedFavoritePersons.Where(
                p => p.StashedFavoriteID == StashedID);
            foreach (var favoritePerson in favoritePersons)
            {
                _db.StashedFavoritePersons.Remove(favoritePerson);
            }
            _db.SaveChanges();
        }

        ////Don't need it i guess;
        //public StashedActions GetStash(HttpContext context)
        //{
        //    using (var stash = new StashedActions())
        //    {
        //        stash.StashedID = stash.GetStashedID();
        //        return stash;
        //    }
        //}

        //Assign stash to user.
        public void UserStash(string stashID, string userName)
        {
            var stash = _db.StashedFavoritePersons.Where(p => p.StashedFavoriteID == stashID);
            foreach (FavoritePerson person in stash)
            {
                person.StashedFavoriteID = userName;
            }
            HttpContext.Current.Session[StashedSessionKey] = userName;
            _db.SaveChanges();
        }

    }
}