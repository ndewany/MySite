﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace MySite.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationUserAdmin : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MySiteUsersConnectionString")
        {
        }
    }

    public class ApplicationDbContextAdmin : IdentityDbContext<ApplicationUserAdmin>
    {
        public ApplicationDbContextAdmin()
            : base("MySiteAdminUsersConnectionString")
        {
        }
    }
}