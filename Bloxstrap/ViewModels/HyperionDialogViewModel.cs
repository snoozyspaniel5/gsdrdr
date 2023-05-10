﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Bloxstrap.Dialogs;

namespace Bloxstrap.ViewModels
{
    public class HyperionDialogViewModel : FluentDialogViewModel, INotifyPropertyChanged
    {
        public string Version => $"Bloxstrap v{App.Version}";
        // Using dark theme for default values.
        public Thickness DialogBorder { get; set; } = new Thickness(0);
        public Brush Background { get; set; } = Brushes.Black;
        public Brush Foreground { get; set; } = new SolidColorBrush(Color.FromRgb(216, 216, 216));
        public Brush IconColor { get; set; } = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        public Brush ProgressBarBackground { get; set; } = new SolidColorBrush(Color.FromRgb(86, 86, 86));
        public HyperionDialogViewModel(IBootstrapperDialog dialog) : base(dialog)
        {
        }
    }
}
