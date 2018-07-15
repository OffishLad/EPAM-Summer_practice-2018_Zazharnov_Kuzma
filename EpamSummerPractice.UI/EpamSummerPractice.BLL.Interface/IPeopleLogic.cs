﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace EpamSummerPractice.BLL.Interface
{
    public interface IPeopleLogic
    {
        int Add(string name, string surname, DateTime dateOfBirth, 
            int age, string city, string street, string house_number);
        void Update(int id, string name, string surname, DateTime dateOfBirth,
            int age, string city, string street, string house_number);
        void Delete(int id);
        Person ShowById(int id);
        IEnumerable<Person> GetAll();
        string ToString(Person person);
    }
}
