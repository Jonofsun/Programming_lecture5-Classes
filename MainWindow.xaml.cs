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

namespace Programming_lecture5_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Create a new Class called student

        // what is an instance?
        // instantiate = declare and instantiate / instance

        // two types of data: Value and reference

        //string firstName;
        //string lastName;
        //double gradeCSI;
        //double gradeGenEd;
        // how to add a class?
        // right click on file under our solution, select add, then class
        List<Student> students = new List<Student>();
        //string[] firstNames = { };
        public MainWindow()
        {
            InitializeComponent();
            //movie darkNight = new movie();// this is how you create a new instance / NEW means a new object in memory
            //darkNight.movieName = "Dark Night";
            //darkNight.year = 2008;

            //MessageBox.Show(darkNight.movieName);
            Student student = new Student("Jonathan", "Reed", 100, 95);
            Student student2 = new Student("Luffy", "Monkey D", 90, 80);
            Instructor Jonathan = new Instructor("Reed", "Jonathan", "Pnumber");
            
            //student.FirstName = "Jonathan";
            //student.LastName = "Reed";
            //student.GradeCSI = 100;
            //student.GradeGenEd = 95;

            students.Add(student);
            students.Add(student2);
            MessageBox.Show(Jonathan.Lastname);
            //MessageBox.Show(FormatStudent(student));



        }
        public string FormatStudent(Student student)
        {
            string studentInformation = student.FirstName + " " + student.LastName + " - " +
                student.GradeCSI + " - " + student.GradeGenEd;

            return studentInformation;
        }
    }
}
