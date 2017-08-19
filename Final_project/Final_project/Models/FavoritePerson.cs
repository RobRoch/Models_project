using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_project.Models
{
    /*Favorite Person class connected to Person class, adding DateCreated (to show data) and 
    StashedID - connection to registered/logged user. */
    public class FavoritePerson
    {
        public string FavoritePersonID { get; set; }

        public string StashedFavoriteID { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}