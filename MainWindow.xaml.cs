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
using Clever_Call_Center.View;

namespace Clever_Call_Center
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _contentcontrolUsers.Content = new UserListView();
            _contentcontrolCampaigns.Content = new CampaignListView();
        }
    }
}
