using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace color_converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void szin(int a, int b)
        {
            hex.Text = hex.Text.Remove(a, 2);
            if (Convert.ToString(b, 16).Count() == 1)
            {
                hex.Text = hex.Text.Insert(a, "0" + Convert.ToString(b, 16));
            }
            else
            {
                hex.Text = hex.Text.Insert(a, Convert.ToString(b, 16));
            }
        }
        public int redn;
        public int greenn;
        public int bluen;
        public string hexa;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redt_TextChanged(object sender,KeyEventArgs e)
        {
            if (e.Key == Key.Return && redt.Text.All(x => char.IsDigit(x)))
            {
                redn = int.Parse(redt.Text);
                if (255>=redn&& redn>=0)
                {
                    reds.Value = redn;
                    hatter.Background =new SolidColorBrush(Color.FromRgb(Convert.ToByte(redn), Convert.ToByte(greenn) , Convert.ToByte(bluen)));
                    szin(1,redn);
                }
            }  
        }
        
        private void greent_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return && greent.Text.All(x => char.IsDigit(x)))
            {
                greenn = int.Parse(greent.Text);
                if (greenn >= 0 && greenn<= 255)
                {
                    greens.Value = greenn;
                    hatter.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(redn), Convert.ToByte(greenn), Convert.ToByte(bluen)));
                    szin(3, greenn);
                }
            }
        }

        private void bluet_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return && bluet.Text.All(x => char.IsDigit(x)))
            {
                bluen = int.Parse(bluet.Text);
                if ( bluen >= 0 && bluen <= 255)
                {
                    blues.Value = bluen;
                    hatter.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(redn), Convert.ToByte(greenn), Convert.ToByte(bluen)));
                    szin(5, bluen);
                }
            }
        }
        
        private void reds_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            redt.Text = Math.Round(reds.Value).ToString();
            redn = Convert.ToInt32(Math.Round(reds.Value));
            hatter.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(redn), Convert.ToByte(greenn), Convert.ToByte(bluen)));
        }
        private void piros(object sender, DragCompletedEventArgs e)
        {
            szin(1, redn);
        }

        private void greens_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            greent.Text = Math.Round(greens.Value).ToString();
            greenn = Convert.ToInt32(Math.Round(greens.Value));
            hatter.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(redn), Convert.ToByte(greenn), Convert.ToByte(bluen)));
        }
        private void zold(object sender, DragCompletedEventArgs e)
        {
            szin(3, greenn);
        }

        private void blues_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bluet.Text = Math.Round(blues.Value).ToString();
            bluen = Convert.ToInt32(Math.Round(blues.Value));
            hatter.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(redn), Convert.ToByte(greenn), Convert.ToByte(bluen)));
        }
        private void kek(object sender, DragCompletedEventArgs e)
        {
            szin(5, bluen);
        }
        private void hex_TextChanged(object sender,KeyEventArgs e)
        {
            char[] car = new char[] { '0', '1','2', '3', '4', '5', '6', '7', '8', '9', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F'};
            if (e.Key == Key.Return && hex.Text.Length==7)
            {
                if (hex.Text.Skip(1).All(x=>car.Contains(x)) && hex.Text.First() == '#')
                {
                    hexa = hex.Text;
                    hatter.Background =(SolidColorBrush)(new BrushConverter().ConvertFromString(hexa));
                    string redh = hexa[1].ToString() + hexa[2].ToString();
                    redt.Text = Convert.ToInt32(redh,16).ToString();
                    redn = Convert.ToInt32(redh,16);
                    reds.Value = redn;
                    string greenh = hexa[3].ToString() + hexa[4].ToString();
                    greent.Text = Convert.ToInt32(greenh, 16).ToString();
                    greenn = Convert.ToInt32(greenh, 16);
                    greens.Value = greenn;
                    string blueh = hexa[5].ToString() + hexa[6].ToString();
                    bluet.Text = Convert.ToInt32(blueh, 16).ToString();
                    bluen = Convert.ToInt32(blueh, 16);
                    blues.Value = bluen;
                }
            }
        }
    }
}
