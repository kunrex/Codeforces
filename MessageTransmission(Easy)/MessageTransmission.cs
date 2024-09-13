using System.Text;

namespace Codeforces.MessageTransmission_Easy_;

public class MessageTransmission
{
    public static void Execute()
    {
        string input = Console.ReadLine();
        if (input != null)
        {
            StringBuilder s = new StringBuilder();

            int k = -1;
            for (int i = 0, j = 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    if (k == -1)
                        k = j;
                
                    s.Append(input[i++]);
                }
                else if (s.Length != 0)
                {
                    s.Clear();
                    i = 0;
                    j = k;
                    k = -1;
                }
            }
        
            if(s.Length < input.Length / 2 + 1)
                Console.WriteLine("NO");
            else
            {
                Console.WriteLine("YES");
                Console.WriteLine(s);
            }
        }
    }
}