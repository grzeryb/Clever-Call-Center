using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "dbo.RecordGroups")]
    public partial class RecordGroup
    {
        private Guid _recordGroupROWGUID;
        private string _name;
        private string _description;
        private Guid? _userROWGUID;
        private DateTime _timeOfCreation;
        private DateTime _timeOfModification;
        private EntityRef<User> _user;
        private EntitySet<Record> _records;
    }
}
