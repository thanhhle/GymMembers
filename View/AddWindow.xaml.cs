﻿using System;
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
using System.Windows.Shapes;

namespace GymMembers.View
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window, IClosable
    {
        public AddWindow()
        {
            InitializeComponent();
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
        }
    }
}
