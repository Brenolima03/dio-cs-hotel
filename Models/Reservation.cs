namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        private List<Guest> _guests = new List<Guest>();
        private Suite _suite;
        private int _reservedDays;

        public List<Guest> Guests
        {
            get => _guests;
            set => _guests = value;
        }

        public Suite Suite
        {
            get => _suite;
            set => _suite = value;
        }

        public int ReservedDays
        {
            get => _reservedDays;
            set
            {
                if (value > 0)
                {
                    _reservedDays = value;
                }
                else
                {
                    throw new ArgumentException("Os dias reservados devem ser um número inteiro positivo.");
                }
            }
        }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Guest> guests)
        {
            if (guests.Count <= _suite.Capacity)
            {
                _guests = guests;
            }
            else
            {
                throw new InvalidOperationException("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            _suite = suite;
        }

        public int GetNumberOfGuests()
        {
            return _guests.Count;
        }

        public decimal CalculateDailyRate()
        {
            decimal rate = _reservedDays * _suite.DailyRate;

            if (_reservedDays >= 10)
            {
                rate -= rate * 0.1m;
            }

            return rate;
        }
    }
}
