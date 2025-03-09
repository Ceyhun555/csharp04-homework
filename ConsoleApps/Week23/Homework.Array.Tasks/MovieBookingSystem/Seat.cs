namespace Homework.Array.Tasks.MovieBookingSystem
{
    class Seat
    {
        public int Row { get; }
        public int Col { get; }
        public bool IsBooked { get; set; }

        public Seat(int row, int col)
        {
            Row = row;
            Col = col;
            IsBooked = false;
        }
    }
}
