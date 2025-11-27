using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LandSecure
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
            
        }
        public void ApplyingABlur(){
            var host = ElementCompositionPreview.GetElementVisual(BlurredPanel);
            var compositor = host.Compositor;

            var blurry = compositor.CreateGaussianBlurEffect();
            blurry.BlurAmount = 20.0f;
            blurry.BorderMode = Microsoft.Graphics.Canvas.Effects.EffectBorderMode.Hard;

            var brusher = compositor.CreateEffectFactory(blurry).CreateBrush();
            var sprite = compositor.CreateSpriteVisual();
            sprite.Brush = brusher;

            ElementCompositionPreview.SetElementChildVisual(BlurredPanel, sprite);
        }
    }
}
