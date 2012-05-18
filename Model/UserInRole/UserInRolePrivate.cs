using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "dbo.UsersInRoles")]
    public partial class UserInRole
    {

        private Guid _userInRoleROWGUID;
        private Guid _userROWGUID;
        private Guid _roleROWGUID;
        private DateTime _timeOfCreation;
        private DateTime _timeOfModification;
        private EntityRef<User> _user;
        private EntityRef<Role> _role;
    }
}
