using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.NoneGenericSortedList.Services
{
    internal interface IFileService
    {
        /*1 ci method fayl movcuddurmu. 
         * 2 ci method save to file.
         * 3 cu method read from file.
         * 
        */
        
        void SaveToFile(SortedList _contacts);
        SortedList ReadFromFile();
    }
}
