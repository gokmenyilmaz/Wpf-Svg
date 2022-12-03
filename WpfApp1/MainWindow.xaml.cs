using DevExpress.Xpf.Map;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SvgFileDataAdapter_ShapesLoaded(object sender, DevExpress.Xpf.Map.ShapesLoadedEventArgs e)
        {
            var shapes = e.Shapes.Where(c => c.GetType()== typeof(MapPath)).ToList();

            foreach (MapPath item in shapes)
            {
                item.Fill = Brushes.Blue;
            }
        }
    }
}
