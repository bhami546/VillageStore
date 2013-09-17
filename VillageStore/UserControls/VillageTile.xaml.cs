using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace VillageStore.UserControls
{
    public sealed partial class VillageTile : UserControl
    {
        public VillageTile()
        {
            this.InitializeComponent();
        }



       

        

        public ImageSource TileImage
        {
            get { return (ImageSource)GetValue(TileImageProperty); }
            set { SetValue(TileImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileImageProperty =
            DependencyProperty.Register("TileImage", typeof(ImageSource), typeof(VillageTile), new PropertyMetadata(new BitmapImage()));




        public string TileTitleText
        {
            get { return (string)GetValue(TileTitleTextProperty); }
            set { SetValue(TileTitleTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileTitleText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileTitleTextProperty =
            DependencyProperty.Register("TileTitleText", typeof(string), typeof(VillageTile), new PropertyMetadata(string.Empty));

        


        public string TileText
        {
            get { return (string)GetValue(TileTextProperty); }
            set { SetValue(TileTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileTextProperty =
            DependencyProperty.Register("TileText", typeof(string), typeof(VillageTile), new PropertyMetadata(string.Empty));





        public SolidColorBrush TileBackground
        {
            get { return (SolidColorBrush)GetValue(TileBackgroundProperty); }
            set { SetValue(TileBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileBackgroundProperty =
            DependencyProperty.Register("TileBackground", typeof(SolidColorBrush), typeof(VillageTile), new PropertyMetadata(new SolidColorBrush(Colors.DarkCyan)));




        public double TileHeight
        {
            get { return (double)GetValue(TileHeightProperty); }
            set { SetValue(TileHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileHeightProperty =
            DependencyProperty.Register("TileHeight", typeof(double), typeof(VillageTile), new PropertyMetadata(0.0));



        public double TileWidth
        {
            get { return (double)GetValue(TileWidthProperty); }
            set { SetValue(TileWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileWidthProperty =
            DependencyProperty.Register("TileWidth", typeof(double), typeof(VillageTile), new PropertyMetadata(0.0));

        
        private void TileGrid_OnLoaded(object sender, RoutedEventArgs e)
        {
            TileGrid.Background = TileBackground;
            //TileImageControl.Source = TileImage;
            TileTextBlock.Text = TileText;
            TileHeader.Text = TileTitleText;
            this.Width = TileWidth;
            this.Height = TileHeight;
            
        }
    }
}
