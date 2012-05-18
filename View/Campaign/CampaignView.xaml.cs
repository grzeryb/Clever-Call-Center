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
    public partial class CampaignView : Window
    {
        private CleverCallCenter _cleverCallCenter;
        private List<string> _status;
        private Campaign _campaign;

        public Campaign Campaign
        {
            set { _campaign = value; }
        }

        public CampaignView()
        {
            InitializeComponent();
            InitializeStatusList();
            _cleverCallCenter = new CleverCallCenter();
            Loaded+=new RoutedEventHandler(CampaignView_Loaded);
        }

        public void CampaignView_Loaded(object sender, EventArgs e)
        {
            if (_campaign == null)
            {
                _campaign = new Campaign();
            }
            else
            {
                _campaign = (from c in _cleverCallCenter.Campaigns where c.CampaignROWGUID == _campaign.CampaignROWGUID select c).Single<Campaign>();
            }
            DataContext = _campaign;
        }

        private void InitializeStatusList()
        {
            _status = new List<string>();
            _status.Add("AKTYWNA");
            _status.Add("NIEAKTYWNA");
            _comboboxStatus.ItemsSource = _status;
        }

        private void _buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void _buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (_campaign.User == null)
            {
                _campaign.User = (from u in _cleverCallCenter.Users select u).First<User>();
                _cleverCallCenter.Campaigns.InsertOnSubmit(_campaign);
            }
            try
            {
                _cleverCallCenter.SubmitChanges();
            }
            catch (Exception _exception)
            {
                MessageBox.Show(_exception.Message);
            }
            this.DialogResult = true;
        }
    }
}
