namespace AdventCode2024.Day5
{
    class PartTwo
    {
        public void PrintQueue()
        {
            var map = ReadInputFromFile1();
            var pages = ReadInputFromFile2();
            int sum = 0;
            int reorderedSum = 0;

            foreach (var page in pages)
            {
                bool lineValid = true;

                for (int i = 0; i < page.Length; i++)
                {
                    bool pageValid = false;

                    // Valid rule: Compare with next numbers
                    for (int j = i + 1; j <= page.Length; j++)
                    {
                        if (j == page.Length)
                        {
                            pageValid = true;
                            break;
                        }

                        string keyRule = $"{page[i]}|{page[j]}";

                        if (map.TryGetValue(keyRule, out var rule) && rule == keyRule)
                        {
                            pageValid = true;
                            break;
                        }
                    }

                    // Invalid rule: Compare with previous numbers
                    for (int k = i - 1; k >= 0; k--)
                    {
                        string keyRuleViolated = $"{page[i]}|{page[k]}";

                        if (map.TryGetValue(keyRuleViolated, out var ruleViolated) && ruleViolated == keyRuleViolated)
                        {
                            pageValid = false;
                            break; // Stop further checks if invalid rule is found
                        }
                    }

                    if (!pageValid)
                    {
                        lineValid = false; // If any page is invalid, the whole line is invalid
                        break; // Stop further checks for this line
                    }
                }

                if (lineValid)
                {
                    int mid = page.Length / 2;
                    sum += int.Parse(page[mid]);
                }
                else
                {
                    // Reorder the page according to rules
                    var reordered = ReorderPage(page, map);
                    int mid = reordered.Length / 2;
                    reorderedSum += int.Parse(reordered[mid]);
                }
            }

            Console.WriteLine($"The Middle page numbers sum for valid lines is {sum}");
            Console.WriteLine($"The Middle page numbers sum for reordered lines is {reorderedSum}");
        }

        private string[] ReorderPage(string[] page, Dictionary<string, string> map)
        {
            var orderedPage = new List<string>();

            foreach (var num in page)
            {
                bool inserted = false;

                for (int i = 0; i <= orderedPage.Count; i++)
                {
                    if (i < orderedPage.Count)
                    {
                        string forwardRule = $"{num}|{orderedPage[i]}";
                        string backwardRule = $"{orderedPage[i]}|{num}";

                        if (map.TryGetValue(forwardRule, out _) || !map.TryGetValue(backwardRule, out _))
                        {
                            orderedPage.Insert(i, num);
                            inserted = true;
                            break;
                        }
                    }
                }

                if (!inserted)
                {
                    orderedPage.Add(num);
                }
            }

            return orderedPage.ToArray();
        }


        private Dictionary<string, string> ReadInputFromFile1()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                var filePath = "/../../../day5/input1.txt";
                // Read all content from the text file
                string[] content = File.ReadLines(path + filePath).ToArray();
                string[][] content2 = content.Select(c => c.ToString().Split('|')).ToArray();

                return ConvertToDictionary(content2);
            }
            catch (Exception ex)
            {
                // Handle file reading errors
                Console.WriteLine("Error reading the file: " + ex.Message);
                return null;
            }
        }
        private string[][] ReadInputFromFile2()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                var filePath = "/../../../day5/input2.txt";
                // Read all content from the text file
                string[] content = File.ReadLines(path + filePath).ToArray();
                string[][] content2 = content.Select(c => c.ToString().Split(',')).ToArray();

                return content2;
            }
            catch (Exception ex)
            {
                // Handle file reading errors
                Console.WriteLine("Error reading the file: " + ex.Message);
                return null;
            }
        }
        private Dictionary<string, string> ConvertToDictionary(string[][] content)
        {
            var map = new Dictionary<string, string>();

            // Iterate over rows and columns to fill the dictionary
            for (int i = 0; i < content.Length; i++)
            {
                // Create the key as "row|column" and the value as the character at that position
                string key = $"{content[i][0].ToString()}|{content[i][1]}";
                string value = key;

                // Add to dictionary
                map[key] = value;
            }

            return map;
        }
    }
}
