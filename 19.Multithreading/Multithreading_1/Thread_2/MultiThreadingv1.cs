
namespace Thread_2;

public class MultiThreadingv1
{
    // Always use absolute path
    private readonly string filePath = Path.Combine(AppContext.BaseDirectory, "totalValues.txt");

    public void ExecuteCode()
    {
        for (int index = 0; index < 5000; index++)
        {
            int totalValues;

            // READ
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                totalValues = string.IsNullOrWhiteSpace(fileContent) ? 0 : int.Parse(fileContent);
            }
            else
            {
                totalValues = 0;


                // MODIFY
                totalValues++;

                Console.WriteLine("File will be Created");

                // WRITE (overwrite safely)
                File.WriteAllText(filePath, totalValues.ToString());
            }
        }
    }
}