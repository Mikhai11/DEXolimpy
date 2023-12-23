namespace DexOlympy
{
    internal class Zad1
    {
        static void Main()
        {

            int[] nums = Array.Empty<int>();
            try
            {
                string[] lines = File.ReadAllLines(@"D:\Olympy\zad1in.txt");
                string[] elements = lines[0].Split(',');
                nums = new int[elements.Length];

                for (int i = 0; i < elements.Length; i++)
                {
                    nums[i] = int.Parse(elements[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            int k = 0;
            k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    k++;
                }
            }

            try
            {
                File.WriteAllText(@"D:\Olympy\zad1out.txt", k.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }



        }

    }
}
