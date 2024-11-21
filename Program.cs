using System;
using System.Transactions;



GrepClass Program = new();
string Text = Program.Deserialize();
while(true)
{
    List<string> TextList = Text.Split(" ").ToList();
   // int x = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(TextList[x]);

    // GİRİLEN KELİMEYLE DOSYA İÇERİSİNDE EŞLEŞEN KELİME VAR MI KONTROL ET
    int a = TextList.FindIndex(x => x.StartsWith("King"));
    System.Console.WriteLine(TextList[(a)]); 
}
