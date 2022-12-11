/****************************************************************************
**                    
**                          SAKARYA ÜNİVERSİTESİ
**              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                     NESNEYE DAYALI PROGRAMLAMA DERSİ
**                          2021-2022 BAHAR DÖNEMİ
**
**
**                         ÖDEV NUMARASI: 1
**                         ÖĞRENCİ ADI: ERAY ŞEN
**                         ÖĞRENCİ NUMARASI: G211210019
**                         DERS GRUBU: 2B
******************************************************************************/

using System;

namespace NesneyeDayaliProgramlamaOdev1
{
    public class character
    {
        public static int UpperCase(string password, int score)
        {
            int counter_uppercase = 0; 
            bool result_uppercase;
            score = 0;

            for (int i = 0; i < password.Length; i++) //The loop will return up to the length of the variable.
            {
                result_uppercase; = Char.IsUpper(password[i]); // If there is a uppercase in the i. index of the password, bool will be true.

                if (result_uppercase; == true)
                {
                    counter_uppercase++; // If the bool is true, the counter of the uppercase will be increase.
                }
            }

            if (counter_uppercase <= 2)
            {
                score += counter_uppercase * 10; //Until the number of uppercase in the password is 3, 10 points will be given for each uppercase.
            }
            else
            {
                score += 20; //Even if there are more than 2 uppercase, the score will increase by 20 points for each uppercase.
            }

            //This scoring system is also valid for lowercase and numbers.

            Console.WriteLine("Number of the uppercase: " + counter_uppercase);
            return score; //The method returns the value of the 'score' for uppercases.

        }
        public static int LowerCase(string password, int score)
        {
            int counter_lowercase = 0;
            bool result_lowercase;
            score = 0;

            for (int i = 0; i < password.Length; i++)
            {
                result_lowercase = Char.IsLower(password[i]); 
                if (result_lowercase == true)
                {
                    counter_lowercase++;
                }
            }

            if (counter_lowercase <= 2)
            {
                score += counter_lowercase * 10;
            }
            else
            {
                score += 20;
            }

            Console.WriteLine("Number of the lowercase: " + counter_lowercase);
            return score; //The method returns the value of the 'score' for lowercases.
        }

        public static int Number(string password, int score)
        {
            score = 0;
            int counter_number = 0;
            bool result_number;

            for (int i = 0; i < password.Length; i++)
            {
                result_number = Char.IsDigit(password[i]); 
                if (result_number == true)
                {
                    counter_number++;
                }

            }

            if (counter_number <= 2)
            {
                score += counter_number * 10;
            }
            else
            {
                score += 20;
            }

            Console.WriteLine("Number of the numbers: " + counter_number);
            return score; //The method returns the value of the 'score' for numbers.
        }

        public static int Symbol(string password, int score)
        {
            int counter_symbol = 0;
            bool result_symbol;
            score = 0;

            for (int i = 0; i < password.Length; i++)
            {
                result_symbol = Char.IsLetterOrDigit(password[i]);//If the i. index of the password is number or letter, the bool will be true

                if (result_symbol == false) // If bool is false, the i. index is a symbol.
                {
                    counter_symbol++;

                }

            }

            score += counter_symbol * 10; //Score increases for each symbol.
            Console.WriteLine("Number of the symbols: " + counter_symbol);
            return score; //The method returns the value of the 'score' for symbols.
        }

    }

    //-------------------------------------------------------------------------------------------------------------------------------------

    public class Program : character
    {
       
        static public void Main(string[] args)
        {
            int total = 0; int score = 0; int error = 0; 
            string password;
            int counter_uppercase, counter_lowercase, counter_number, counter_symbol;
            bool result_uppercase;, result_lowercase, result_number;

            Console.BackgroundColor = ConsoleColor.DarkRed; 
            Console.Write("Please enter the password you want to create: ");
            Console.BackgroundColor = ConsoleColor.Black;
            password = Console.ReadLine();

            do
            {
                total = 0;
                do
                {
                    error = 0; //The error value is reset at each loop iteration
                    if (password.Length < 9) //If the number of the characters is less than 9, the password will not be accepted
                    {
                        error = 1;
                        Console.WriteLine("Your password must be at least 9 characters!");
                    }

                    for (int i = 0; i < password.Length; i++)
                    { 

                        if (password[i] == ' ') //If the password contains a space character. It will not be accepted.
                        {
                            error = 1;
                            Console.WriteLine("Your password must not contain any space character!");
                        }

                    }

                    if (error == 1) //value of the error is 1. So, the password is not accepted. A valid password must be entered. 
                    {
                        Console.Write("Place enter a valid password!: ");
                        password = Console.ReadLine();
                    }

                } while (error == 1); //If there are invalid conditions in the password, the error value becomes 1 and the do-while loop is repeated.



                if (password.Length >= 9)
                {

                    if (password.Length == 9) score = 10; //If the password has 9 characters, the score will start from 10. It's a job rule for the scoring system.

                    do
                    {
                        error = 0; counter_uppercase = 0; counter_lowercase = 0; counter_number = 0; counter_symbol = 0;

                        for (int i = 0; i < password.Length; i++)
                        {
                            result_lowercase = Char.IsLower(password[i]);
                            result_uppercase; = Char.IsUpper(password[i]);
                            result_number = Char.IsDigit(password[i]);

                            //the password is checked character by character to find the number of the uppercases, lowercases and numbers to learn if there is or not. Because the password must contain at least 1 uppercase, lowercase, number and symbol. It is a job rule for the password security system.

                            if (result_uppercase == true)
                            {
                                counter_uppercase++; 
                            }

                            else if (result_lowercase == true)
                            {
                                lowercase++; 
                            }

                            else if (result_number == true)
                            {
                                counter_number++; 
                            }

                            else
                            {
                                counter_symbol++; //Unless the character is uppercase, lowercase or number. It is a symbol.
                            }
                        }

                        ////Because the password must contain at least one uppercase, lowercase, number and symbol, these conditions are checked within the if blocks.

                        if (counter_uppercase == 0)
                        {
                            error = 1;
                            Console.WriteLine("There must be at least one uppercase character in the password!");
                        }

                        if (counter_lowercase == 0)
                        {
                            error = 1;
                            Console.WriteLine("There must be at least one lowercase character in the password!!");
                        }

                        if (counter_number == 0)
                        {
                            error = 1;
                            Console.WriteLine("There must be at least one number character in the password!!");
                        }

                        if (counter_symbol == 0)
                        {
                            error = 1;
                            Console.WriteLine("There must be at least one symbol character in the password!!");
                        }

                        if (error == 1)
                        {
                            Console.Write("Please enter a valid password!: ");
                            password = Console.ReadLine();
                        }

                    } while (error == 1); //If there are invalid conditions in the password, the error value becomes 1 and the do-while loop is repeated.

                    Console.WriteLine("password ={0}", password); //The valid password is written on the console.

                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    total += character.UpperCase(password, score); //By calling the UpperCase method, the score value of the uppercase is added to the total variable, which is 0 at first.

                    //The LowerCase, Number and Symbol methods are called for same process.
                    total += character.LowerCase(password, score); 
                    total += character.Number(password, score); 
                    total += character.Symbol(password, score);  

                    if(total>100) //If the total score is over 100 points, it will be 100. Because the maximum score is 100 in the scoring system.
                        total = 100;
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("TOTAL: " + total); //Total value is written on the console.
                    Console.WriteLine();

                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    if (total < 70) // If the password score less than 70, it means the password level is weak. So, it is not accepted.
                    {
                        error = 1; //And error will be 1.
                        Console.WriteLine("Your password level is 'weak', UNACCEPTABLE!");
                    }

                    if (error == 1) 
                    {
                        Console.Write("Please enter a valid password: ");
                        password = Console.ReadLine();
                    }

                }

            } while (error == 1); //If there are invalid conditions in the password, the error value becomes 1 and the do-while loop is repeated.


            if (total >= 70 && total < 90)
            {              
                Console.WriteLine("Your password level is 'medium', ACCEPTABLE!");
            }
            else if(total>=90 && total<=100)
            {            
                Console.WriteLine("Your password level is 'strong', ACCEPTABLE!");
            }

            //If the total value is less than 70, the password level is weak. If the total value between 70-90, it is medium and acceptable.
            // In other cases, the total value is 90 or higher, it is strong and absolutely acceptable. 

        }


    }

}


