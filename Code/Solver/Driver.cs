using System;
using System.Collections.Generic;
using System.IO;
using Structures;

namespace Solver
{
    class Driver
    {
        //static String fileName = "Data/a_example.txt";
        //static String fileName = "Data/b_read_on.txt";
        //static String fileName = "Data/c_incunabula.txt";
        //static String fileName = "Data/d_tough_choices.txt";
        //static String fileName = "Data/e_so_many_books.txt";
        static String fileName = "Data/f_libraries_of_the_world.txt";

        static void Main(string[] args)
        {
            int numBooks;
            int numLibraries;
            int deadline;

            List<Book> books = new List<Book>();
            List<Library> libraries = new List<Library>();

            using(StreamReader input = new StreamReader(fileName))
            {
                // Read in header for data
                int[] inputLine = readLine(input);
                numBooks = inputLine[0];
                numLibraries = inputLine[1];
                deadline = inputLine[2];

                // Read in book values
                inputLine = readLine(input);
                for(var i = 0; i < numBooks; i++)
                {
                    books.Add(new Book(i, inputLine[i]));
                }

                // Read in libraries
                for(var i = 0; i < numLibraries; i++)
                {
                    // Library header info
                    inputLine = readLine(input);
                    var signUpTime = inputLine[1];
                    var bookScanRate = inputLine[2];

                    // Library books
                    inputLine = readLine(input);
                    var bookIds = new List<int>();
                    for(var j = 0; j < inputLine.Length; j++) {
                        bookIds.Add(inputLine[j]);
                    }

                    // Add to list of libraries
                    libraries.Add(new Library(i, signUpTime, bookScanRate, bookIds));
                }
            }

            Console.WriteLine("Books:" + books.Count);
            Console.WriteLine("Libraries:" + libraries.Count);
        }

        static int[] readLine(StreamReader input)
        {
            var inputLine = input.ReadLine().Split(' ');
            int[] output = new int[inputLine.Length];

            for(var i = 0; i < inputLine.Length; i++)
            {
                output[i] = int.Parse(inputLine[i]);
            }

            return output;
        }
    }
}
