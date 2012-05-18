using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Windows;
using Clever_Call_Center.Model;

namespace Clever_Call_Center
{
    [Database(Name="CleverCallCenter")]
    public partial class CleverCallCenter : DataContext
    {
        private static readonly string _connectionString = @"data source=5.215.155.240\SQLEXPRESS; initial catalog=CleverCallCenter; User Id=CCC_User; Password=!@#123QWEqwe";
        public CleverCallCenter() : base(_connectionString) { }

        public Table<Campaign> Campaigns
        {
            get { return this.GetTable<Campaign>(); }
        }

        public Table<User> Users
        {
            get { return this.GetTable<User>(); }
        }

        public Table<Role> Roles
        {
            get { return this.GetTable<Role>(); }
        }

        public Table<UserInRole> UsersInRoles
        {
            get { return this.GetTable<UserInRole>(); }
        }


    }
}
