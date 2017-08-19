using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.Logic;
using System.Text.RegularExpressions;

namespace Final_project
{
    public partial class JoinUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["PersonAdd"] == "add")
            {
                LabelAddStatus.Text = "Ok, we have added You as one of our models.";
            }
        }

        protected void FormValidation(object source, ServerValidateEventArgs args)
        {

            Regex nameReg = new Regex(@"^[A-Z]+[a-z]{2,15}$");
            Regex numReg = new Regex(@"[0-9]+");

            //Validate name;
            if (string.IsNullOrEmpty(AddPersonName.Text))
            {
                AddPersonName.Focus();
                joinUsValidator.Text = "You forgot your name?";
                args.IsValid = false;
                return;
            }
            else if (!nameReg.IsMatch(AddPersonName.Text))
            {
                AddPersonName.Focus();
                joinUsValidator.Text = "That's not a real name.";
                args.IsValid = false;
                return;
            }

            //Validate surname
            if (string.IsNullOrEmpty(AddPersonSurname.Text))
            {
                AddPersonSurname.Focus();
                joinUsValidator.Text = "You forgot your surname?";
                args.IsValid = false;
                return;
            }
            else if (!nameReg.IsMatch(AddPersonSurname.Text))
            {
                AddPersonSurname.Focus();
                joinUsValidator.Text = "That's not a real surname.";
                args.IsValid = false;
                return;
            }

            //Validate age
            if (string.IsNullOrEmpty(AddPersonAge.Text))
            {
                AddPersonAge.Focus();
                joinUsValidator.Text = "Please, type your age.";
                args.IsValid = false;
                return;
            }
            else if (!numReg.IsMatch(AddPersonAge.Text))
            {
                AddPersonAge.Focus();
                joinUsValidator.Text = "We should type age in numbers right?";
                args.IsValid = false;
                return;
            }
            else if (int.Parse(AddPersonAge.Text) < 10 || int.Parse(AddPersonAge.Text) > 70)
            {
                AddPersonAge.Focus();
                joinUsValidator.Text = "You are too old/young?";
                args.IsValid = false;
                return;
            }
            else if (int.Parse(AddPersonAge.Text) < 18 && AddPersonGender.SelectedValue != "3")
            {
                AddPersonGender.Focus();
                joinUsValidator.Text = "Are you a child?";
                args.IsValid = false;
                return;
            }
            else if (int.Parse(AddPersonAge.Text) > 18 && AddPersonGender.SelectedValue == "3")
            {
                AddPersonGender.Focus();
                joinUsValidator.Text = "Hey, you are not a child!";
                args.IsValid = false;
                return;
            }

            //Validate Height
            if (string.IsNullOrEmpty(AddPersonHeight.Text))
            {
                AddPersonHeight.Focus();
                joinUsValidator.Text = "Please, type your height.";
                args.IsValid = false;
                return;
            }
            else if (!numReg.IsMatch(AddPersonHeight.Text))
            {
                AddPersonHeight.Focus();
                joinUsValidator.Text = "We should type height in numbers right?";
                args.IsValid = false;
                return;
            }

            //Validate Weight
            if (string.IsNullOrEmpty(AddPersonWeight.Text))
            {
                AddPersonWeight.Focus();
                joinUsValidator.Text = "Please, type your weight.";
                args.IsValid = false;
                return;
            }
            else if (!numReg.IsMatch(AddPersonWeight.Text))
            {
                AddPersonWeight.Focus();
                joinUsValidator.Text = "We should type weight in numbers right?";
                args.IsValid = false;
                return;
            }

            //Validate leg length
            if (!numReg.IsMatch(AddPersonLegLength.Text) || int.Parse(AddPersonLegLength.Text) < 40 || int.Parse(AddPersonLegLength.Text) > 150)
            {
                AddPersonLegLength.Focus();
                joinUsValidator.Text = "Write leg length in cm.";
                args.IsValid = false;
                return;
            }

            //Validate photo

            bool photoOK = false;

            if (AddPersonImage.HasFile)
            {
                String fileExtensions = System.IO.Path.GetExtension(AddPersonImage.FileName).ToLower();
                String[] allowedExtensions = { ".png", ".jpg", ".jpeg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtensions == allowedExtensions[i])
                    {
                        photoOK = true;
                    }
                }
            }

            if(!photoOK)
            {
                AddPersonImage.Focus();
                joinUsValidator.Text = "It's wrong file extension.";
                args.IsValid = false;
                return;
            }

            // if args.IsValid then Page.IsValid either.
            if (!args.IsValid)
            {
                joinUsValidator.CssClass = "joinUs_alert, typewriter";
            }

            args.IsValid = true;
        }

        protected void AddPersonButton_click(object sender, EventArgs e)
        {
            String path = Server.MapPath("~/Catalog/Images/");


            //If everything is ok try to add model to db.
            if (Page.IsValid)
            {
                try
                {
                    AddPersonImage.PostedFile.SaveAs(path + AddPersonImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                AddPersons persons = new AddPersons();
                bool addSuccess = persons.AddPerson(AddPersonName.Text, 
                                                    AddPersonSurname.Text, 
                                                    AddPersonAge.Text, 
                                                    AddPersonHeight.Text, 
                                                    AddPersonWeight.Text, 
                                                    AddPersonImage.FileName, 
                                                    AddPersonLegLength.Text, 
                                                    AddPersonShoeSize.SelectedValue,
                                                    AddPersonGender.SelectedValue);

                if (addSuccess)
                {
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?PersonAdd=add");
                }
                else
                {
                    LabelAddStatus.Text = "We have some problems to add you right now.";
                }

            }
            else
            {
                LabelAddStatus.Text = "Well something is still wrong.";
            }
        }

        public IQueryable GetGender()
        {
            var _db = new Final_project.Models.PersonContext();
            IQueryable query = _db.Genders;
            return query;
        }

       
    }
}