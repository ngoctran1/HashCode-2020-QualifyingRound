using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    class Library
    {
        public int Id { get; }
        public int SignUpTime { get; }
        public int BookScanRate { get; }
        public List<int> BookIds { get; }

        public Library(int id, int signUpTime, int bookScanRate, List<int> bookIds)
        {
            Id = id;
            SignUpTime = signUpTime;
            BookScanRate = bookScanRate;
            BookIds = bookIds;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("Id: " + Id);
            output.AppendLine("SignUpTime: " + SignUpTime);
            output.AppendLine("BookScanRate: " + BookScanRate);
            output.AppendLine("NumBooks: " + BookIds.Count);

            return output.ToString();
        }
    }
}
