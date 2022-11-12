using System;
using System.Windows.Threading;

namespace CINEMATRIX.WPF.Interfaces
{
    public interface IDispatcher
    {
        Dispatcher Instance { get; }
        void Invoke(Action callback);
        void Invoke(DispatcherPriority priority, Action callback);
        void BeginInvoke(DispatcherPriority priority, Action callback);
    }
}