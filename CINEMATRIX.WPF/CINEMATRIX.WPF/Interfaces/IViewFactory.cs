using CINEMATRIX.WPF.Enums;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CINEMATRIX.WPF.Interfaces
{
    public interface IViewFactory
    {
        UserControl GetScreenView(SidePanelScreen screen);

        UserControl GetSidePanelView(SidePanelTab tab);

        bool IsSidePanelViewAvailable(SidePanelTab tab);
    }
}