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

        //Get all person querying by gender.
        public IQueryable<Person> GetPersons([QueryString("id")] int? genderId)
        {
            var _db = new Final_project.Models.DefaultContext();
            IQueryable<Person> query = _db.Persons;
            if (genderId.HasValue && genderId > 0) 
            {
                query = query.Where(p => p.GenderID == genderId);
            }
            return query;
        }

        //Get gender status from table.
        public IQueryable<Gender> GetGenders()
        {
            var _db = new Final_project.Models.DefaultContext();
            IQueryable<Gender> query = _db.Genders;
            return query;
        }
    }
}