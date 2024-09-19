namespace DesafioProjetoHospedagem.Models;

public class Guest
{
    private string _firstName;
    private string _lastName;

    public Guest() { }

    public Guest(string firstName)
    {
        FirstName = firstName;
    }

    public Guest(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit))
                _firstName = value;
            else
                throw new ArgumentException("Nome não pode conter números.");
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit))
                _lastName = value;
            else
                throw new ArgumentException("Sobrenome não pode conter números.");
        }
    }

    public string FullName
    {
        get => $"{_firstName} {_lastName}".ToUpper();
    }
}
