using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    class Book
    {
        public int Id { get; }
        public int Value { get; }

        public Book(int id, int value)
        {
            Id = id;
            Value = value;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("Id: " + Id);
            output.AppendLine("Value: " + Value);

            return output.ToString();
        }
    }
}
