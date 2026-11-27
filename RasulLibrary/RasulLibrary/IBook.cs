using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasulLibrary
{
    public interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }
        void DisplayInfo();
    }
}
