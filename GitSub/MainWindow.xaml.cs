using GitSub.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ookii.Dialogs;
using Ookii.Dialogs.Wpf;

namespace GitSub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GitRepos GitRepos { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            GitRepos = new GitRepos();
        }

        private void _btAddRepo_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new VistaFolderBrowserDialog();
            if( dlg.ShowDialog() == true )
            {
                
            }
        }
    }
}
