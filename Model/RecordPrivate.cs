using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "dbo.Records")]
    public partial class Record
    {
        private Guid _recordROWGUID;
        private Guid _recordGroupROWGUID;
        private string _companyName;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _phoneNumber1;
        private string _phoneNumber2;
        private string _defaultPhoneNumber;
        private string _region;
        private string _city;
        private string _postCode;
        private string _address;
        private string _addressNumber;
        private string _tag;
        private DateTime _timeOfCreation;
        private DateTime _timeOfModification;
        private EntityRef<RecordGroup> _recordGroup;



    }
}
