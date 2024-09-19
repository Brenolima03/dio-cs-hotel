using DesafioProjetoHospedagem.Models;

List<Guest> economicGuests = new List<Guest>();
List<Guest> normalGuests = new List<Guest>();
List<Guest> premiumGuests = new List<Guest>();

// Guests for the economic suite
Guest leonardo = new Guest(firstName: "Leonardo", lastName: "da Vinci");
Guest michelangelo = new Guest(firstName: "Michelangelo", lastName: "Buonarroti");

economicGuests.Add(leonardo);
economicGuests.Add(michelangelo);

// Guests for the normal suite
Guest raphael = new Guest(firstName: "Raphael", lastName: "Sanzio");
Guest titian = new Guest(firstName: "Titian", lastName: "Vecellio");

normalGuests.Add(raphael);
normalGuests.Add(titian);

// Guests for the premium suite
Guest botticelli = new Guest(firstName: "Sandro", lastName: "Botticelli");
Guest brunelleschi = new Guest(firstName: "Filippo", lastName: "Brunelleschi");

premiumGuests.Add(botticelli);
premiumGuests.Add(brunelleschi);

// Create suites
Suite economic = new Suite(suiteType: "Economic", capacity: 4, dailyRate: 30);
Suite normal = new Suite(suiteType: "Normal", capacity: 3, dailyRate: 50);
Suite premium = new Suite(suiteType: "Premium", capacity: 2, dailyRate: 100);

// Reserve for economic suite
Reservation economicReservation = new Reservation(reservedDays: 5);
economicReservation.RegisterSuite(economic);
economicReservation.RegisterGuests(economicGuests);

// Reserve for normal suite
Reservation normalReservation = new Reservation(reservedDays: 7);
normalReservation.RegisterSuite(normal);
normalReservation.RegisterGuests(normalGuests);

// Reserve for premium suite
Reservation premiumReservation = new Reservation(reservedDays: 10);
premiumReservation.RegisterSuite(premium);
premiumReservation.RegisterGuests(premiumGuests);

// Console output
Console.WriteLine("---- Suite econômica ----");
Console.WriteLine($"Hóspedes: {economicReservation.GetNumberOfGuests()}");
Console.WriteLine($"Total diária: {economicReservation.CalculateDailyRate()}");

Console.WriteLine("\n---- Suite normal ----");
Console.WriteLine($"Hóspedes: {normalReservation.GetNumberOfGuests()}");
Console.WriteLine($"Total diária: {normalReservation.CalculateDailyRate()}");

Console.WriteLine("\n---- Suite Premium ----");
Console.WriteLine($"Hóspedes: {premiumReservation.GetNumberOfGuests()}");
Console.WriteLine($"Total diária: {premiumReservation.CalculateDailyRate()} (com desconto)");
