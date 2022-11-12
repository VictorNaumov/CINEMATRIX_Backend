//using CINEMATRIX.WPF.Enums;
//using CINEMATRIX.WPF.Interfaces;
//using CINEMATRIX.WPF.MVVM;
//using System;
//using System.Windows.Controls;

//namespace CINEMATRIX.WPF.ViewModels
//{
//    public class SidePanelViewModel : ViewModelBase, IDisposable
//    {

//        private readonly ISidePanelStateManager _sidePaneStateManager;
//        private readonly IViewFactory _viewFactory;

//        public SidePanelScreen ViewState => _sidePaneStateManager.ActiveScreen;

//        public SidePanelViewModel(ISidePanelStateManager sidePanelStateManager, IViewFactory viewFactory)
//        {
//            _sidePaneStateManager = sidePanelStateManager;
//            _viewFactory = viewFactory;
//            _sidePaneStateManager.ScreenChanged += OnScreenChanged;
//        }

//        public UserControl GetScreenView() => _viewFactory.GetScreenView(ViewState);

//        private void OnScreenChanged(object sender, System.EventArgs e)
//        {
//            RaisePropertyChanged(nameof(ViewState));
//        }

//        public void Dispose()
//        {
//            _sidePaneStateManager.ScreenChanged -= OnScreenChanged;
//        }
//    }

//}
