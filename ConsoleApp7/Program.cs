using System.Runtime.InteropServices;

namespace ConsoleApp7
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr intPtr, string text, string caption, uint type);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int FindWindow(IntPtr intPtr, string Caption);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SendMessage(IntPtr intPtr, int Msg, int wParam, string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool MessageBeep(uint uType);

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);


        const int WM_SETTEXT = 0x000C;
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Мене звати Діма", "Info", 1);
            MessageBox(IntPtr.Zero, "Мені 17 років", "Info", 1);
            MessageBox(IntPtr.Zero, "Я вчу програмування", "Info", 1);

            FindWindow(IntPtr.Zero, "Notepad");
            SendMessage(IntPtr.Zero, WM_SETTEXT, 0, "Text_Default");

            Console.WriteLine("Відтворюємо звукові сигнали...");

            Beep(1000, 500); // 1000 Гц, 500 мс тривалість

            Thread.Sleep(1000);

            MessageBeep(0);

            Thread.Sleep(1000);

            Console.WriteLine("Готово.");
        }
    }
}