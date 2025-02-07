namespace TasksForMastering.Inheritance
{
    //Task1
    public class LibraryItem
    {
        private string ItemCode;
        protected string Title;
        public string Author;

        public void SetItemCode(string itemCode)
        {
            ItemCode = itemCode;
        }

        public string GetItemCode()
        {
            return ItemCode;
        }

    }





}