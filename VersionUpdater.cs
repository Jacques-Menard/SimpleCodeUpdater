using System;

namespace versionUpdater
{
    /*Calls File Reader to update all instances of a version string with another version string in an input file.
      exp: Repalces all instances of "1.5.0.0" with "1.6.0.0" in a file called RandomNumGenerator.cs
        Author: Jac Menard
        Version: "0.0.0.1"
    */  
    class VersionUpdater
    {
        static void Main(string[] args)
        {
            //Initilizing input fields
            string oldVers = "";
            string newVers = "";
            string fileLoc = "";

            //Basic User Interface
            Console.WriteLine("Please enter your file location: ");
            fileLoc = Console.ReadLine();

            Console.WriteLine("Please enter the version number you'd like replaced: ");
            oldVers = Console.ReadLine();

            Console.WriteLine("Please enter the new version number: ");
            newVers = Console.ReadLine();

            //Creates a new instance of FileReader and then updates the file using it
            FileReader myFileReader = new FileReader(fileLoc, oldVers, newVers);
            myFileReader.UpdateFile();

        }
    }
}
