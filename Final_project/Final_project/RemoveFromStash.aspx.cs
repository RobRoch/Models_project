﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using Final_project.Logic;

namespace Final_project
{
    public partial class RemoveFromStash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawID = Request.QueryString["personID"];
            string stashedRawID = Request.QueryString["stashedFavoriteID"];
            int personID;

            if (!String.IsNullOrEmpty(rawID) && int.TryParse(rawID, out personID))
            {
                using (StashedActions usersStashed = new StashedActions())
                {
                    usersStashed.RemoveFromStash(stashedRawID,Convert.ToInt16(rawID));
                }
            }
            else
            {
                Debug.Fail("ERROR : No PersonID while connecting to RemoveFromStash.aspx.");
                throw new Exception("ERROR : It is illegal to load AddToStash.aspx without setting a PersonID.");
            }
            Response.Redirect("Stashed.aspx");
        }
    }
}