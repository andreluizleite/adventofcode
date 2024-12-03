using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventCode2024.Day3
{
    public class PartTwo
    {
        public int CalculateMultiplications()
        {
            int total = 0;

            // Read corrupted memory input
            string corruptedMemory = ReadInputFromFile();

            // Get only valid segments
            string[] validSegments = SplitMemory(corruptedMemory);

            // Regex pattern to find mul instructions
            Regex mulPattern = new Regex(@"mul\((\d{1,3}),(\d{1,3})\)");

            // Process each valid segment
            foreach (var segment in validSegments)
            {
                var matches = mulPattern.Matches(segment);

                foreach (Match match in matches)
                {
                    int num1 = int.Parse(match.Groups[1].Value);
                    int num2 = int.Parse(match.Groups[2].Value);
                    total += num1 * num2;
                }
            }

            Console.WriteLine($"Day 3, Two: {total}");
            return total;
        }

        /// <summary>
        /// Splits the memory and validates segments based on do() and don't() instructions.
        /// </summary>
        private string[] SplitMemory(string corruptedMemory)
        {
            // Regex pattern to match "do()" or "don't()"
            Regex controlPattern = new Regex(@"(do\(\)|don't\(\))");


            var result = new List<string>();
            bool isEnabled = true; // Default state is enabled
            string currentSegment = string.Empty;

            // Split the memory into parts based on control instructions
            string[] tokens = controlPattern.Split(corruptedMemory);

            foreach (var token in tokens)
            {
                if (string.IsNullOrWhiteSpace(token)) continue;

                // Check for control instructions
                if (token.Contains("do()"))
                {
                    isEnabled = true; // Reactivate processing
                    if (!string.IsNullOrWhiteSpace(currentSegment))
                    {
                        result.Add(currentSegment); // Save the previous segment if it exists
                        currentSegment = string.Empty; // Start a new segment
                    }
                }
                else if (token.Contains("don't()"))
                {
                    isEnabled = false; // Deactivate processing
                    if (!string.IsNullOrWhiteSpace(currentSegment))
                    {
                        result.Add(currentSegment); // Save the current segment
                        currentSegment = string.Empty; // Reset for future processing
                    }
                }
                else if (isEnabled)
                {
                    currentSegment += token; // Append token to current segment if enabled
                }
            }

            // Add the final segment if still valid
            if (!string.IsNullOrWhiteSpace(currentSegment))
            {
                result.Add(currentSegment);
            }

            return result.ToArray();
        }

        private string ReadInputFromFile()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                var filePath = "/../../../day3/input.txt";
                // Read all content from the text file
                string content = File.ReadAllText(path + filePath);
                return content;
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