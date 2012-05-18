using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "dbo.CampaignUser")]
    public partial class CampaignUser
    {
        private Guid _campaignUserROWGUID;
        private Guid _campaignROWGUID;
        private Guid _userROWGUID;
        private EntityRef<User> _user;
        private EntityRef<Campaign> _campaign;

    }
}
