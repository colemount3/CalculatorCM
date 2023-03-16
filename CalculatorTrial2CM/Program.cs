// See https://aka.ms/new-console-template for more information
class Program
{

    static void Main(string[] args)
    {
        
            decimal result = 0;
            while (true)
            {
            try
            {
                //instantiate variables
                decimal A = '\0';
                char B = '\0';
                decimal C = '\0';
                string input;
                string[] parts = new string[2];

                //take and convert input
                input = Console.ReadLine();

                //find B

                //first char neg handling
                if (input[0] == '-')
                {
                    //check if A neg or A result
                    for (int i = 1; i < input.Length; i++)
                    {
                        //check for second operator
                        if (input[i] == 'x' || input[i] == 'X' || input[i] == '*' || input[i] == '-' || input[i] == '+' || input[i] == '/')
                        {
                            B = input[i];
                            break;
                        }
                        //no second operator
                        else
                            B = input[0];
                    }
                    

                }
                //non first char neg

                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 'x' || input[i] == 'X' || input[i] == '*' || input[i] == '-' || input[i] == '+' || input[i] == '/')
                        {
                            B = input[i];
                            break;
                        }

                    }
                }

                //make sure contains operator
                if (input.Contains(B))
                {
                    parts = input.Split(B);
                }
           
                //using B determine A and C
                //determing if using result

                 if (B == input[0])
                {

                    A = result;

                }

                else
                {
                    A = Decimal.Parse(parts[0]);


                }

                C = Decimal.Parse(parts[1]);


                //Calculate

                if (B == '+')
                {
                    result = A + C;
                }
                else if (B == '-')
                {
                    result = A - C;
                }
                else if (B == '*' || B == 'x' || B == 'X')
                {
                    result = A * C;
                }
                else if (B == '/')
                {
                    result = A / C;
                }
             
                Console.WriteLine(result);
            }

            catch
            {
                Console.WriteLine("ERROR");
                continue;
            }

    }
     

    }
}