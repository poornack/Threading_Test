using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Threading_Test
{
    
    public class thread_test
    {
        
        public void func1()
        {
            
            

        }


    }
      


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            thread_test var = new thread_test();

            Thread t = new Thread(new ThreadStart(changeText));

            t.Start();

            

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Main thread cycle #" + i);
            }
            
        }

        private void changeText()
        {

            this.Dispatcher.Invoke(() => textbox1.Text = "Text has been changed");

        }

        
    }
}
