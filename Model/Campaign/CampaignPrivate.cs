using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "Campaigns")]
    public partial class Campaign
    {
        private Guid _campaignROWGUID; 
        private int _id; 
        private Guid _userROWGUID; 
        private string _status = "AKTYWNA"; 
        private string _name; 
        private string _description; 
        private DateTime _campaignEndDate; 
        private DateTime _campaignStartDate; 
        private DateTime _timeOfCreation; 
        private DateTime _timeOfModification; 
        private EntityRef<User> _user;
    }
}
