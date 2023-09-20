using Zadanie_2;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Którą akcję chcesz wykonać?");
                Console.WriteLine("1 - Osoba");
                Console.WriteLine("2 - Lista kolorów");
                Console.WriteLine("3 - Enum dzisiejszy dzien tygodnia");
                Console.WriteLine("4 - Dziediczenie");
                Console.WriteLine("5 - Interfejs");
                Console.WriteLine("6 - Konstruktor z parametrami");
                Console.WriteLine("7 - Bank");
                Console.WriteLine("8 - Kalkulator");
                Console.WriteLine("9 - Sortowanie");
                Console.WriteLine("10 - Obliczanie pola");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Person person1 = new Person("Kamil Kowalski", 25);
                        Person person2 = new Person("Andrzej Kowalski", 23);
                        Person person3 = new Person("Michał Kowalski", 25);
                        Console.WriteLine(person1.Name + " " + person1.Age);
                        Console.WriteLine(person2.Name + " " + person2.Age);
                        Console.WriteLine(person3.Name + " " + person3.Age);
                        break;
                    
                    case 2:
                        List<ListaKolorów> listaKolorow = new List<ListaKolorów>();
                        listaKolorow.Add(new ListaKolorów("Niebieski"));
                        listaKolorow.Add(new ListaKolorów("Czerwony"));
                        listaKolorow.Add(new ListaKolorów("Zielony"));
                        listaKolorow.Add(new ListaKolorów("Pomaranczowy"));

                        var kolory = listaKolorow.Select(kolor => kolor);

                        foreach (ListaKolorów item in kolory)
                        {
                            Console.WriteLine(item.kolor);
                        }
                        break;

                    case 3:
                        string today = DateTime.Now.ToString("dddd");
                        Console.WriteLine(today);
                        break;

                    case 4:
                        Car myCar = new Car("Auto", "Szybkie");
                        Console.WriteLine(myCar.Brand + " " + myCar.Model);
                        break;

                    case 5:
                        Interfejs.IPlayable songName = new MusicPlayer("Piosenka");
                        Interfejs.IPlayable videoName = new VideoPlayer("Film");
                        songName.Play();
                        videoName.Play();
                        break;

                    case 6:
                        Product product = new Product("Pizza", 40);
                        Product product2 = new Product("Kotlet", 15);
                        Product product3 = new Product("Pierogi", 5);
                        Product product4 = new Product("Naleśniki", 30);

                        Console.WriteLine(product.Name + ", cena: " + product.Price);
                        Console.WriteLine(product2.Name + ", cena: " + product2.Price);
                        Console.WriteLine(product3.Name + ", cena: " + product3.Price);
                        Console.WriteLine(product4.Name + ", cena: " + product4.Price);
                        break;

                    case 7:

                        BankAccount bankaccount = new BankAccount(2000);
                        Console.WriteLine("Którą akcję chcesz wykonać?: ");
                        Console.WriteLine("1 - Deposit, 2 - Withdraw");
                        int option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Ile chcesz wpłacić środków?: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            bankaccount.Deposit(amount);
                            Console.WriteLine("Środki wpłacone.");
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Ile chcesz wypłacić środków?: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            bankaccount.Withdraw(amount);
                            Console.WriteLine("Środki wypłacone.");
                        }
                        else
                        {
                            Console.WriteLine("Źle wybrana akcja.");
                        }
                        break;
                    case 8:
                        Kalkulator kalkulator = new Kalkulator();
                        Console.WriteLine("Podaj pierwszą cyfre: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj drugą cyfre:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj symbol jaki chcesz użyć: ");
                        Console.WriteLine("Do wyboru: +, -, *, /.");
                        string symbol = Console.ReadLine();
                        switch (symbol)
                        {

                            case "+":
                                kalkulator.Addition(num1, num2);
                                break;
                            case "-":
                                kalkulator.Subtraction(num1, num2);
                                break;
                            case "*":
                                kalkulator.Multiplication(num1, num2);
                                break;
                            case "/":
                                kalkulator.Division(num1, num2);
                                break;
                            default:
                                Console.WriteLine("Nie poprawny znak.");
                                break;
                        }
                        break;
                    case 9:
                        List<Sortowanie> sortowanie = new List<Sortowanie>();
                        sortowanie.Add(new Sortowanie(1));
                        sortowanie.Add(new Sortowanie(2));
                        sortowanie.Add(new Sortowanie(20));
                        sortowanie.Add(new Sortowanie(299202));
                        sortowanie.Add(new Sortowanie(0));
                        sortowanie.Add(new Sortowanie(-152));
                        sortowanie.Sort();
                        foreach (Sortowanie item in sortowanie)
                        {
                            Console.WriteLine(item.Liczba);
                        }
                        break;
                    case 10:
                        Console.WriteLine("Pole którego kształtu chcesz obliczyc?");
                        Console.WriteLine("Koła - 1, Prostokątu - 2");
                        int option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                Console.WriteLine("Podaj wartość promienia koła");
                                double promien = Convert.ToDouble(Console.ReadLine());
                                Circle circle = new Circle(promien);
                                circle.CalculateArea();
                                break;
                            case 2:
                                Console.WriteLine("Podaj długość a prostokąta");
                                double a = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Podaj długość b prostokąta");
                                double b = Convert.ToDouble(Console.ReadLine());
                                Rectangle rectangle = new Rectangle(a, b);
                                rectangle.CalculateArea();
                                break;
                            default:
                                Console.WriteLine("Podano zły parametr");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Podano zły parametr");
                        break;
                }
                Console.WriteLine("Chcesz wykonać inne zadanie?(t/n)");
                value = Console.ReadLine();
            } while (value == "t" || value == "T");
        }
    }
}
