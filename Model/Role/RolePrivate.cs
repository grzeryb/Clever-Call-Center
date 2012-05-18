using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "dbo.Roles")]
    public partial class Role
    {
        private Guid _roleROWGUID;
        private string _name;
        private DateTime _timeOfCreation;
        private DateTime _timeOfModification;
    }
}
