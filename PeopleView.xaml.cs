using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Login_PeopleManager_App
{
    /// <summary>
    /// Logic for PeopleView.xaml
    /// </summary>
    public partial class PeopleView : UserControl
    {
        public ObservableCollection<Person> people = new ObservableCollection<Person>
        {
            new Person { Name = "Anna", Age = 23 },
            new Person { Name = "Nataly", Age = 45 },
            new Person { Name = "Willi", Age = 30 },
            new Person { Name = "Stefan", Age = 38 }
        };

        public PeopleView()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = people;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            string nameInput = NameInput.Text;//text which i'm writing in text box
            string ageInput = AgeInput.Text;
            int age;

            if (!string.IsNullOrEmpty(nameInput) && !string.IsNullOrEmpty(ageInput))
            {
                if (int.TryParse(ageInput, out age))
                {
                    Person person = new Person { Name = nameInput, Age = age };
                    people.Add(person);

                    NameInput.Clear();
                    AgeInput.Clear();
                }
                else { MessageBox.Show("Age must be a number"); }
            }
            else 
            {
                MessageBox.Show("Empty stroke");
            }
        }
        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedPeople = ListBoxPeople.SelectedItems.Cast<Person>().ToList();//It makes all items in Person and then again in List, makes a copy for safety

            foreach (var person in selectedPeople)
            {
                people.Remove(person);
            }

        }


        private void OnNameChanged(object sender, TextChangedEventArgs e)
        {
            Add_Button.IsEnabled = !string.IsNullOrEmpty(NameInput.Text);
        }
        private void OnAgeChanged(object sender, TextChangedEventArgs e)
        {
            Add_Button.IsEnabled = !string.IsNullOrEmpty(AgeInput.Text);
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Delete_Button.IsEnabled = ListBoxPeople.SelectedItems.Count >= 1;
        }
    }
}
