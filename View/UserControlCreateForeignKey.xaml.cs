﻿using CS2ANGULAR.ViewModel;
using System;
using System.Windows.Controls;

namespace CS2ANGULAR.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlCreateForeignKey.xaml
    /// </summary>
    public partial class UserControlCreateForeignKey : UserControl
    {
        public UserControlCreateForeignKey(CreateForeignKeyViewModel dataContext)
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
