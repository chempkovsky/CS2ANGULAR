﻿using System;
using System.Windows.Controls;

namespace CS2ANGULAR.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlSelectSource.xaml
    /// </summary>
    public partial class UserControlSelectSource : UserControl
    {
        public UserControlSelectSource(Object dataContext)
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
