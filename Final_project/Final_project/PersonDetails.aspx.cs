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
    public partial class PersonDetails : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //Get person detail information querying by ID.
        public IQueryable<Person> GetPerson([QueryString("personID")] int? personId)
        {
            var _db = new Final_project.Models.DefaultContext();
            IQueryable<Person> query = _db.Persons;
            if (personId.HasValue && personId > 0)
            {
                query = query.Where(p => p.PersonID == personId);
            }
            else
            {
                query = null;
            }
            return query;
        }

    }
}