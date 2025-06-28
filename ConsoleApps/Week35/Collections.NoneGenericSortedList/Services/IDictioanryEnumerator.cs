using PhoneBookSystem.Models;

namespace Collections.NoneGenericSortedList.Services
{
    internal interface IDictioanryEnumerator
    {
        Contact Value { get; }

        bool MoveNext();
    }
}