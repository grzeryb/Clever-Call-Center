using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "dbo.CoordinatorsToCampaign")]
    public partial class CoordinatorToCampaign
    {
        private Guid _coordinatorsToCampaignROWGUID;
        private Guid _userROWGUID;
        private Guid _campaignROWGUID;
        private DateTime _timeOfCreation;
        private EntityRef<Campaign> _campaign;
        private EntityRef<User> _user;
    }
}
