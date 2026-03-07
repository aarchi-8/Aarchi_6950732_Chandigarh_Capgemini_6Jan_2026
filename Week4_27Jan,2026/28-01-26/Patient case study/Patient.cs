using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_case_study
{
    internal class Patient
    {
        string _name;
        int _age;
        string _illness;
        string _city;

        public Patient()
        {

        }
        public Patient(string name, int age, string illness, string city)
        {
            this._name = name;
            this._age = age;
            this._illness = illness;
            this._city = city;
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string illness
        {
            get
            {
                return _illness;
            }
            set
            {
                _illness = value;
            }
        }
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-21}{1,-6}{2,-17}{3,-20}", this._name, this._age, this._illness, this._city);
        }
    }
}