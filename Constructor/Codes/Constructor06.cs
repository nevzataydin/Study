using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Constructor.Codes
{
    /*
     Destructor: called when an object of the class is destroyed
			At the end of the program
			While program is running and memory is full
			When gc.collect() is called
			A class can have only one destructor
			You cannot explictly call destructors
	
		When to use Destructors: if the application use unmanaged resources such as;
			Windows
			Files
			Network connections
     */
    class Constructor06
    {
        string filePath = @"ReadMe.txt";
        internal Constructor06()
        {
            Console.WriteLine("\nDestructor");
        }

        internal void ReadFile()
        {
            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("\nSoftware Developer");
                    fs.Write(author, 0, author.Length);
                }
            }
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }

        ~Constructor06()
        {
            Console.WriteLine("Destructor called (but for some reason it isnt called");
        }
    }
}
