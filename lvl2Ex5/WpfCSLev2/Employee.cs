using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfCSLev2
{
    public class Employee : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _birthday;
        private byte _age;
        private float _salary;
        private string _position;
        private string _phone;
        private string _email;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
                OnPropertyChanged();
            }
        }
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
                OnPropertyChanged();
            }
        }
        public byte Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }
        public float Salary
        {
            get => _salary;
            set
            {
                _salary = value;
                OnPropertyChanged();
            }
        }

        public string Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public Employee()
        {

        }
        public Employee(int id, string name, string surname, string patronymic, DateTime birthday, byte age, float salary, string position, string phone, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            Age = age;
            Salary = salary;
            Position = position;
            Phone = phone;
            Email = email;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
