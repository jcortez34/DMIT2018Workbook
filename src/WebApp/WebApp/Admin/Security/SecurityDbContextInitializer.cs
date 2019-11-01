using DemoSystem.BLL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Admin.Security
{
    public class SecurityDbContextInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
      protected override void Seed (ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            roleManager.Create(new IdentityRole { Name = "Administrators" });
            roleManager.Create(new IdentityRole { Name = "Registered Users" });

            

            var adminUser = new ApplicationUser
            {
                UserName = "WebAdmin",
                Email = "Administartor@email.com",
                EmailConfirmed = true
            };

            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var result = userManager.Create(adminUser, "Pa$$word");
            if(result.Succeeded)
            {
                var adminId = userManager.FindByName("WebAdmin").Id;
                userManager.AddToRole(adminId, "Administrators");
            }


            var demoManager = new DemoContoller();
            var people = demoManager.ListPeople();
            foreach(var person in people)
            {
                var user = new ApplicationUser
                {
                    UserName = $"{person.FirstName}.{person.LastName}",
                    Email = $"{person.FirstName}.{person.LastName}.email.com",
                    EmailConfirmed = true,
                    PersonId = person.PersonID
                };

                result = userManager.Create(user, "Pa$$word");
                if(result.Succeeded)
                {
                    var userId = userManager.FindByName(user.UserName).Id;
                    userManager.AddToRole(userId, "Registered Users");
                }
            }

            base.Seed(context);
        }

    }
}