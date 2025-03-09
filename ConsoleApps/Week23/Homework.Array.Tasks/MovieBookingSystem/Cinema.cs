namespace Homework.Array.Tasks.MovieBookingSystem
{
    class Cinema
    {
        private Seat[,] seats;
        private int rows, cols;

        public Cinema(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            seats = new Seat[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    seats[i, j] = new Seat(i, j);
                }
            }
        }

        public void BookSeat(int row, int col)
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                if (!seats[row, col].IsBooked)
                {
                    seats[row, col].IsBooked = true;
                    Console.WriteLine($"Seat at ({row}, {col}) booked successfully.");
                }
                else
                {
                    Console.WriteLine($"Seat at ({row}, {col}) is already booked.");
                }
            }
            else
            {
                Console.WriteLine("Invalid seat position.");
            }
        }

        public void DisplayAvailableSeats()
        {
            Console.WriteLine("Available seats:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!seats[i, j].IsBooked)
                    {
                        Console.Write($"[{i},{j}] ");
                    }
                    else
                    {
                        Console.Write("[X] ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
