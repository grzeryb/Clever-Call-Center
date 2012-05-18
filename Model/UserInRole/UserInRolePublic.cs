using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    public partial class UserInRole
    {
        public UserInRole()
        {
            _timeOfCreation = DateTime.Now;
            _timeOfModification = DateTime.Now;
        }

        [Column(Storage = "_userInRoleROWGUID", CanBeNull = false, IsDbGenerated = true, IsPrimaryKey = true)]
        public Guid UserInRoleROWGUID
        {
            get { return this._userInRoleROWGUID; }
        }

        [Column(Storage = "_roleROWGUID")]
        public Guid RoleROWGUID
        {
            get { return this._roleROWGUID; }
            set { _roleROWGUID = Guid.NewGuid(); }
        }

        [Column(Storage = "_userROWGUID")]
        public Guid UserROWGUID
        {
            get { return this._userROWGUID; }
        }

        [Column(Storage = "_timeOfCreation", CanBeNull = false)]
        public DateTime TimeOfCreation
        {
            get { return this._timeOfCreation; }
        }

        [Column(Storage = "_timeOfModification", CanBeNull = false)]
        public DateTime TimeOfModification
        {
            get { return this._timeOfModification; }
            set
            {
                _timeOfModification = value;
            }
        }

        [Association(Storage = "_role", ThisKey = "RoleROWGUID", OtherKey = "RoleROWGUID", IsForeignKey = true)]
        public Role Role
        {
            get
            {
                return this._role.Entity;
            }
            set
            {
                Role previousValue = this._role.Entity;
                if ((previousValue != value) || (this._role.HasLoadedOrAssignedValue == false))
                {
                    if ((previousValue != null))
                    {
                        this._role.Entity = null;
                    }
                    this._role.Entity = value;
                    if (value != null)
                    {
                        this._roleROWGUID = value.RoleROWGUID;
                    }
                    else
                    {
                        this._roleROWGUID = default(Guid);
                    }
                }
            }
        }

        [Association(Storage = "_user", ThisKey = "UserROWGUID", OtherKey = "UserROWGUID", IsForeignKey = true)]
        public User User
        {
            get
            {
                return this._user.Entity;
            }
            set
            {
                User previousValue = this._user.Entity;
                if ((previousValue != value) || (this._user.HasLoadedOrAssignedValue == false))
                {
                    if ((previousValue != null))
                    {
                        this._user.Entity = null;
                    }
                    this._user.Entity = value;
                    if (value != null)
                    {
                        this._userROWGUID = value.UserROWGUID;
                    }
                    else
                    {
                        this._userROWGUID = default(Guid);
                    }
                }
            }
        }
    }
}
