using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    public partial class Campaign
    {
        public Campaign()
        {
            this._timeOfCreation = DateTime.Now;
            this._timeOfModification = DateTime.Now;
        }

        [Column(Storage = "_campaignROWGUID", CanBeNull = false, IsDbGenerated = true, IsPrimaryKey = true)]
        public Guid CampaignROWGUID
        {
            get { return this._campaignROWGUID; }
        }

        [Column(Storage = "_id", CanBeNull = false, IsDbGenerated = true)]
        public int Id
        {
            get { return this._id; }
        }

        [Column(Storage = "_userROWGUID", CanBeNull = false)]
        public Guid UserROWGUID
        {
            get { return this._userROWGUID; }
        }

        [Column(Storage = "_status", CanBeNull = false)]
        public string Status
        {
            get { return this._status; }
            set
            {
                if (this._status != value)
                {
                    this._status = value;
                }
            }
        }

        [Column(Storage = "_name", CanBeNull = false)]
        public string Name
        {
            get { return this._name; }
            set
            {
                if ((this._name != value))
                {
                    this._name = value;
                }
            }
        }

        [Column(Storage = "_description", CanBeNull = false)]
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

        [Column(Storage = "_campaignEndDate", CanBeNull = false)]
        public DateTime CampaignEndDate
        {
            get { return this._campaignEndDate; }
            set
            {
                if (this._campaignEndDate != value)
                {
                    this._campaignEndDate = value;
                }
            }
        }

        [Column(Storage = "_campaignStartDate", CanBeNull = false)]
        public DateTime CampaignStartDate
        {
            get { return this._campaignStartDate; }
            set
            {
                if (this._campaignStartDate != value)
                {
                    this._campaignStartDate = value;
                }
            }
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
                        this._userROWGUID = default(Guid);
                    }
                }
            }
        }
    }
}
