
namespace AdventCode2024.Day4
{
    class PartTwo
    {
        public void CeresSearch()
        {
            string[][] content = ReadInputFromFile();
            int counter = 0;

            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < content[i].Length; j++)
                {
                    // Check for "M . S", ". A .", "M . S" pattern from the current "M"
                    if (CheckXMasPattern(content, i, j))
                    {
                        counter++;
                    }
                }
            }

            // Output the total number of X-MAS found
            Console.WriteLine($"Total number of X-MAS found: {counter}");
        }
        private bool CheckXMasPattern(string[][] content, int i, int j)
        {
            if (i - 1 < 0 || j - 1 < 0 || i + 1 >= content.Length || j + 1 >= content[i].Length)
            {
                return false; 
            }

            string topLeft = content[i - 1][j - 1];
            string topRight = content[i - 1][j + 1];
            string middleCenter = content[i][j]; // Should be 'A'
            string bottomLeft = content[i + 1][j - 1];
            string bottomRight = content[i + 1][j + 1];

            // Validate the pattern
            if (middleCenter == "A" && 
                (topLeft == "M" || topLeft == "S") && 
                (topRight == "M" || topRight == "S") && 
                (bottomLeft == "M" || bottomLeft == "S") && 
                (bottomRight == "M" || bottomRight == "S") && 
                topLeft != bottomRight && topRight != bottomLeft) 
            {
                return true;
            }

            return false; 
        }


        private string[][] ReadInputFromFile()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                var filePath = "/../../../day4/input.txt";
                // Read all content from the text file
                string[] content = File.ReadLines(path + filePath).ToArray();
                string[][] content2 = content.Select(x => x.Select(c => c.ToString()).ToArray()).ToArray();

                return content2;
            }
            catch (Exception ex)
            {
                // Handle file reading errors
                Console.WriteLine("Error reading the file: " + ex.Message);
                return null;
            }
        }
    }
}
