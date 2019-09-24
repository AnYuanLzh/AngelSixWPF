using System.Windows;

namespace Fassetto.Word.ViewModel
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    class WindowViewModel:BaseViewModel
    {
        #region Priveate Member
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;


        #endregion

        #region Public Porperties

        public string Test { get; set; } = "Test String";

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            mWindow = window;
        }

        #endregion
    }
}
