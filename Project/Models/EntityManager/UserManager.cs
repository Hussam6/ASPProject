using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Models.DB;
using Project.Models.ViewModel;
using System.Data.Entity.Validation;

namespace Project.Models.EntityManager
{
    public class UserManager

        //Add user to the database
    {
        public void addUserAccount(UserSignUpView userSignUpView) {

            
            using (FinalRegEntity db = new FinalRegEntity())
            {
                try {

                    registrationTable reg = new registrationTable();
                   
                    reg.UserName = userSignUpView.UserName;
                    reg.Password = userSignUpView.password;
                    reg.Email = userSignUpView.email;
                    reg.Longitude= userSignUpView.longitude;
                    reg.Latitude = userSignUpView.latitude;

                    db.registrationTables.Add(reg);
                    db.SaveChanges();




                }

                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                

            }
        }
    }
}