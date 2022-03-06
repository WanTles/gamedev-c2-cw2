using System;

namespace cw2_cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string charcterName = "crash";
            string superPower1 = "high jump";
            string superPower2 = "run fast";
            int age = 100;
            int hight = 140;
            double speed = 5.40;
            int power = 50;

            Console.WriteLine("my name is {0} and my super power1 is {1} my super power 2 is {2} my age is {3} my speed is {4}", charcterName, superPower1, superPower2, age, speed)

            string heroName = "sonic";
            string heroSuperPower1 = "Throwing thorns";
            string heroSuperPower2 = "emp wave";
            int heroHight = 145;
            int heroAge = 89;
            int heropower = 51;
        }
            void ageDifference(){
                if (age > heroAge) {
                    Console.WriteLine("crash is older than sonic");
                }


                void heightCheck(){
                    if (heroHight > hight) {
                        Console.WriteLine("sonic is taller than crash");
                    }


                    void checkPower() {
                        if(heropower > power) {
                            Console.WriteLine("sonic is more powerfull");
                        }
                    }
                }
              }
            }
            ageDifference();
        heightCheck();
        checkPower();
        }
    }
}
