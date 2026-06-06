using System;
using System.Threading;
using System.Collections.Generic;

namespace MindfulnessApp
{


    class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity()
        {
        }



        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description + "\n");
            Console.Write("How long, in seconds, would you like for your session? ");
            
            if (!int.TryParse(Console.ReadLine(), out _duration))
            {
                _duration = 30; 
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
          }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
              {
                Console.Write(animationStrings[i]) ;
                Thread.Sleep(250);
                Console.Write("\b \b");
                i = (i + 1) % animationStrings.Count ;
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                
                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}