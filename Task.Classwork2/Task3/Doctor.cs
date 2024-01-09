public class Doctor
{
    private string fullName { get; set; }
    private string speciality { get; set; }
    private int experiance { get; set; }

    public Doctor() { }
    public Doctor(string _fullName, string _speciality)
    {
        fullName = _fullName;
        speciality = _speciality;
    }
    public Doctor(string _fullName, string _speciality, int _experiance)
    {
        fullName = _fullName;
        speciality = _speciality;
        experiance = _experiance;
    }
    public string TreatPatient(string patientName)
    {
        // fullName = patientName;
        return $"{fullName} {speciality}, is treating a patient named {patientName}.";
    }
    public string PerformMedicalExamination(string patientName)
    {
        // fullName = patientName;
        return $"{fullName} is performing a medical examination for the patient named {patientName}.";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        // fullName = patientName;
        speciality = medication;
        return $"{fullName} prescribes {medication} for the patient named {patientName}.";
    }
    public void SetExperiance(int years)
    {
        experiance = years;
    }
    public int GetExperiance()
    {
        return experiance;
    }
}