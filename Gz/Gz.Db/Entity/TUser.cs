using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gz.Db
{
    [Table("TUser")]
    public class TUser
    {
        [Key]
        public string Id { get; set; }

        public string UserName { get; set; }

        public int Status { get; set; }

        public string RoleId { get; set; }

        public DateTime CreateTime { get; set; }

        public string CreateUserId { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string UpdateUserId { get; set; }
    }
}
