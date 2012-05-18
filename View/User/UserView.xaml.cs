using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Clever_Call_Center.Model;

namespace Clever_Call_Center.View
{
    public partial class UserView : Window
    {
        private CleverCallCenter _cleverCallCenter;
        private UserInRole _userInRole;

        public UserInRole UserInRole
        {
            set { _userInRole = value; }
        }

        public UserView()
        {
            InitializeComponent();
            _cleverCallCenter = new CleverCallCenter();
            _comboboxRole.ItemsSource = _cleverCallCenter.Roles;
            Loaded+=new RoutedEventHandler(UserView_Loaded);
        }

        public void UserView_Loaded(object sender, EventArgs e)
        {
            if (_userInRole == null)
            {
                _userInRole = new UserInRole();
                User _user = new User();
                _userInRole.User = _user;
            }
            else
            {
                _userInRole = (from u in _cleverCallCenter.UsersInRoles where u.UserInRoleROWGUID == _userInRole.UserInRoleROWGUID select u).Single<UserInRole>();
            }
            DataContext = _userInRole;
        }

        private void _buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void _buttonSave_Click(object sender, RoutedEventArgs e)
        {
            _userInRole.Role = (Role)_comboboxRole.SelectedItem;
            if (_userInRole.UserInRoleROWGUID == Guid.Empty)
            {
                _cleverCallCenter.UsersInRoles.InsertOnSubmit(_userInRole);
            }
            try
            {
                _cleverCallCenter.SubmitChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.DialogResult = true;
        }
    }
}
