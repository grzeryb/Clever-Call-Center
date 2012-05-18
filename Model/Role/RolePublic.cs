using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    public partial class Role
    {
        [Column(Storage = "_roleROWGUID", IsPrimaryKey = true)]
        public Guid RoleROWGUID
        {
            get { return this._roleROWGUID; }
        }

        [Column(Storage = "_name", CanBeNull = false)]
        public string Name
        {
            get { return this._name; }
        }

        [Column(Storage = "_timeOfCreation")]
        public DateTime TimeOfCreation
        {
            get { return this._timeOfCreation; }
        }

        [Column(Storage = "_timeOfModification")]
        public DateTime TimeOfModification
        {
            get { return this._timeOfModification; }
        }
    }
}
