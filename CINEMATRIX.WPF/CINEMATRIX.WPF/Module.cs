using Autofac;
using CINEMATRIX.Services;
using CINEMATRIX.WPF.API;
using CINEMATRIX.WPF.ViewModels;
using CINEMATRIX.WPF.Views;
using System;
using System.Net;
using System.Net.Http;
using System.Windows;

namespace CINEMATRIX.WPF
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var dispatcherWrapper = new DispatcherWrapper(Application.Current.Dispatcher);

            builder.RegisterType<ApiClient>().As<IApiClient>();


            builder.RegisterType<RootView>().InstancePerLifetimeScope();
            builder.RegisterType<SidePanelView>().InstancePerLifetimeScope();

            builder.RegisterType<SidePanelViewModel>().InstancePerLifetimeScope();

            RegisterHttpClient(builder);
        }

        private static void RegisterHttpClient(ContainerBuilder builder)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMinutes(5)
            };

            builder.RegisterInstance(httpClient).As<HttpClient>().SingleInstance();
        }
    }
}
