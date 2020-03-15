using SourceChord.FluentWPF.Utility;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;

namespace SourceChord.FluentWPF
{
    public class AcrylicPopup : Popup
    {
        static AcrylicPopup()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AcrylicPopup), new FrameworkPropertyMetadata(typeof(AcrylicPopup)));
        }

        protected override void OnOpened(EventArgs e)
        {
            base.OnOpened(e);

            var hwnd = (HwndSource)PresentationSource.FromVisual(Child);
            AcrylicHelper.EnableBlur(hwnd.Handle, AccentFlagsType.Popup);
        }
    }
}
