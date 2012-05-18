using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace Clever_Call_Center.Model
{
    [Table(Name = "Users")]
    public partial class User
    {
        private Guid _id;
        private string _login;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _note;
        private bool _active = true;
        private DateTime _timeOfCreation;
        private DateTime _timeOfModification;
    }
}
