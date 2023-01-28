using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lecture_Example___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student();
            Movie();
            Person();
        }       
        public void Student()
        {
            Student student = new Student("Meili", "Zheng", 80, 85);
            MessageBox.Show(student.FirstName);
            Student student1 = new Student("Bryan", "Baker");
            MessageBox.Show(student1.FirstName);
        }
        public void Movie()
        {
            Movie frozen = new Movie("Frozen", 4.6, "Jennifer Lee", 2013);
            MessageBox.Show(frozen.MovieName);
            Movie Moana = new Movie("Moana", 4.8);
            MessageBox.Show(Moana.MovieName);
        }
        public void Person()
        {
            Person person = new Person("Tem", "Duffy", "1970 Napa Ct.");
            MessageBox.Show(person.FirstName, person.LastName);
            Person person1 = new Person("1", "ken0@adventure-works.com");
            MessageBox.Show(person1.emailAddress);
        }       

    }
}
