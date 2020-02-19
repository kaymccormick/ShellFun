using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using Castle.DynamicProxy;
using Microsoft.Scripting.Actions;
using Shell32;
using Vanara.Windows.Shell;
using HWND = Vanara.PInvoke.HWND;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly ProxyGenerator Generator = new ProxyGenerator();

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public App()
        {
        }
    }
}