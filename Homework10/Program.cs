using System.Text.RegularExpressions;

const string phoneNumberPattern = @"^[+]?\d{12}$";
const string emailPattern = @"^[a-z]+\d*[@][a-z]+[.][a-z]{2,5}$";
const string fioPattern = @"^([A-Z]{1}[a-z]{1,19}\s){2}[A-Z]{1}[a-z]{1,19}$";

string phoneNumber = "+380980592066";
string TestEmail = "pupok@gmail.com";
string Fio = "Vasya Vasya Vasya";

bool IsPhoneNumber(string PhoneNumber)
{
    if (PhoneNumber != null)
        return Regex.IsMatch(PhoneNumber, phoneNumberPattern);
    return false;
}

bool IsEmail(string Email)
{
    if (Email != null)
        return Regex.IsMatch(Email, emailPattern);
    return false;
}

bool ValidateFio(string Fio)
{
    if (Fio != null)
        return Regex.IsMatch(Fio, fioPattern);
    return false;
}



Console.WriteLine(IsPhoneNumber(phoneNumber));

Console.WriteLine(IsEmail(TestEmail));

Console.WriteLine(ValidateFio(Fio));