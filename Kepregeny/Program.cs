using System;
using System.Collections.Generic;
using System.IO;
using Szuperhos;

public class Kepregeny
{
    private static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

    public static void szereplok(string filePath)
    {
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        int count = int.Parse(parts[1]);
                        for (int i = 0; i < count; i++)
                        {
                            if (name.Equals("Batman", StringComparison.OrdinalIgnoreCase))
                            {
                                Batman batman = new Batman();
                                batman.kutyutKeszit();
                                szuperhosok.Add(batman);
                            }
                            else if (name.Equals("Vasember", StringComparison.OrdinalIgnoreCase))
                            {
                                Vasember vasember = new Vasember();
                                vasember.kutyutKeszit();
                                szuperhosok.Add(vasember);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hibás formátum: " + line);
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Hiba történt a fájl olvasása során: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Hibás formátum: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Hiba történt: " + e.Message);
        }
    }

    public static void szuperhosokKiirasa()
    {
        Console.WriteLine("Szuperhősök:");
        foreach (var szuperhos in szuperhosok)
        {
            Console.WriteLine(szuperhos);
        }
    }

    public static void Main(string[] args)
    {
        szereplok("szuperhosok.txt");
        szuperhosokKiirasa();
    }
}
