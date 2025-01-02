namespace SuperOutput
{
    public class Init
    {
        public void ColorOutput(string text, ConsoleColor userColor, bool shouldWriteAtNewLine = true, bool centerTextOnlyConsoleApp = false, bool testing = false)
        {
            Console.ForegroundColor = userColor;

            if (centerTextOnlyConsoleApp)
            {
                text = String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
            }

            if (shouldWriteAtNewLine)
            {   
                if (!testing)
                {
                    Console.WriteLine(text);
                }
            }
            else
            {
                if (!testing)
                {
                    Console.Write(text);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public void AnimatedOutput(string text, ConsoleColor userColor = ConsoleColor.Gray, int delay = 100, bool shouldWriteAtNewLine = false, bool testing = false) 
        {

            for (int i = 0; i < text.Length; i++)
            {
                ColorOutput(text[i].ToString(), userColor, false, false, testing);
                Thread.Sleep(10);
            }

            if (shouldWriteAtNewLine)
            {
                Console.WriteLine();
            }
        }

        public void StatusOutput(string text, ConsoleColor userColor = ConsoleColor.Gray, bool shouldWriteAtNewLine = false, bool centerTextOnlyConsoleApp = false, bool testing = false)
        {
            ColorOutput(" [ ", ConsoleColor.Gray, false, false, testing);
            ColorOutput(text, userColor, false, false, testing);
            ColorOutput(" ] ", ConsoleColor.Gray, shouldWriteAtNewLine, false, testing);
        }

        public void OutputTime(bool withSeconds, ConsoleColor userColor = ConsoleColor.DarkGray, bool shouldWriteAtNewLine = false, bool centerTextOnlyConsoleApp = false, bool testing = false)
        {
            string time = GetTime(withSeconds);

            if (testing)
            {
                ColorOutput(time, userColor, shouldWriteAtNewLine, centerTextOnlyConsoleApp, true);
            }
            else
            {
                ColorOutput(time, userColor, shouldWriteAtNewLine, centerTextOnlyConsoleApp);
            }
        }

        private string GetTime(bool withSeconds)
        {
            if (withSeconds)
            {
                return DateTime.Now.ToString("HH:mm:ss");
            } else
            {
                return DateTime.Now.ToString("HH:MM");
            }
        }

        public bool IsWorking()
        {
            try
            {
                ColorOutput("Test", ConsoleColor.White, false, false, true);
                OutputTime(true, ConsoleColor.White, false, false, true);
                StatusOutput("Test", ConsoleColor.White, false, false, true);
                // string time = GetTime(true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsReady()
        {
            return IsWorking();
        }
    }
}
