using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    public partial class RecordGroup
    {

        [Column(Storage = "_recordGroupROWGUID", IsPrimaryKey = true)]
        public Guid RecordGroupROWGUID
        {
            get { return this._recordGroupROWGUID; }
            set
            {
                if (this._recordGroupROWGUID != value)
                {
                    this._recordGroupROWGUID = value;
                }
            }
        }

        [Column(Storage = "_name", CanBeNull = false)]
        public string Name
        {
            get { return this._name; }
            set
            {
                if (this._name != value)
                {
                    this._name = value;
                }
            }
        }

        [Column(Storage = "_description", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
        public string Description
        {
            get { return this._description; }
            set
            {
                if (this._description != value)
                {
                    this._description = value;
                }
            }
        }

        [Column(Storage = "_userROWGUID")]
        public Guid? UserROWGUID
        {
            get { return this._userROWGUID; }
            set
            {
                if (this._userROWGUID != value)
                {
                    this._userROWGUID = value;
                }
            }
        }

        [Column(Storage = "_timeOfCration")]
        public DateTime timeOfCreation
        {
            get { return this._timeOfCreation; }
        }

        [Column(Storage = "_timeOfModification")]
        public DateTime TimeOfModification
        {
            get { return this._timeOfModification; }
            set
            {
                if (this._timeOfModification != value)
                {
                    this._timeOfModification = value;
                }
            }
        }

        [Association(Storage = "_user", ThisKey = "UserROWGUID", OtherKey = "UserROWGUID", IsForeignKey = true)]
        public User User
        {
            get { return this._user.Entity; }
            set
            {
                User previousValue = this._user.Entity;
                if ((previousValue != value) || (this._user.HasLoadedOrAssignedValue == false))
                {
                    if (previousValue != null)
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
                        this._userROWGUID = default(Guid?);
                    }
                }
            }
        }

        [Association(Storage = "_records", ThisKey = "RecordGroupROWGUID", OtherKey = "RecordGroupROWGUID", DeleteRule = "NO ACTION")]
        public EntitySet<Record> Records
        {
            get { return this._records; }
            set
            {
                this._records.Assign(value);
            }
        }
    }
}
