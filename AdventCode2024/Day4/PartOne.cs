using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode2024.Day4
{
    class PartOne
    {
        public void CeresSearch()
        {
            string[][] content = ReadInputFromFile();
            int counter = 0;

            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < content[i].Length; j++)
                {
                    // left
                    if (j >= 3)
                    {
                        if (content[i][j] == "X" && content[i][j - 1] == "M" && content[i][j - 2] == "A" && content[i][j - 3] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going left");
                            counter++;
                        }
                    }
                    // right
                    if (j + 3 < content[i].Length)
                    {
                        if (content[i][j] == "X" && content[i][j + 1] == "M" && content[i][j + 2] == "A" && content[i][j + 3] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going right");
                            counter++;
                        }
                    }
                    // up
                    if (i >= 3)
                    {
                        if (content[i][j] == "X" && content[i - 1][j] == "M" && content[i - 2][j] == "A" && content[i - 3][j] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going up");
                            counter++;
                        }
                    }
                    // down
                    if (i + 3 < content.Length)
                    {
                        if (content[i][j] == "X" && content[i + 1][j] == "M" && content[i + 2][j] == "A" && content[i + 3][j] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going down");
                            counter++;
                        }
                    }
                    // left-up
                    if (j >= 3 && i >= 3)
                    {
                        if (content[i][j] == "X" && content[i - 1][j - 1] == "M" && content[i - 2][j - 2] == "A" && content[i - 3][j - 3] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going left-up");
                            counter++;
                        }
                    }
                    // right-up
                    if (j + 3 < content[i].Length && i >= 3)
                    {
                        if (content[i][j] == "X" && content[i - 1][j + 1] == "M" && content[i - 2][j + 2] == "A" && content[i - 3][j + 3] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going right-up");
                            counter++;
                        }
                    }
                    // left-down
                    if (j >= 3 && i + 3 < content.Length)
                    {
                        if (content[i][j] == "X" && content[i + 1][j - 1] == "M" && content[i + 2][j - 2] == "A" && content[i + 3][j - 3] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going left-down");
                            counter++;
                        }
                    }
                    // right-down
                    if (j + 3 < content[i].Length && i + 3 < content.Length)
                    {
                        if (content[i][j] == "X" && content[i + 1][j + 1] == "M" && content[i + 2][j + 2] == "A" && content[i + 3][j + 3] == "S")
                        {
                            Console.WriteLine($"Found 'XMAS' at ({i}, {j}) going right-down");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine($"Number of XMAS: {counter}");
        }


        public void CeresSearchGptVersion()
        {
            string[][] content = ReadInputFromFile();

            int counter = 0;

            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < content[i].Length; j++)
                {
                    // Check all 8 directions
                    if (CheckDirection(content, i, j, 0, 1)) counter++;  // Right
                    if (CheckDirection(content, i, j, 0, -1)) counter++; // Left
                    if (CheckDirection(content, i, j, 1, 0)) counter++;  // Down
                    if (CheckDirection(content, i, j, -1, 0)) counter++; // Up
                    if (CheckDirection(content, i, j, 1, 1)) counter++;  // Right-Down
                    if (CheckDirection(content, i, j, -1, -1)) counter++;// Left-Up
                    if (CheckDirection(content, i, j, 1, -1)) counter++; // Left-Down
                    if (CheckDirection(content, i, j, -1, 1)) counter++; // Right-Up
                }
            }
            Console.WriteLine($"Number of XMAS: {counter}");
        }

        private bool CheckDirection(string[][] grid, int startX, int startY, int dx, int dy)
        {
            // Ensure we do not go out of bounds
            int length = grid.Length;
            int width = grid[0].Length;
            int x = startX, y = startY;

            string target = "XMAS";

            for (int i = 0; i < target.Length; i++)
            {
                if (x < 0 || x >= length || y < 0 || y >= width || grid[x][y] != target[i].ToString())
                    return false;

                x += dx;
                y += dy;
            }

            return true; // Found "XMAS" in the given direction
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
