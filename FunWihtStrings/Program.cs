using System;


namespace FunWihtStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter minimum 5 words and press 'Enter'.");
            while (true)
            {
                
                string inputUserText = Console.ReadLine();
                string[] arrUserText = inputUserText.Split(' ');
                char[] arrUserChar = new char[0];
                if (arrUserText.Length < 5)
                {
                    Console.WriteLine("ENTER MINIMUM 5 WORDS!");
                }
                else
                {
                    arrUserChar = inputUserText.ToCharArray();

                    for (int i = 0; i < arrUserText.Length; i++)
                    {

                        // Перевірка на парність та реверс слова
                        if ((i % 2) != 0)
                        {
                            char[] arr = arrUserText[i].ToCharArray();
                            Array.Reverse(arr);
                            arrUserText[i] = new string(arr);
                        }
                        arrUserChar = arrUserText[i].ToCharArray();
                        for (int k = 0; k < arrUserChar.Length; k++)
                        {
                           
                            // Заміна числ на '-'
                            if (arrUserChar[k] >= '0' && arrUserChar[k] <= '9')
                            {
                                arrUserChar[k] = '-';
                            }
                            
                            //Заміна перших і останніх літер
                            if (arrUserChar[0] == 'p' || arrUserChar[0] == 'P')
                            {
                                arrUserChar[k] = 's';
                            }
                            if (arrUserChar[arrUserChar.Length - 1] == 'n' || arrUserChar[arrUserChar.Length -1] == 'N')
                            {
                                arrUserChar[arrUserChar.Length - 1] = 'o';
                            }
                           
                            // Заміна регістру
                            if (k == 0)
                            {
                                string str = char.ToString(arrUserChar[k]);
                                string upper = str.ToUpper();
                                char[] arr = upper.ToCharArray();
                                arrUserChar[k] = arr[0];
                            }
                            else
                            {
                                string str = char.ToString(arrUserChar[k]);
                                string lower = str.ToLower();
                                char[] arr = lower.ToCharArray();
                                arrUserChar[k] = arr[0];
                            }
                            arrUserText[i] = new string(arrUserChar);

                        }

                    }

                    inputUserText = string.Join(" ", arrUserText);
                    Console.Write("Very good, your answer: ");
                    Console.WriteLine(inputUserText);
                    Console.WriteLine("Press 'Q' for exit or try again and enter 5 words.");
                    if (Console.ReadKey().Key == ConsoleKey.Q)
                    {
                        return;
                    }

                }

            }

        }
    }
}