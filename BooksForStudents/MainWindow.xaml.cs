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
//using DevExpress.XtraPdfViewer;

namespace BooksForStudents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FilePath { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public string ViewImage(string filePath)
        {
            Button1.IsEnabled = false;
            FilePath = filePath;
            var sender = new Image();
            BitmapImage bi3 = new BitmapImage();

            bi3.BeginInit();
            bi3.UriSource = new Uri(FilePath, UriKind.Relative);
            bi3.EndInit();
            //Label.Content = default(Label);
            Image1.Source = bi3;
            Button1.IsEnabled = true;
            
            return FilePath;
            
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
           //Todo add selector
          

            sender = "Photo/bookMath.jpg";
            ViewImage((string)sender);

            // Image image = new Image();
            //  Label.Content= new BitmapImage(new Uri("bookMath.jpg", UriKind.RelativeOrAbsolute));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Path= null;
            if (FilePath.ToString() == "Photo/bookMath.jpg")
                Path = "C:/Users/79899/Desktop/Math.pdf";
            else
            if (FilePath.ToString() == "Photo/BookMath2.jpg")
                Path = "C:/Users/79899/Desktop/Books/(Ряды матан)sb_vm2(2014).pdf";
                 var pdfOpen = new PdfOpen();
            pdfOpen.Show();
            pdfOpen.axAcroPDF1_Enter((string)Path, default(EventArgs));
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sender = "Photo/BookMath2.jpg";
            ViewImage((string)sender);
        }
    }
}
