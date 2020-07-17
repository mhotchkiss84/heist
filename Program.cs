using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Message
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter A Team Members Name");
            // Getting the input for the Name value
            string NameInput = Console.ReadLine();
            // Creating a new team member with the user input for the name
            TeamMember userInputTeamMember = new TeamMember(){
                Name = NameInput
            };
            // Prompting the user to enter a skill level for the team member
            Console.WriteLine("Enter A Team Members Skill Level With A Positive Whole Number");
            // Declaring a bool for keeping in the loop for error/value handling
            bool SkillSet = false;
            // While loop for user input to ensure its only a positive int
            while (SkillSet == false)
            {
                // Try to catch exception if not an int
                try{
                    userInputTeamMember.SkillLevel = Int32.Parse(Console.ReadLine());
                    // Checking if the user input is greater than 0 / positive
                    if(userInputTeamMember.SkillLevel > 0){
                        SkillSet = true;
                    } else{
                        Console.WriteLine("Please Enter A Whole Positive Number");
                    }
                // Prompting the user to enter a number in the correct format
                 } catch (Exception){
                    Console.WriteLine("Please Enter A Whole Positive Number");
                }
            }
            // Added a blank line for spacing / readability
            Console.WriteLine(""); 
            // Writing Out The User Inputs  
            Console.WriteLine($"The Team Members Name Is: {userInputTeamMember.Name}");           
            Console.WriteLine($"Their Skill Level Is: {userInputTeamMember.SkillLevel}");
            // Prompting the user to enter the courage factor from 0.0-2.0
            Console.WriteLine("Enter A Team Members Courage Factor From 0.0 to 2.0");
            bool CourageSet = false;
            while (CourageSet == false)
            {
                try{
                    userInputTeamMember.CourageFactor = float.Parse(Console.ReadLine());
                    if(userInputTeamMember.CourageFactor >=0 && userInputTeamMember.CourageFactor <= 2.1){
                        Console.WriteLine(userInputTeamMember.CourageFactor);
                        CourageSet = true;
                    } else{
                        Console.WriteLine("Please enter a number from 0.0 - 2.0");
                    }
                 } catch (Exception){
                    Console.WriteLine("Please enter a number from 0.0 - 2.0");
                }
            }
        }
    }
}
