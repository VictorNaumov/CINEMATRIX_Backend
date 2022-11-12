using CINEMATRIX.WPF.Enums;
using System;
using System.Windows.Threading;

namespace CINEMATRIX.WPF.Interfaces
{
    public interface ISidePanelStateManager
    {
        SidePanelTab ActiveTab { get; set; }
        event EventHandler TabChanged;
        SidePanelScreen ActiveScreen { get; set; }
        event EventHandler ScreenChanged;
    }
}