using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University_LSP.Models
{
    interface IBookable
    {
        public override void BookTheRoom(Person booker)
        {
            Console.WriteLine($"The Conference room was booked by {booker.FirstName} {booker.LastName}");
        }
    }
}
