using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Async
    {
        int totalsteps = 3;
        int currentstep = 0;

        public void ShowSrogress()
        {
            int percent = (currentstep * 100) / totalsteps;
            Console.WriteLine(percent+"% Done");
        }
        public async Task<string> GetUserNameAsync()
        {
            await Task.Delay(7000); 
            currentstep++;
            ShowSrogress();
            return "Rita";
            
        }
        public async Task<int> GetUserAgeAsync()
        {
            await Task.Delay(3000); 
            currentstep++;
            ShowSrogress();
            return 26;
            
        }
        public async Task<string> GetUserLocationAsync()
        {

            await Task.Delay(2000); 
            currentstep++;
            ShowSrogress();
            return "New York";
            

        }

        public async Task<string> BuildProfileAsync(string name,int age,string location)
        {
            await Task.Delay(3000);
            return $"Name: {name}\nAge: {age}\nLocation: {location}";
        }

    }


}
