namespace Homework.Array.Tasks
{
    class Chatbot
    {
        private ChatbotResponse[] responses;
        private int count;

        public Chatbot(int size)
        {
            responses = new ChatbotResponse[size];
            count = 0;
        }

        public void AddResponse(string question, string answer)
        {
            if (count < responses.Length)
            {
                responses[count] = new ChatbotResponse { Question = question, Answer = answer };
                count++;
            }
        }

        public string GetResponse(string question)
        {
            for (int i = 0; i < count; i++)
            {
                if (responses[i] != null && responses[i].Question == question)
                {
                    return responses[i].Answer;
                }
            }
            return "I don't understand that question.";
        }
    }

}
