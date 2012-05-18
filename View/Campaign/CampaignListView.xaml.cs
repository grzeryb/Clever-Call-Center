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
    /// Interaction logic for CampaignListView.xaml
    /// </summary>
    public partial class CampaignListView : UserControl
    {
        CleverCallCenter _cleverCallCenter;
        CampaignView _campaingView;

        public CampaignListView()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(CampaignListView_Loaded);
        }

        private void CampaignListView_Loaded(object sender, EventArgs e)
        {
            _cleverCallCenter = new CleverCallCenter();
            _listviewCampaign.ItemsSource = _cleverCallCenter.Campaigns;
        }

        private void _buttonEditCampaign_Click(object sender, RoutedEventArgs e)
        {
            _campaingView = new CampaignView();
            _campaingView.Campaign = (Campaign)_listviewCampaign.SelectedItem;
            _campaingView.Closed += new EventHandler(CampaignListView_Loaded);
            _campaingView.ShowDialog();
        }

        private void _buttonAddCampaign_Click(object sender, RoutedEventArgs e)
        {
            _campaingView = new CampaignView();
            _campaingView.Closed += new EventHandler(CampaignListView_Loaded);
            _campaingView.ShowDialog();
        }

        private void _listviewCampaign_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_listviewCampaign.SelectedItem != null)
            {
                _buttonEditCampaign.IsEnabled = true;
            }
            else _buttonEditCampaign.IsEnabled = false;
        }
    }
}
