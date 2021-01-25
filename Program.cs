using System;

namespace Uppgift_9
{
    class Program
    {
        static int pScore = 0;
        static int cScore = 0;
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            pScore = 0;
            cScore = 0;
            
            
            do{
                Console.Clear();
                Console.WriteLine("Lets play!");
                
                Play();

                Console.WriteLine("Current score: Player score = "+pScore+" | Computer score = "+cScore);

                Console.WriteLine("Press 'y' if you are done and anything else to continue.");
            }while(Console.ReadKey(true).KeyChar != 'y');

            Console.WriteLine("Final score: Player score = "+pScore+" | Computer score = "+cScore);

            Console.ReadKey();
        }

        static void Play(){
            int cPlay = 0;
            switch(rand.Next(1,4)){
                case 1:
                    Disp(1);
                    Console.WriteLine("vs.");
                    cPlay = rand.Next(1,4);
                    switch(cPlay){
                        case 1:
                            Disp(1);
                            Console.WriteLine("It's a tie!");
                            break;
                        
                        case 2:
                            Disp(2);
                            Console.WriteLine("Computer player wins!");
                            Program.cScore++;
                            break;
                        
                        case 3:
                            Disp(3);
                            Console.WriteLine("You win!");
                            pScore++;
                            break;
                    }
                    break;
                
                case 2:
                    Disp(2);
                    Console.WriteLine("vs.");
                    cPlay = rand.Next(1,4);
                    switch(cPlay){
                        case 1:
                            Disp(1);
                            Console.WriteLine("You win!");
                            pScore++;
                            break;
                        
                        case 2:
                            Disp(2);
                            Console.WriteLine("It's a tie!");
                            break;
                        
                        case 3:
                            Disp(3);
                            Console.WriteLine("Computer player wins!");
                            cScore++;
                            break;
                    }
                    break;
                
                case 3:
                    Disp(3);
                    Console.WriteLine("vs.");
                    cPlay = rand.Next(1,4);
                    switch(cPlay){
                        case 1:
                            Disp(1);
                            Console.WriteLine("Computer player wins!");
                            cScore++;
                            break;
                        
                        case 2:
                            Disp(2);
                            Console.WriteLine("You win!");
                            pScore++;
                            break;
                        
                        case 3:
                            Disp(3);
                            Console.WriteLine("It's a tie!");
                            break;
                    }
                    break;
            }
        }

        static void Disp(int a){
            switch(a){
                case 1:
                    Console.WriteLine("    _______\n---'   ____)\n      (_____)\n      (_____)\n      (____)\n---.__(___)");
                    break;
                
                case 2:
                    Console.WriteLine("    _______\n---'   ____)____\n          ______)\n          _______)\n         _______)\n---.__________)");
                    break;
                
                case 3:
                    Console.WriteLine("    _______\n---'   ____)____\n          ______)\n       __________)\n      (____)\n---.__(___)");
                    break;
            }
        }
    }
}