using CINEMATRIX.WPF.API;
using CINEMATRIX.WPF.Enums;
using CINEMATRIX.WPF.Interfaces;
using CINEMATRIX.WPF.MVVM;
using System;
using System.Windows.Controls;

namespace CINEMATRIX.WPF.ViewModels
{
    public class SidePanelViewModel : ViewModelBase, IDisposable
    {

        private readonly ISidePanelStateManager _sidePanelStateManager;
        private readonly IViewFactory _viewFactory;
        private readonly IApiClient _apiClient;

        public SidePanelViewModel(ISidePanelStateManager sidePanelStateManager, IApiClient apiClient, IViewFactory viewFactory)
        {
            _sidePanelStateManager = sidePanelStateManager;
            _viewFactory = viewFactory;
            _apiClient = apiClient;

            GetMoviesCommand = new RelayCommand(OnGetMoviesCommand);
        }

        private void OnGetMoviesCommand()
        {
            var moviedtos = _apiClient.MovieAsync(1);
        }

        public RelayCommand GetMoviesCommand { get; }

        //public UserControl GetScreenView() => _viewFactory.GetScreenView(ViewState);

        private void OnScreenChanged(object sender, System.EventArgs e)
        {
            //RaisePropertyChanged(nameof(ViewState));
        }

        public void Dispose()
        {
            //_sidePaneStateManager.ScreenChanged -= OnScreenChanged;
        }
    }

}
