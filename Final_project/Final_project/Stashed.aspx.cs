using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.Logic;
using Final_project.Models;

namespace Final_project
{
    public partial class Stashed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //Get list of stashed favorite persons.
        public List<FavoritePerson> GetStashedFavoritePerson()
        {
            StashedActions actions = new StashedActions();

            //Checking if my List of favorite persons is empty.
            bool isEmpty = !actions.GetFavoritePersons().Any();
            if (isEmpty)
            {
                LabelStashed.Text = "You didn't choose your models yet.";
            }
            else
            {
                LabelStashed.Text = "Here are your favorite models.";
            }

            return actions.GetFavoritePersons();
        }
    }
}