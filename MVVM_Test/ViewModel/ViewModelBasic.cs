using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Test.ViewModel
{
   public class ViewModelBasic : INotifyPropertyChanged
    {

        //public ICommand TestCommand { get; set; }
        //public ICommand ManipulationCommand { get; set; }
        //public ICommand GetImageCommand { get; set; }
        //public EventHandler UiStoryboard { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
