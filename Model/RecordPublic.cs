using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
namespace Clever_Call_Center.Model
{
    public partial class Record
    {
        [Column(Storage = "_recordROWGUID",IsDbGenerated= true, IsPrimaryKey = true)]
        public Guid RecordROWGUID
        {
            get { return this._recordROWGUID; }
        }

        [Column(Storage = "_recordGroupROWGUID")]
        public Guid RecordGroupROWGUID
        {
            get { return this._recordGroupROWGUID; }
        }

        [Column(Storage = "_companyName", CanBeNull = false)]
        public string CompanyName
        {
            get { return this._companyName; }
            set
            {
                if (this._companyName != value)
                {
                    this._companyName = value;
                }
            }
        }

        [Column(Storage = "_firstName", CanBeNull = false)]
        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if ((this._firstName != value))
                {
                    this._firstName = value;
                }
            }
        }

        [Column(Storage = "_lastName", CanBeNull = false)]
        public string LastName
        {
            get { return this._lastName; }
            set
            {
                if (this._lastName != value)
                {
                    this._lastName = value;
                }
            }
        }

        [Column(Storage = "_age")]
        public int Age
        {
            get { return this._age; }
            set
            {
                if (this._age != value)
                {
                    this._age = value;
                }
            }
        }

        [Column(Storage = "_phoneNumber1", CanBeNull = false)]
        public string PhoneNumber1
        {
            get { return this._phoneNumber1; }
            set
            {
                if (this._phoneNumber1 != value)
                {
                    this._phoneNumber1 = value;
                }
            }
        }

        [Column(Storage = "_phoneNumber2", CanBeNull = false)]
        public string PhoneNumber2
        {
            get { return this._phoneNumber2; }
            set
            {
                if (this._phoneNumber2 != value)
                {
                    this._phoneNumber2 = value;
                }
            }
        }

        [Column(Storage = "_defaultPhoneNumber", CanBeNull = false)]
        public string DefaultPhoneNumber
        {
            get { return this._defaultPhoneNumber; }
            set
            {
                if (this._defaultPhoneNumber != value)
                {
                    this._defaultPhoneNumber = value;
                }
            }
        }

        [Column(Storage = "_region", CanBeNull = false)]
        public string Region
        {
            get { return this._region; }
            set
            {
                if (this._region != value)
                {
                    this._region = value;
                }
            }
        }

        [Column(Storage = "_city", CanBeNull = false)]
        public string City
        {
            get { return this._city; }
            set
            {
                if (this._city != value)
                {
                    this._city = value;
                }
            }
        }

        [Column(Storage = "_postCode", CanBeNull = false)]
        public string PostCode
        {
            get { return this._postCode; }
            set
            {
                if (this._postCode != value)
                {
                    this._postCode = value;
                }
            }
        }

        [Column(Storage = "_address", CanBeNull = false)]
        public string Address
        {
            get { return this._address; }
            set
            {
                if (this._address != value)
                {
                    this._address = value;
                }
            }
        }

        [Column(Storage = "_addressNumber", CanBeNull = false)]
        public string AddressNumber
        {
            get { return this._addressNumber; }
            set
            {
                if (this._addressNumber != value)
                {
                    this._addressNumber = value;
                }
            }
        }

        [Column(Storage = "_tag", CanBeNull = false)]
        public string Tag
        {
            get { return this._tag; }
            set
            {
                if (this._tag != value)
                {
                    this._tag = value;
                }
            }
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
            set
            {
                if (this._timeOfModification != value)
                {
                    this._timeOfModification = value;
                }
            }
        }

        [Association(Storage = "_recordGroup", ThisKey = "RecordGroupROWGUID", OtherKey = "RecordGroupROWGUID", IsForeignKey = true)]
        public RecordGroup RecordGroups
        {
            get { return this._recordGroup.Entity; }
            set
            {
                RecordGroup previousValue = this._recordGroup.Entity;
                if ((previousValue != value) || (this._recordGroup.HasLoadedOrAssignedValue == false))
                {
                    if (previousValue != null)
                    {
                        this._recordGroup.Entity = null;
                    }
                    this._recordGroup.Entity = value;
                    if ((value != null))
                    {
                        this._recordGroupROWGUID = value.RecordGroupROWGUID;
                    }
                    else
                    {
                        this._recordGroupROWGUID = default(Guid);
                    }
                }
            }
        }
    }
}
