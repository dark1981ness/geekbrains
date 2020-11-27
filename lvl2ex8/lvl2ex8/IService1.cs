using System;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace lvl2ex8
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DataSet GetSummary();

        [OperationContract]
        DataSet GetAllDepartments();
    }

    [DataContract]
    public class Employee
    {
        int _departmentid;
        string _name;
        string _surname;
        string _patronymic;
        DateTime _birthday;
        byte _age;
        float _salary;
        string _position;
        string _phone;
        string _email;

        [DataMember]
        public int DepartmentId
        {
            get => _departmentid;
            set
            {
                _departmentid = value;
            }
        }

        [DataMember]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        [DataMember]
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
            }
        }

        [DataMember]
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
            }
        }

        [DataMember]
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
            }
        }

        [DataMember]
        public byte Age
        {
            get => _age;
            set
            {
                _age = value;
            }
        }

        [DataMember]
        public float Salary
        {
            get => _salary;
            set
            {
                _salary = value;
            }
        }

        [DataMember]
        public string Position
        {
            get => _position;
            set
            {
                _position = value;
            }
        }

        [DataMember]
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
            }
        }

        [DataMember]
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }
    }

    [DataContract]
    public class Department
    {
        string _name;
        int _id;

        [DataMember]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        [DataMember]
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
    }
}
