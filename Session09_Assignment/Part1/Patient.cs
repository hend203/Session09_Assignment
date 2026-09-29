using System;
using System.Collections.Generic;
using System.Text;

namespace DEPICSharpTask7.Part1
{
    //1. Create a class Patient with a primary constructor
    public class Patient(int id, string fullName, string phoneNumber, string medicalHistory)
    {
        public int Id { get; } = id;
        public string FullName { get; } = fullName;
        public string PhoneNumber { get; } = phoneNumber;
        public string MedicalHistory { get; } = medicalHistory;

        // Q1: Override ToString() 
        public override string ToString()
        {
            return $"Id: {Id} :: FullName: {FullName} :: PhoneNumber: {PhoneNumber} :: MedicalHistory: {MedicalHistory}";
        }
    }
}

