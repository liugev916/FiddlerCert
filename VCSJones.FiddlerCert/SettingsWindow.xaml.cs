﻿using System.Windows;

namespace VCSJones.FiddlerCert
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            var viewModel = new SettingsViewModel();
            viewModel.CloseRequest += Close;
            DataContext = viewModel;
        }
    }
}
