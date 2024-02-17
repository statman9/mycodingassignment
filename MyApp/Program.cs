using System;

namespace MyProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckString myCheck = new CheckString(args[0]);
            Console.Write(myCheck.IsValidString());
        }
    }

    public class CheckString
    {
        public string stringToCheck { get; set; }
        public CheckString(string value)
        {
            stringToCheck = value;
        }

        public bool IsValidString()
        {
            // Since we haven't started iterating through the string, we start with 0 open brackets
            // by default if we don't have any open brackets we know it is valid input
            int openBrackets = 0;
            // iterate through each char in the string
            foreach (char c in stringToCheck)
            {
                // Check for open bracket
                if (c == '<')
                {
                    openBrackets++;
                }
                // Check for closed bracket
                else if (c == '>')
                {
                    // Check if we already have an open bracket, if we do we can mark it as closed
                    if (openBrackets > 0)
                    {
                        openBrackets--;
                    }
                    // if we don't have an open bracket this is an invalid string
                    else
                    {
                        return false;
                    }
                }
            }
            // Check and see if any brackets are not closed
            if (openBrackets != 0)
            {
                return false;
            }
            // If there are no issues, return that it was a valid string
            return true;
        }
    }
}