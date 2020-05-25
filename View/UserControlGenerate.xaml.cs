using CS2ANGULAR.ViewModel;
using System;
using System.Windows.Controls;

namespace CS2ANGULAR.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlGenerate.xaml
    /// </summary>
    public partial class UserControlGenerate : UserControl
    {
        public UserControlGenerate(BaseGenerateViewModel dataContext)
        {
            InitializeComponent();
            SetDataContext(dataContext);
        }
        public void SetDataContext(Object dataContext)
        {
            this.DataContext = dataContext;
        }
    }
}
