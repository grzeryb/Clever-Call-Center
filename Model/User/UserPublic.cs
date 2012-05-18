using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    public partial class User
    {
        public User()
        {
            _timeOfCreation = DateTime.Now;
            _timeOfModification = DateTime.Now;
        }

        [Column(Storage = "_id", CanBeNull = false, IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public Guid UserROWGUID
        {
            get { return _id; }
        }

        [Column(Storage = "_login", CanBeNull = false)]
        public string Login
        {
            get { return _login; }
            set 
            {
                _login = value;
            }
        }

        [Column(Storage = "_firstName", CanBeNull = false)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        [Column(Storage = "_lastName", CanBeNull = false)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }

        [Column(Storage = "_password", CanBeNull = false)]
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }

        [Column(Storage = "_note", CanBeNull = false)]
        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
            }
        }

        [Column(Storage = "_active", CanBeNull = false)]
        public bool Active
        {
            get { return _active; }
            set
            {
                _active = value;
            }
        }

        [Column(Storage = "_timeOfCreation", CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
        public DateTime TimeOfCreation
        {
            get { return _timeOfCreation; }
        }

        [Column(Storage = "_timeOfModification", CanBeNull = false)]
        public DateTime TimeOfModification
        {
            get { return _timeOfModification; }
            set
            {
                _timeOfModification = value;
            }
        }
    }
}
