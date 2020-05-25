using CS2ANGULAR.Model;
using CS2ANGULAR.ViewModel;
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

namespace CS2ANGULAR.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlSelectViewModel.xaml
    /// </summary>
    public partial class UserControlSelectViewModel : UserControl
    {
        public UserControlSelectViewModel(SelectVmViewModel dataContext)
        {
            InitializeComponent();
            SetDataContext(dataContext);
        }

        public void SetDataContext(Object dataContext)
        {
            this.DataContext = dataContext;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (this.DataContext is SelectVmViewModel)
            {
                    (this.DataContext as SelectVmViewModel).SelectedTreeViewItem = e.NewValue;
            }
        }
    }
}
