using System;

public class Patient
{
    // Поля класса для хранения информации о пациенте
    private string lastName;
    private string firstName;
    private string surName;
    private string address;
    private string medicalCardNumber;
    private string diagnosis;

    // Пустой конструктор, инициализирует все поля пустыми строками
    public Patient()
    {
        lastName = string.Empty;
        firstName = string.Empty;
        surName = string.Empty;
        address = string.Empty;
        medicalCardNumber = string.Empty;
        diagnosis = string.Empty;
    }

    // Конструктор с параметрами для инициализации полей
    public Patient(string lastName, string firstName, string patronymic, string address, string medicalCardNumber, string diagnosis)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.surName = patronymic;
        this.address = address;
        this.medicalCardNumber = medicalCardNumber;
        this.diagnosis = diagnosis;
    }

    // Методы доступа для получения значений полей
    public string GetLastName() => lastName;
    public string GetFirstName() => firstName;
    public string GetPatronymic() => surName;
    public string GetAddress() => address;
    public string GetMedicalCardNumber() => medicalCardNumber;
    public string GetDiagnosis() => diagnosis;

    // Метод для отображения информации о пациенте
    public void Show()
    {
        Console.WriteLine($"ФИО: {lastName} {firstName} {surName}, Адрес: {address}, Номер мед. карты: {medicalCardNumber}, Диагноз: {diagnosis}");
    }
}

class Program
{
    static void Main()
    {
        // Создаем массив пациентов с заданными данными
        Patient[] patients = new Patient[]
        {
            new Patient("Иванов", "Иван", "Иванович", "Улица Пушкина, д. 1", "123456", "Грипп"),
            new Patient("Петров", "Петр", "Петрович", "Улица Лермонтова, д. 2", "234567", "ОРВИ"),
            new Patient("Сидорова", "Анна", "Сидоровна", "Улица Чехова, д. 3", "345678", "Грипп"),
            new Patient("Григорьев", "Григорий", "Григорьевич", "Улица Толстого, д. 4", "456789", "Бронхит")
        };

        // Выводим пациентов с диагнозом 'Грипп'
        Console.WriteLine("Пациенты с диагнозом 'Грипп':");
        foreach (var patient in patients)
        {
            if (patient.GetDiagnosis() == "Грипп")
            {
                patient.Show();
            }
        }

        // Запрашиваем у пользователя нижнюю и верхнюю границы для фильтрации по номеру мед. карты
        Console.WriteLine("Введите нижнюю границу интервала номера медицинской карты:");
        string lowerBound = Console.ReadLine();
        Console.WriteLine("Введите верхнюю границу интервала номера медицинской карты:");
        string upperBound = Console.ReadLine();

        // Выводим пациентов с номерами мед. карт в заданном интервале
        Console.WriteLine($"Пациенты с номерами медицинской карты в интервале {lowerBound} - {upperBound}:");
        foreach (var patient in patients)
        {
            // Сравниваем номера мед. карт с границами интервала
            if (String.Compare(patient.GetMedicalCardNumber(), lowerBound) >= 0 &&
                String.Compare(patient.GetMedicalCardNumber(), upperBound) <= 0)
            {
                patient.Show();
            }
        }

        // Создаем нового пациента с пустыми полями и отображаем информацию
        Patient newPatient = new Patient();
        newPatient.Show();
    }
}
