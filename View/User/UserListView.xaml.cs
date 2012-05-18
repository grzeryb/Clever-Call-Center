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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Clever_Call_Center.Model;

namespace Clever_Call_Center.View
{
    /// <summary>
    /// Interaction logic for UserListView.xaml
    /// </summary>
    public partial class UserListView : UserControl
    {
        CleverCallCenter _cleverCallCenter;
        UserView _userView;

        public UserListView()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(UserListView_Loaded);
        }

        private void UserListView_Loaded(object sender, EventArgs e)
        {
            _cleverCallCenter = new CleverCallCenter();
            _listviewUser.ItemsSource = _cleverCallCenter.UsersInRoles;
        }

        private void _buttonEditUser_Click(object sender, RoutedEventArgs e)
        {
            _userView = new UserView();
            _userView.UserInRole = (UserInRole)_listviewUser.SelectedItem;
            _userView.Closed += new EventHandler(UserListView_Loaded);
            _userView.ShowDialog();
        }

        private void _buttonAddUser_Click(object sender, RoutedEventArgs e)
        {
            _userView = new UserView();
            _userView.Closed += new EventHandler(UserListView_Loaded);
            _userView.ShowDialog();
        }

        private void _listviewUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_listviewUser.SelectedItem != null)
            {
                _buttonEditUser.IsEnabled = true;
            }
            else _buttonEditUser.IsEnabled = false;
        }
    }
}
