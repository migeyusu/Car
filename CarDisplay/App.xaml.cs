﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Castle.Windsor;

namespace CarDisplay
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            using (var windsorContainer = new WindsorContainer()) {
                windsorContainer.Install(new Installer());
                var mainWindow = windsorContainer.Resolve<MainWindow>();
                mainWindow.ShowDialog();
            }
            App.Current.Shutdown();
        }
    }
}
