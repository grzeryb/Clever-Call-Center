using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
namespace Clever_Call_Center.Model
{
    public partial class CoordinatorToCampaign
    {
        public CoordinatorToCampaign()
        {
            _timeOfCreation = DateTime.Now;
        }

        [Column(Storage = "_coordinatorsToCampaignROWGUID", IsPrimaryKey=true)]
        public Guid CoordinatorsToCampaignROWGUID
        {
            get { return this._coordinatorsToCampaignROWGUID; }
            set
            {
                if (this._coordinatorsToCampaignROWGUID != value)
                {
                    this._coordinatorsToCampaignROWGUID = value;
                }
            }
        }

        [Column(Storage = "_userROWGUID")]
        public Guid UserROWGUID
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

        [Column(Storage = "_campaignROWGUID")]
        public Guid CampaignROWGUID
        {
            get { return this._campaignROWGUID; }
            set
            {
                if (this._campaignROWGUID != value)
                {
                    this._campaignROWGUID = value;
                }
            }
        }

        [Column(Storage = "_timeOfCreation")]
        public DateTime TimeOfCreation
        {
            get { return this._timeOfCreation; }
        }

        [Association(Storage = "_campaign", ThisKey = "CampaignROWGUID", OtherKey = "CampaignROWGUID", IsForeignKey = true)]
        public Campaign Campaign
        {
            get
            {
                return this._campaign.Entity;
            }
            set
            {
                Campaign previousValue = this._campaign.Entity;
                if ((previousValue != value) || (this._campaign.HasLoadedOrAssignedValue == false))
                {
                    if (previousValue != null)
                    {
                        this._campaign.Entity = null;
                    }
                    this._campaign.Entity = value;
                    if (value != null)
                    {
                        this._campaignROWGUID = value.CampaignROWGUID;
                    }
                    else
                    {
                        this._campaignROWGUID = default(Guid);
                    }
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
