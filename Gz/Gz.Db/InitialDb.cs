using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gz.Db
{
   public class InitialDb: CreateDatabaseIfNotExists<GzContext>
    {
        protected override void Seed(GzContext context)
        {
            var role = new TRole() { Id = Guid.NewGuid().ToString(), RoleName = "管理员" };
            var user = new TUser() { Id = Guid.NewGuid().ToString(), UserName = "admin", CreateTime = DateTime.Now, RoleId = role.Id, Status = 0 };
            context.TRoles.Add(role);
            context.TUsers.Add(user);
            context.SaveChanges();
        }
    }
}
