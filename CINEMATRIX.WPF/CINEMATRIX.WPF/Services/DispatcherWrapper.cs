using CINEMATRIX.WPF.Interfaces;
using System;
using System.Windows.Threading;

namespace CINEMATRIX.Services
{
    public class DispatcherWrapper : IDispatcher
    {
        public DispatcherWrapper(Dispatcher dispatcher)
        {
            Instance = dispatcher;
        }

        public Dispatcher Instance { get; }

        public void Invoke(Action callback) => Instance.Invoke(callback);
        public void Invoke(DispatcherPriority priority, Action callback) => Instance.Invoke(priority, callback);

        public void BeginInvoke(DispatcherPriority priority, Action callback)
            => Instance.BeginInvoke(callback, priority);
    }
}
