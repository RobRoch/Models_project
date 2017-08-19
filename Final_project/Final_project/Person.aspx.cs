using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.Models;
using System.Web.ModelBinding;

namespace Final_project
{
    public partial class Model : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Person> GetPersons([QueryString("id")] int? genderId)
        {
            var _db = new Final_project.Models.PersonContext();
            IQueryable<Person> query = _db.Persons;
            if (genderId.HasValue && genderId > 0) 
            {
                query = query.Where(p => p.GenderID == genderId);
            }
            return query;
        }

        public IQueryable<Gender> GetGenders()
        {
            var _db = new Final_project.Models.PersonContext();
            IQueryable<Gender> query = _db.Genders;
            return query;
        }
    }
}