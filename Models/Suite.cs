namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        private string _suiteType;
        private int _capacity;
        private decimal _dailyRate;

        public Suite() { }

        public Suite(string suiteType, int capacity, decimal dailyRate)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            DailyRate = dailyRate;
        }

        public string SuiteType
        {
            get => _suiteType;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit))
                {
                    _suiteType = value;
                }
                else
                {
                    throw new ArgumentException("Suite não pode conter números.");
                }
            }
        }

        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
                else
                {
                    throw new ArgumentException("Capacidade deve ser um número inteiro positivo.");
                }
            }
        }

        public decimal DailyRate
        {
            get => _dailyRate;
            set
            {
                if (value >= 0)
                {
                    _dailyRate = value;
                }
                else
                {
                    throw new ArgumentException("Diária deve ser um número decimal positivo");
                }
            }
        }
    }
}
