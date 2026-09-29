using System;
using System.Collections.Generic;
using System.Text;

namespace DEPICSharpTask7.Part1
{
    // Q4: Static mapper class
    public static class PatientMapper
    {
        // Q4: Converts the full model into the safe DTO (drops MedicalHistory)
        public static PatientDto MapFromModelToDto(Patient patient)
        {
            return new PatientDto(patient.Id, patient.FullName, patient.PhoneNumber);
        }
    }

}
