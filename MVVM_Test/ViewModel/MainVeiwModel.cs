using MVVM_Test.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace MVVM_Test.ViewModel
{
    public class MainVeiwModel : ViewModelBasic
    {
        public string Text { get; set; } = "添加";
        public string Input { get; set; }
        public ObservableCollection<Student> myList { get; set; } = new ObservableCollection<Student>(); /*= new List<Student>() { new Student() { Name = "222" } };*/
        public void add_Click(object sender, RoutedEventArgs e)
        {
            Student temp = new Student();
            temp.Name = Input;

            myList.Add(temp);
        }
    }
}
