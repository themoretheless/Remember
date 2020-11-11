using System.Windows;
using System.Windows.Media;

namespace Remember.Wpf.NewFolder
{
    public class RevealElement : DependencyObject
    {
        public static Color GetMouseOverBackgroundColor(DependencyObject obj) => (Color)obj.GetValue(MouseOverBackgroundColorProperty);
        public static void SetMouseOverBackgroundColor(DependencyObject obj, Color value) => obj.SetValue(MouseOverBackgroundColorProperty, value);
        public static readonly DependencyProperty MouseOverBackgroundColorProperty =
            DependencyProperty.RegisterAttached("MouseOverBackgroundColor", typeof(Color), typeof(RevealElement),
                new FrameworkPropertyMetadata(Colors.Transparent, FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetMouseOverBackground(DependencyObject obj) => (Brush)obj.GetValue(MouseOverBackgroundProperty);
        public static void SetMouseOverBackground(DependencyObject obj, Brush value) => obj.SetValue(MouseOverBackgroundProperty, value);
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.RegisterAttached("MouseOverBackground", typeof(Brush), typeof(RevealElement),
                new FrameworkPropertyMetadata(Brushes.White, FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetMouseOverForeground(DependencyObject obj) => (Brush)obj.GetValue(MouseOverForegroundProperty);
        public static void SetMouseOverForeground(DependencyObject obj, Brush value) => obj.SetValue(MouseOverForegroundProperty, value);
        public static readonly DependencyProperty MouseOverForegroundProperty =
            DependencyProperty.RegisterAttached("MouseOverForeground", typeof(Brush), typeof(RevealElement),
                new FrameworkPropertyMetadata(Brushes.Black, FrameworkPropertyMetadataOptions.Inherits));      

        public static double GetBorderRadius(DependencyObject obj) => (double)obj.GetValue(BorderRadiusProperty);
        public static void SetBorderRadius(DependencyObject obj, double value) => obj.SetValue(BorderRadiusProperty, value);
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.RegisterAttached("BorderRadius", typeof(double), typeof(RevealElement),
                new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.Inherits));

        public static double GetBorderOpacity(DependencyObject obj) => (double)obj.GetValue(BorderOpacityProperty);
        public static void SetBorderOpacity(DependencyObject obj, double value) => obj.SetValue(BorderOpacityProperty, value);
        public static readonly DependencyProperty BorderOpacityProperty =
            DependencyProperty.RegisterAttached("BorderOpacity", typeof(double), typeof(RevealElement),
                new PropertyMetadata(0.0));

        public static double GetMouseOverBorderOpacity(DependencyObject obj) => (double)obj.GetValue(MouseOverBorderOpacityProperty);
        public static void SetMouseOverBorderOpacity(DependencyObject obj, double value) => obj.SetValue(MouseOverBorderOpacityProperty, value);
        public static readonly DependencyProperty MouseOverBorderOpacityProperty =
            DependencyProperty.RegisterAttached("MouseOverBorderOpacity", typeof(double), typeof(RevealElement),
                new PropertyMetadata(0.5));

        public static double GetPressBorderOpacity(DependencyObject obj) => (double)obj.GetValue(PressBorderOpacityProperty);
        public static void SetPressBorderOpacity(DependencyObject obj, double value) => obj.SetValue(PressBorderOpacityProperty, value);
        public static readonly DependencyProperty PressBorderOpacityProperty =
            DependencyProperty.RegisterAttached("PressBorderOpacity", typeof(double), typeof(RevealElement),
                new PropertyMetadata(0.5));

        public static Brush GetPressTintBrush(DependencyObject obj) => (Brush)obj.GetValue(PressTintBrushProperty);
        public static void SetPressTintBrush(DependencyObject obj, Brush value) => obj.SetValue(PressTintBrushProperty, value);
        public static readonly DependencyProperty PressTintBrushProperty =
            DependencyProperty.RegisterAttached("PressTintBrush", typeof(Brush), typeof(RevealElement),
                new PropertyMetadata(Brushes.Gray));
    }
}
