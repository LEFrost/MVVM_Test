using MVVM_Test.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace MVVM_Test.ViewModel
{
    public class MainVeiwModel : ViewModelBasic
    {
        private string time;
        public string Text { get; set; } = "添加";
        private string input;
        public ObservableCollection<Student> myList { get; set; } = new ObservableCollection<Student>(); /*= new List<Student>() { new Student() { Name = "222" } };*/

        public string Input
        {
            get
            {
                return input;
            }

            set
            {
                input = value;
                OnPropertyChanged("Input");
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public void add_Click(object sender, RoutedEventArgs e)
        {
            Student temp = new Student();
            temp.Name = Input;
            Debug.Write(nameof(time));
                Time = DateTime.Now.ToString();
            myList.Add(temp);
        }
    }
}
