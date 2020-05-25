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
    /// Логика взаимодействия для UserControlVMCFSex.xaml
    /// </summary>
    public partial class UserControlVMCFSex : UserControl
    {
        public UserControlVMCFSex(ClassFiledSelectorRootViewModel dataContext)
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
            if (this.DataContext is ClassFiledSelectorRootViewModel)
            {
                if ((e.NewValue) is PropertySelectorViewModel)
                {
                    (this.DataContext as ClassFiledSelectorRootViewModel).SelectedTreeViewItem = (e.NewValue) as PropertySelectorViewModel;
                } else
                {
                    (this.DataContext as ClassFiledSelectorRootViewModel).SelectedTreeViewItem = e.NewValue;
                }
            }
        }
    }
}
