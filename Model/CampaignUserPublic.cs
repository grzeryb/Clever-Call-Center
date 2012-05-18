using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    public partial class CampaignUser
    {      
        [Column(Storage = "_campaignUserROWGUID", IsDbGenerated = true, IsPrimaryKey = true)]
        public Guid CampaignUserROWGUID
        {
            get { return this._campaignUserROWGUID; }
        }

        [Column(Storage = "_campaignROWGUID")]
        public Guid CampaignROWGUID
        {
            get { return this._campaignROWGUID; }
        }

        [Column(Storage = "_userROWGUID")]
        public Guid UserROWGUID
        {
            get { return this._userROWGUID; }
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

        [Association(Storage = "_campaign", ThisKey = "CampaignROWGUID", OtherKey = "CampaignROWGUID", IsForeignKey = true)]
        public Campaign Campaign
        {
            get { return this._campaign.Entity; }
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
    }
}
