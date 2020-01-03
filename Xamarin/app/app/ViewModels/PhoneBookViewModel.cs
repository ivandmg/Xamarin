namespace app.ViewModels
{
    using app.Models;
    using app.Services;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class PhoneBookViewModel:BaseViewModel
    {
        #region Attributes
        private ApiService apiservice;
        private ObservableCollection<Phone> phones;
        #endregion
        #region Properties
        public ObservableCollection<Phone> Phones
        {
            get { return this.phones; }
            set { SetValue(ref this.phones, value); }
        }
        #endregion
        #region Constructor
        public PhoneBookViewModel()
        {
            this.apiservice = new ApiService();
            this.LoadPhones();
        }
        #endregion
        #region Methods
        private async void LoadPhones()
        {
            var connection = await apiservice.CheckConnection();
            if(!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Internet Error Connection",connection.Message,"Accept");
                return;
            }
            var response = apiservice.GetList<Phone>(
                "http://localhost:64131/",
                "API/",
                "phones"
                );
            
        }
        #endregion
    }
}


