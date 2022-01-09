using System;

namespace Pelican
{
    class Program
    {
        //Console colours are listed here so they can be changed easily in a config file
        static ConsoleColor DefaultColour = ConsoleColor.White;
        static ConsoleColor ErrorColour = ConsoleColor.Red;
        static ConsoleColor WarnColour = ConsoleColor.Yellow;
        static ConsoleColor SuccessColour = ConsoleColor.Green;
        static ConsoleColor NoteColour = ConsoleColor.Blue;
        static ConsoleColor LineColour = ConsoleColor.Gray;



        //File path of the source file
        static string FilePath = "";


        static string[] Source;
        


        //Main method
        static void Main(string[] args)
        {
            //Print compiler version
            PrintLine("--- Pelican U+ Compiler for Windows | Version 0.1 ---", false, 4);



            //Main try/catch loop which the entire compiler runs in to avoid crashing
            try
            {
                //Select file
                PrintLine("Enter the filepath to the upi file you wish to compile:", true, 2);
                FilePath = Console.ReadLine();



                //Check if the file exists
                PrintLine("Existance of source file is being checked...", true, 4);
                if (!System.IO.File.Exists(FilePath)) {
                    FatalMessage = "The file \"" + FilePath + "\" does not exist!";
                    FinishFail();
                    return;
                }
                PrintLine("Source file exists", true, 3);



                PrintLine("Source file format is being checked...", true, 4);
                if (!FilePath.EndsWith(".upi")) {
                    FatalMessage = "The source file is not the correct format!";
                    FinishFail();
                    return;
                }
                PrintLine("Source file is the correct format", true, 3);



                PrintLine("Source file version is being checked...", true, 4);
                Source = System.IO.File.ReadAllLines(FilePath);
                /*if (1 == 12) {
                    PrintLine(Source.ToString(), false, 0);
                    FatalMessage = "The source file is not the correct version!";
                    FinishFail();
                    return;
                }*/
                PrintLine("Source file is the correct version", true, 3);



                //If the compiler has not failed up until here, then it has succeeded and the corresponding method is executed to acknowledge this
                FinishSuccess();
            }
            catch (Exception ex)
            {
                //If the compiler fails in such a way that is not checked for by the compiler itself, then this will halt execution and store the reason for the error in the "FatalMessage" string declared further below
                FatalMessage = ex.ToString();
                FinishFail();
                return;
            }
        }



        //This will execute if the compiler completes compiling the source file and succeeds
        static void FinishSuccess()
        {
            PrintLine("Build successful!", false, 3);
            PrintLine("The build succeeded and the compiler will now exit. Any key to continue...", false, 4);
            Console.ReadKey();
        }



        //This is the variable where the try/catch error message is stored
        static string FatalMessage = "";

        //This will execute if the compiler fails in any way and will print the reason, regardless if it is an internal error, or one the compiler detected in the main void
        static void FinishFail()
        {
            PrintLine("FATAL ERROR: " + FatalMessage, false, 1);
            PrintLine("The build failed and the compiler will now exit. Any key to continue...", false, 4);
            Console.ReadKey();
        }



        //This is a replacement of the Console.Write() method, with arguments arranged in such a way as to maximise efficiency when writing the compiler
        static void Print(string s, bool i = true, uint c = 0)
        {
            //If the boolean "i" (indicate) is true, the line counter will be excecuted, which will print the line number for easier error diagnosis
            if (i) {
                LineCounter();
            }

            //This will check the "c" (colour) variable, which indicates the colour to be used for the line as an integer, then it will set the console foreground colour to the appropriate colour
            switch (c)
            {
                case 0:
                    Console.ForegroundColor = DefaultColour;
                break;

                case 1:
                    Console.ForegroundColor = ErrorColour;
                break;

                case 2:
                    Console.ForegroundColor = WarnColour;
                break;

                case 3:
                    Console.ForegroundColor = SuccessColour;
                break;

                case 4:
                    Console.ForegroundColor = NoteColour;
                break;

                case 5:
                    Console.ForegroundColor = LineColour;
                break;
            }

            Console.Write(s);

            Console.ForegroundColor = DefaultColour;
        }



        //This is a replacement of the Console.WriteLine() method, with arguments arranged in such a way as to maximise efficiency when writing the compiler
        static void PrintLine(string s, bool i = true, uint c = 0)
        {
            if (i) {
                LineCounter();
            }

            switch (c)
            {
                case 0:
                    Console.ForegroundColor = DefaultColour;
                break;

                case 1:
                    Console.ForegroundColor = ErrorColour;
                break;

                case 2:
                    Console.ForegroundColor = WarnColour;
                break;

                case 3:
                    Console.ForegroundColor = SuccessColour;
                break;

                case 4:
                    Console.ForegroundColor = NoteColour;
                break;

                case 5:
                    Console.ForegroundColor = LineColour;
                break;
            }

            Console.WriteLine(s);

            Console.ForegroundColor = DefaultColour;
        }



        static uint LineCount = 0;

        static void LineCounter()
        {
            LineCount++;
            Console.ForegroundColor = LineColour;
            Console.Write(LineCount.ToString() + "> ");
            Console.ForegroundColor = DefaultColour;
        }
    }
}
