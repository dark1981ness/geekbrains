using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfCSLev2
{
    public class Department : INotifyPropertyChanged
    {
        private string _name;
        private int _id;
        public string Name
        {
            get => _name;
            set { _name = value;
                OnPropertyChanged();
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
