using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CS3020_Final_Project_Music_Libary_Differences_school
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///     INPUT FILES MUST HAVE EACH SONG ON A SEPERATE LINE WITH ARTIST NAME
            ///     PUT INPUT IN ALL CAPS
            ///     SEPERATE ARTIST NAME AND SONG NAME WITH |
            ///     CHANGE SQUARE BRACKESTS TO PARENTHESIS
            ///     
            ///     EXTRA:
            ///     USE NOTEPAD++ CODE ALIGNMENT WITH | (Can also use code below)
            ///     USE FIND AND REPLACE TO ADD EXTRA TABS AND SPACES IN THE NEEEDED FILE 
            /// </summary>





            /// <summary>
            /// FOR INPUT FILE BEFORE ACTUAL PROGRAM
            /// REMOVE DUPLICATES WITHIN SONGS TO CHECK FILE
            /// </summary>
            //https://www.textfixer.com/tools/remove-duplicate-lines.php





            /// <summary>
            /// FOR INPUT FILE BEFORE ACTUAL PROGRAM
            /// TEXT ALIGNMENT
            /// </summary>
            //string line;
            //List<string> linesToKeep = new List<string>();
            //string tempFile = Path.GetTempFileName();
            //StreamReader file = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    string[] leftAndRight = line.Split('|');
            //    linesToKeep.Add($"{leftAndRight[0].Trim(),-61}" + "|" + leftAndRight[1].Trim());
            //}
            //File.WriteAllLines(tempFile, linesToKeep);
            //file.Close();
            //File.Delete(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //File.Move(tempFile, @AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");





            /// <summary>
            /// BEGINING OF ACTUAL PROGRAM
            /// GETS RID OF EXACT MATCHES IGNORING JUNK FROM STRINGS
            /// </summary>
            //string line;
            //string l;
            //int foundMatch;
            //int count;
            //string lineWithoutJunk;
            //string[] lineFromItunesFileSplit;
            //List<string> lineFromItunesFileSwappedAroundDelimiter = new List<string>();
            //List<string> linesToKeep = new List<string>();
            //List<string> Itunes_Songs_Caps = new List<string>();
            //StreamReader file2 = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Itunes_Songs_Caps.txt");
            //StreamReader file = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //while ((l = file2.ReadLine()) != null)
            //{
            //    Itunes_Songs_Caps.Add(l);
            //}
            //file2.Close();
            //for (int i = 0; i < Itunes_Songs_Caps.Count; i++)
            //{
            //    lineFromItunesFileSplit = RemoveJunk(Itunes_Songs_Caps[i]).Split('|');
            //    lineFromItunesFileSwappedAroundDelimiter.Add(lineFromItunesFileSplit[1] + "|" + lineFromItunesFileSplit[0]);
            //}
            //Console.WriteLine("\nCheck Songs Below for Different Versions:\n");
            //while ((line = file.ReadLine()) != null)
            //{
            //    foundMatch = 0;
            //    count = 0;
            //    lineWithoutJunk = RemoveJunk(line);
            //    while (count < Itunes_Songs_Caps.Count && foundMatch == 0)
            //    {
            //        if (RemoveJunk(Itunes_Songs_Caps[count]) == lineWithoutJunk || lineFromItunesFileSwappedAroundDelimiter[count] == lineWithoutJunk)
            //        {
            //            foundMatch = 1;
            //            if (line.Contains("("))
            //            {
            //                Console.WriteLine(line);
            //            }
            //        }
            //        count++;
            //    }
            //    if (foundMatch == 0)
            //    {
            //        linesToKeep.Add(line);
            //    }
            //}
            //file.Close();
            //string tempFile = Path.GetTempFileName();
            //File.WriteAllLines(tempFile, linesToKeep);
            //File.Delete(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //File.Move(tempFile, @AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");





            /// <summary>
            /// GETS RID OF STRINGS WITH DISTANCE OF 3 OR LESS IGNORING JUNK
            /// </summary>
            //string line;
            //string l;
            //int foundMatch;
            //int count;
            //string lineWithoutJunk;
            //string[] lineFromItunesFileSplit;
            //List<string> leftOfBar = new List<string>();
            //List<string> rightOfBar = new List<string>();
            //List<string> lineFromItunesFileWithoutJunk = new List<string>();
            //List<string> lineFromItunesFileSwappedAroundDelimiter = new List<string>();
            //List<string> linesToKeep = new List<string>();
            //List<string> Itunes_Songs_Caps = new List<string>();
            //StreamReader file2 = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Itunes_Songs_Caps.txt");
            //StreamReader file = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //while ((l = file2.ReadLine()) != null)
            //{
            //    Itunes_Songs_Caps.Add(l);
            //}
            //file2.Close();
            //for (int i = 0; i < Itunes_Songs_Caps.Count; i++)
            //{
            //    lineFromItunesFileWithoutJunk.Add(RemoveJunk(Itunes_Songs_Caps[i]));
            //    lineFromItunesFileSplit = RemoveJunk(Itunes_Songs_Caps[i]).Split('|');
            //    leftOfBar.Add(lineFromItunesFileSplit[0]);
            //    rightOfBar.Add(lineFromItunesFileSplit[1]);
            //    lineFromItunesFileSwappedAroundDelimiter.Add(lineFromItunesFileSplit[1] + "|" + lineFromItunesFileSplit[0]);
            //}
            //Console.WriteLine("\nSongs Removed From Levenshtein Distance greater than 3 and\nhave less than 7 non-special character on left or right side of bar:\n");
            //while ((line = file.ReadLine()) != null)
            //{
            //    foundMatch = 0;
            //    count = 0;
            //    lineWithoutJunk = RemoveJunk(line);
            //    while (count < Itunes_Songs_Caps.Count && foundMatch == 0)
            //    {
            //        if (LevenshteinDistance.Compute(lineFromItunesFileWithoutJunk[count], lineWithoutJunk) <= 3 || LevenshteinDistance.Compute(lineFromItunesFileSwappedAroundDelimiter[count], lineWithoutJunk) <= 3)
            //        {
            //            foundMatch = 1;
            //            if (leftOfBar[count].Length < 7 || rightOfBar[count].Length < 7)
            //            {
            //                Console.WriteLine(line);
            //            }
            //        }
            //        count++;
            //    }
            //    if (foundMatch == 0)
            //    {
            //        linesToKeep.Add(line);
            //    }
            //}
            //file.Close();
            //string tempFile = Path.GetTempFileName();
            //File.WriteAllLines(tempFile, linesToKeep);
            //File.Delete(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //File.Move(tempFile, @AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");





            /// <summary>
            /// CODE BELOW IN MAIN IS TO ALLOW USER TO CHOOSE WHAT TO DO WITH REMAINDING SONGS
            /// </summary>
            List<string> linesToDownload = new List<string>();
            List<string> linesToManuallyCheck = new List<string>();
            List<string> linesToKeep = new List<string>();

            string lineFromInitializeLinesToKeep;
            StreamReader initializeLinesToKeep = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            while ((lineFromInitializeLinesToKeep = initializeLinesToKeep.ReadLine()) != null)//CHANGE TO NULL TO RUN THROUGH WHOLE THING
            {
                linesToKeep.Add(lineFromInitializeLinesToKeep);
            }
            initializeLinesToKeep.Close();

            char keepMoveDeleteSong = 'a';
            string lineFromCheckFile;
            string lineFromItunesFile;
            string[] lineFromItunesFileSplit;
            string lineFromItunesFileSwappedAroundDelimiter;
            StreamReader songsToCheckFile = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            while ((lineFromCheckFile = songsToCheckFile.ReadLine()) != null)
            {

                List<Data> LevenshteinDistanceValues = new List<Data>();
                StreamReader itunesSongsFile = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Itunes_Songs_Caps.txt");
                while ((lineFromItunesFile = itunesSongsFile.ReadLine()) != null)
                {
                    LevenshteinDistanceValues.Add(new Data(LevenshteinDistance.Compute(RemoveJunk(lineFromItunesFile), RemoveJunk(lineFromCheckFile)), lineFromItunesFile));
                    //Swap around | and check distance again
                    lineFromItunesFileSplit = RemoveJunk(lineFromItunesFile).Split('|');
                    lineFromItunesFileSwappedAroundDelimiter = lineFromItunesFileSplit[1] + "|" + lineFromItunesFileSplit[0];
                    LevenshteinDistanceValues.Add(new Data(LevenshteinDistance.Compute(lineFromItunesFileSwappedAroundDelimiter, RemoveJunk(lineFromCheckFile)), lineFromItunesFile));
                }
                itunesSongsFile.Close();

                Console.WriteLine("\n\t" + lineFromCheckFile + "\n");
                LevenshteinDistanceValues.Sort((i1, i2) => i1.IntegerData.CompareTo(i2.IntegerData));
                for (int index = 0; index < 40; index++)
                {
                    Console.WriteLine(LevenshteinDistanceValues[index].IntegerData + ":\t" + LevenshteinDistanceValues[index].StringData);
                }

                Console.WriteLine("\na = already have\nw = we need to manually check this song\nd = download list");
                keepMoveDeleteSong = Console.ReadKey().KeyChar;
                switch (keepMoveDeleteSong)
                {
                    case 'a':
                    case 'A':
                        linesToKeep.Remove(lineFromCheckFile);
                        File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Left_To_Check.txt", linesToKeep);
                        File.AppendAllText(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Already_Have.txt", "\n" + lineFromCheckFile);
                        break;
                    case 'w':
                    case 'W':
                        linesToKeep.Remove(lineFromCheckFile);
                        File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Left_To_Check.txt", linesToKeep);
                        File.AppendAllText(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Manually_Check.txt", "\n" + lineFromCheckFile);
                        break;
                    case 'd':
                    case 'D':
                        linesToKeep.Remove(lineFromCheckFile);
                        File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Left_To_Check.txt", linesToKeep);
                        File.AppendAllText(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Download.txt", "\n" + lineFromCheckFile);
                        break;
                    // Does nothing if you accidently hit something else
                    default:
                        break;
                }
                Console.Clear();
            }
            songsToCheckFile.Close();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();





        }

        public struct Data
        {
            public Data(int intValue, string strValue)
            {
                IntegerData = intValue;
                StringData = strValue;
            }
            public int IntegerData { get; set; }
            public string StringData { get; set; }
        }

        public static string RemoveJunk(string str)
        {
            return RemoveSpecialCharacters(str.GetUntilOrEmpty().GetUntilOrEmpty().GetUntilOrEmpty());
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9|]+", "", RegexOptions.Compiled);
        }
    }

    static class LevenshteinDistance
    {
        /// <summary>
        /// Compute the distance between two strings.
        /// </summary>
        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
                return m;
            if (m == 0)
                return n;
            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++) { }
            for (int j = 0; j <= m; d[0, j] = j++) { }
            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }

    static class Helper
    {
        public static string GetUntilOrEmpty(this string text, string stopAt = "(", string startAgainAt = ")")
        {
            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);
                int secondCharLocation = text.IndexOf(startAgainAt, StringComparison.Ordinal);

                if (charLocation >= 0)
                {
                    return text.Substring(0, charLocation) + text.Substring(secondCharLocation + 1, text.Length - (secondCharLocation + 1));
                }
            }
            return text;
        }
    }
}
