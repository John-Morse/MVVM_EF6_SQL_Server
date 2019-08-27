namespace MVVM_EF6.View
{
    using GalaSoft.MvvmLight.Threading;
    using MVVM_EF6.CrossCutting;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static App()
        {
            //configure logging (only set once)
            Logging.ConfigureLog4Net();

            DispatcherHelper.Initialize();

            log.Info("Application Initialized");
        }
    }
}
