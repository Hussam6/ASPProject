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

            using (MasterEntityLogin db = new MasterEntityLogin())
            {
                try {
                    UserLoginTable ult = new UserLoginTable();
                    ult.UserName = userSignUpView.UserName;
                    ult.Password = userSignUpView.password;
                    ult.City = userSignUpView.cityName;
                    ult.Email = userSignUpView.email;

                    db.UserLoginTables.Add(ult);
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