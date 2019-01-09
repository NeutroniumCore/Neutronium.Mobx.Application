using Neutronium.Mobx.Application.ViewModel;
using System;
using System.Windows;

namespace Neutronium.Mobx.Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Debug => App.MainApplication.Debug;
        public Uri Uri => App.MainApplication.Uri;

        public MainWindow()
        {
            Initialized += MainWindow_Initialized;
            InitializeComponent();
        }

        private void MainWindow_Initialized(object sender, EventArgs e)
        {
            DataContext = new HelloViewModel();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.HtmlView.Dispose();
        }
    }
}
