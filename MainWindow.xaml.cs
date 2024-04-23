using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_SpecialExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // How do we declare a List
        // Array declaration ; type[]
        // List declartion ; List<type>

        // 1
        //List<CustomError> errors = new List<CustomError>();

        // 2a : Declared - Initialized in Constructor
        List<CustomError> errors;


        public MainWindow()
        {
            InitializeComponent();



            // This creates an EMPTY list of size 10
            // you can pass in an int to declare a different size
            errors = new List<CustomError>();

            // If a reference object is not INITIALIZED, it is null
            // null means there is no object in memory

            // Adding an object to our list
            // call the list name, then the .Add(object) method
            // Add() is always added to the end of the list
            // Index 0
            errors.Add(new CustomError("Err02", "Format Exception"));
            // Index 1
            errors.Add(new CustomError("Err03", "Divide By Zero"));

            // Insert(index, object)
            // list.Insert(1, new Object)
            // Allowing you to insert an object at a specific index
            errors.Insert(1, new CustomError("Err04", "IndexOutOfBounds"));

            // ------------- Removing Items from the List

            // Remove(object)
            // Removes an object by referencing the memory address of an object
            //CustomError objectToRemove = errors[0];
            //errors.Remove(objectToRemove);

            // RemoveAt(index)
            // Removes an object by index in the list
            //errors.RemoveAt(1);

            // Clear
            // Clear the entire list
            //errors.Clear();

            // Accessing Elements ----------
            // You can access an element the same way an an array
            // use square backets [index]
            //CustomError currentElement = errors[1];
            //runErrorMessages.Text = errors[1].ToString();

            // Tell if an object exists
            // Contains(object)
            //MessageBox.Show(errors.Contains(currentElement).ToString());

            // 
            //MessageBox.Show(errors.IndexOf(currentElement).ToString());

            //runErrorMessages.Text = errors[0].ToString();

            //errors.Sort();
            errors.Add(new CustomError("111", "Something Something"));
            DisplayErrors(errors);
            SaveData(errors, "DebugLog.txt");

        }

        public void SaveData(List<CustomError> list, string fileName)
        {

            //string filePath = @"C:\myFolder\myTextFile.txt";
            string filePath = $@"{Directory.GetCurrentDirectory()}\..\..\..\{fileName}";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (CustomError item in list)
                {
                    writer.WriteLine(item.ToString());
                }
                // Write more content as needed...
            }
        }

        public void DisplayErrors(List<CustomError> errors)
        {
            runErrorMessages.Text = "";
            foreach (CustomError error in errors)
            {
                runErrorMessages.Text += error + "\n";
            }
        }

        public void ListExample()
        {
            // 2b : Initialized
            errors = new List<CustomError>();


            CustomError ce = new CustomError("Err001", "Password - Not enough characters");

            // How to add something to a list
            // Adding: listName.Add(object);
            errors.Add(ce); // Adding our instance of our custom error

            //ce.ErrorMessage = "I changed this";
            // We access elements in a list, the SAME WAY as we do an array
            // using square brackets

            // Error Code - Error Message

            //runErrorMessages.Text = $"{errors[0].ErrorCode} - {errors[0].ErrorMessage}";
            runErrorMessages.Text = ce.ToString();

        }

        public void ListTextBoxExample()
        {
            List<TextBox> textboxes = new List<TextBox>
            {
                txt1,
                txt2,
                txt3,
                txt4,
                txt5
            };

            foreach (TextBox tb in textboxes)
            {
                tb.Text = "Hi all";
            }
        }


    }
}