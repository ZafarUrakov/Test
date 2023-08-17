namespace test;

public class ComputerClub
{
     private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();

        public ComputerClub(int computersCount)
        {
            Random random = new Random();

            for (int i = 0; i < computersCount; i++)
            {
                _computers.Add(new Computer(random.Next(5, 15)));
            }

            CreatNewClients(25, random);
        }


        public void CreatNewClients(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _clients.Enqueue(new Client(random.Next(100, 251), random));
            }
        }

        public void Work()
        {
            while (_clients.Count > 0)
            {
                Client newCLient = _clients.Dequeue();
                Console.WriteLine($"\nComputer club balance {_money} gig. We are waiting for a new client. ");
                Console.WriteLine($"You have a new client and he wants to buy {newCLient.DesiredMinutes} minutes.");
                ShowAlComputersState();

                Console.Write("\n You offer him a computer with the number:");
                string userInput = Console.ReadLine();
                // int computerNumber = Convert.ToInt32(Console.ReadLine()!) - 1;
                if (int.TryParse(userInput, out int computerNumber))
                {
                    computerNumber -= 1;
                    if (computerNumber >= 0 && computerNumber < _computers.Count)
                    {
                        if (_computers[computerNumber].IsTaken)
                        {
                            Console.WriteLine(
                                "You are trying to seat a client at a computer that is busy. The client got angry and left.");
                        }
                        else
                        {
                            if (newCLient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine("The client paid and sat down at the computer " + (computerNumber + 1));
                                _money += newCLient.Pay();
                                _computers[computerNumber].BecomeTaken(newCLient);
                            }
                            else
                            {
                                Console.WriteLine("The client has no money, he left.");
                            }
                        }
                    }
                    else
                        Console.WriteLine(
                            "You yourself do not know which table to put the client at. He got angry and left. ");
                }
                else
                {
                    CreatNewClients(1, new Random());
                    Console.WriteLine("Try again, invalid input.");
                }

                Console.WriteLine("To go to the next client, press any key.");
                Console.ReadKey();
                Console.Clear();
                SpendOneMinute();
            }
        }

        private void ShowAlComputersState()
        {
            Console.WriteLine("\nList of all computers:");
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write(i + 1 + " - ");
                _computers[i].ShowState();
            }
        }

        private void SpendOneMinute()
        {
            foreach (var computer in _computers)
            {
             computer.SpendOneMinute();   
            }
        }
}