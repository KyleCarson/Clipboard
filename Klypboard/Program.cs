namespace Klypboard
{
    using System;
    using System.Windows.Forms;

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var displayText = string.Empty;

            while (true)
            {
                var clipboardText = string.Empty;

                try
                {
                    clipboardText = Clipboard.GetText(TextDataFormat.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                
                if (!string.IsNullOrEmpty(clipboardText))
                {
                    if (displayText != clipboardText)
                    {
                        displayText = clipboardText;

                        Console.WriteLine($"\n\n{DateTime.Now}\n\n{displayText}");
                    }
                }
            }
        }
    }
}
