using System;
using System.Transactions;



GrepClass Program = new();
string Text = Program.Deserialize();
List<string> TextList = Text.Split("\n").ToList();

while (true)
{
    Console.WriteLine("Choose one of the flags.\n-i (ignore case)\nIt performs a case-insensitive search.\n\n-v (invert match)\nShows rows that do not match the specified expression.\n\n-a x (after)\nSelects the word numbered x after the specified word.\n\n-b x (before)\nSelects the word numbered x before the specified word.\n\nUsage method is as in the example: -x word ");

    string? TextInput = Console.ReadLine(); if (TextInput is null) { Console.WriteLine("Input cannot be null."); break; }
    List<string> SplitWord = TextInput.Split(" ").ToList();

    string Flag = SplitWord[0];
    string Word = SplitWord[1];
    int Number = 0;

    if (SplitWord.Count == 3)
    {
        Flag = SplitWord[0];
        Number = Convert.ToInt32(SplitWord[1]);
        Word = SplitWord[2];
    }

    switch (Flag)
    {
        case $"-i":

            for (int i = 0; i < TextList.Count; i++)
            {
                Array WordList = TextList[i].Split(" ");

                for (int x = 0; x < WordList.Length; x++)
                {
                    string? xs = Convert.ToString(WordList.GetValue(x));
                    if (Word.ToLower() == xs.ToLower())
                    {
                        Console.WriteLine($"{TextList[i]} \n");
                        break;
                    }
                }
            };
            Console.WriteLine("Press any button for continue");
            Console.ReadKey();

            break;

        case "-v":

            for (int i = 0; i < TextList.Count; i++)
            {
                Array WordList = TextList[i].Split(" ");

                for (int x = 0; x < WordList.Length; x++)
                {
                    string? xs = Convert.ToString(WordList.GetValue(x));
                    if (Word == xs)
                    {
                        break;
                    }
                    else if (x + 1 == WordList.Length)
                    {
                        Console.WriteLine($"{TextList[i]} \n");
                        break;
                    }
                }
            };
            Console.WriteLine("Press any button for continue");
            Console.ReadKey();

            break;

        case "-a":

            for (int i = 0; i < TextList.Count; i++)
            {
                Array WordList = TextList[i].Split(" ");

                for (int x = 0; x < WordList.Length; x++)
                {
                    string? xs = Convert.ToString(WordList.GetValue(x));
                    if (Word == xs)
                    {
                        try
                        {
                            for (int y = 0; y < Number; y++)
                            {
                                Console.Write($"{WordList.GetValue(x + y)} ");
                            }
                            Console.Write("\n");
                        }
                        catch (System.Exception)
                        {
                            continue;
                        }
                    }
                }
            };
            Console.WriteLine("Press any button for continue");
            Console.ReadKey();

            break;
        case "-b":

            for (int i = 0; i < TextList.Count; i++)
            {
                Array WordList = TextList[i].Split(" ");

                for (int x = 0; x < WordList.Length; x++)
                {
                    string? xs = Convert.ToString(WordList.GetValue(x));
                    if (Word == xs)
                    {
                        try
                        {
                            for (int y = Number; y >= 0; y--)
                            {
                                Console.Write($"{WordList.GetValue(x-y)} ");
                            }
                            Console.Write("\n");
                        }
                        catch (System.Exception)
                        {
                            continue;
                        }
                    }
                }
            };
            Console.WriteLine("Press any button for continue");
            Console.ReadKey();

            break;
    }
}