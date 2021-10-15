using HotelManagementSystemEmreAyhan.DataServices;
using HotelManagementSystemEmreAyhan.Models;
using HotelManagementSystemEmreAyhan.Views;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManagementSystemEmreAyhan
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<DatabaseDbContext>();
            containerRegistry.RegisterScoped<IRoomService, RoomService>();
            

            containerRegistry.RegisterForNavigation<LoginView>();
            containerRegistry.RegisterForNavigation<MenuView>();
            containerRegistry.RegisterForNavigation<RoomsView>();
            containerRegistry.RegisterForNavigation<SignUpView>();
            


            // register other needed services here
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<LoginView>();
        }


        protected override void OnInitialized()
        {
            base.OnInitialized();
            var regionManager = Container.Resolve<IRegionManager>();
            var contentRegion = regionManager.Regions["ContentRegion"];
            var LoginView = Container.Resolve<LoginView>();
            var MenuView = Container.Resolve<MenuView>();
            var RoomsView = Container.Resolve<RoomsView>();
            var SignUpView = Container.Resolve<SignUpView>();
           

            contentRegion.Add(LoginView);
            contentRegion.Add(MenuView);
            contentRegion.Add(RoomsView);
            contentRegion.Add(SignUpView);
           


        }
    }
}
