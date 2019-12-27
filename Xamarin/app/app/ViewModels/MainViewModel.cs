using app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public List<Phone> ListPhone { get; set; }
        #endregion
        #region singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if(instance==null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            instance = this;
            phoneBookViewModel = new PhoneBookViewModel();
        }
        #endregion
        #region ViewModels
        public PhoneBookViewModel phoneBookViewModel { get; set; }
        #endregion

    }
}
