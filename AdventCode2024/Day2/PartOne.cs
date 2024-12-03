﻿namespace AdventCode2024.Day2
{
    internal class PartOne
    {
        public int SafeReports()
        {
            int[][] reports = TransformData();
            int AllLevelsIncrisingBy1or2 = 0;
            int AllLevelsDecrising = 0;
            int counter = 0;

            for (int i = 0; i < reports.Length; i++)
            {
                for (int j = 0; j < reports[i].Length; j++)
                {

                    //Levels are Incrising  by 1 or 2
                    int incrisingUnsafe = reports[i][j] - reports[i][j + 1];
                    if (incrisingUnsafe == 1 || incrisingUnsafe == 2 || incrisingUnsafe == 3)
                    {
                        AllLevelsIncrisingBy1or2++;
                    }
                    else if (incrisingUnsafe == -1 || incrisingUnsafe == -2 || incrisingUnsafe == -3)
                    {
                        AllLevelsDecrising++;
                    }


                    if (j == reports[i].Length - 2)
                        break;
                }

                int len = reports[i].Length - 1;

                if (AllLevelsIncrisingBy1or2  == len || AllLevelsDecrising == len)
                    counter++;

                AllLevelsIncrisingBy1or2 = 0;
                AllLevelsDecrising = 0;

            }

            Console.WriteLine("Total Safe: " + counter);

            return counter;
        }

        private int[][] TransformData()
        {
            string data = "42 44 47 49 51 52 54 52\r\n24 27 30 31 32 35 36 36\r\n80 82 85 86 87 90 94\r\n4 5 7 10 13 14 20\r\n38 41 40 42 45 47 50 52\r\n43 46 48 49 52 49 52 49\r\n38 41 42 44 47 49 48 48\r\n60 62 61 63 67\r\n33 36 38 35 41\r\n31 32 32 35 37 38\r\n68 69 69 70 71 74 75 73\r\n29 32 34 35 35 37 38 38\r\n83 84 85 88 88 90 93 97\r\n23 24 25 28 28 34\r\n78 80 83 84 86 90 93 96\r\n43 46 47 51 52 51\r\n22 23 25 29 29\r\n78 81 84 87 90 94 95 99\r\n9 11 13 15 19 25\r\n7 9 15 17 19 21\r\n44 46 48 54 53\r\n83 85 90 91 91\r\n22 23 24 25 30 34\r\n61 63 68 70 71 76\r\n57 54 55 57 59 61\r\n13 10 12 13 14 12\r\n20 19 22 25 27 27\r\n79 76 79 81 83 87\r\n83 82 83 85 87 89 96\r\n59 57 54 57 59 62\r\n30 28 29 26 27 29 27\r\n84 83 81 83 85 87 87\r\n47 46 48 51 54 57 54 58\r\n12 9 6 9 12 13 15 20\r\n5 3 5 8 9 12 12 13\r\n84 83 83 86 83\r\n30 27 27 30 30\r\n27 26 28 29 29 30 34\r\n16 15 15 18 25\r\n74 71 72 75 78 82 84 87\r\n62 59 63 65 66 68 70 67\r\n22 19 20 24 24\r\n68 67 71 72 76\r\n36 35 36 38 41 43 47 53\r\n19 16 17 20 27 29\r\n68 67 72 74 71\r\n40 39 40 45 47 47\r\n38 37 39 46 48 49 51 55\r\n8 6 7 10 16 19 24\r\n44 44 47 48 50 51\r\n91 91 93 95 97 98 96\r\n92 92 93 94 94\r\n62 62 65 66 68 69 71 75\r\n9 9 12 13 14 15 16 23\r\n29 29 28 31 34 37 40\r\n39 39 38 39 38\r\n95 95 97 98 95 97 97\r\n37 37 34 35 39\r\n48 48 46 48 55\r\n49 49 51 53 56 56 59 60\r\n13 13 16 19 19 21 19\r\n94 94 97 98 98 99 99\r\n37 37 37 40 44\r\n64 64 64 66 68 70 76\r\n32 32 34 38 39\r\n6 6 10 13 15 16 19 17\r\n64 64 68 71 71\r\n29 29 32 36 37 38 40 44\r\n28 28 31 35 40\r\n33 33 40 43 45 46 49 51\r\n7 7 9 14 16 18 15\r\n47 47 50 51 58 59 60 60\r\n47 47 53 55 57 58 61 65\r\n46 46 47 49 55 56 63\r\n32 36 37 40 41 43 45 47\r\n21 25 27 29 27\r\n8 12 15 16 16\r\n5 9 12 15 17 19 23\r\n85 89 91 92 97\r\n44 48 45 46 49 51\r\n50 54 56 55 58 55\r\n23 27 26 29 30 30\r\n37 41 43 41 43 47\r\n86 90 92 90 91 98\r\n24 28 31 32 33 33 35\r\n7 11 12 12 11\r\n89 93 93 94 97 97\r\n48 52 55 56 59 59 63\r\n23 27 30 30 37\r\n53 57 60 64 67 69\r\n37 41 45 46 48 51 54 53\r\n67 71 75 76 79 79\r\n60 64 67 70 74 78\r\n73 77 78 81 84 86 90 95\r\n14 18 20 23 29 32 34 35\r\n61 65 66 68 74 75 72\r\n6 10 13 14 17 22 22\r\n82 86 91 92 94 98\r\n45 49 51 52 59 62 68\r\n72 77 79 81 82\r\n15 22 25 26 27 29 31 30\r\n21 26 28 29 31 33 33\r\n32 39 40 43 44 47 49 53\r\n54 60 61 63 64 71\r\n60 66 68 70 68 70 73 76\r\n36 41 42 44 46 43 46 43\r\n12 19 18 20 20\r\n55 61 63 65 66 63 64 68\r\n29 34 37 36 37 40 42 49\r\n50 55 57 57 58 59 61\r\n33 39 41 44 47 50 50 48\r\n59 66 68 68 68\r\n65 70 70 72 74 78\r\n26 33 35 36 36 39 42 47\r\n33 38 42 44 45 48 49\r\n44 51 55 58 60 59\r\n45 52 56 59 59\r\n22 28 30 32 36 40\r\n27 32 34 36 37 41 42 49\r\n70 77 80 81 82 87 90 91\r\n74 81 83 86 92 95 96 93\r\n8 13 14 20 21 24 24\r\n32 37 43 46 50\r\n55 62 64 70 72 77\r\n87 85 84 81 79 82\r\n91 88 86 85 82 82\r\n80 77 74 72 68\r\n33 31 29 27 24 21 15\r\n28 25 26 25 24\r\n46 44 45 43 45\r\n26 24 26 23 21 21\r\n47 45 42 41 43 41 37\r\n30 28 29 28 26 21\r\n22 20 19 16 16 13 11\r\n37 34 31 31 32\r\n59 56 54 54 53 50 50\r\n63 61 60 60 58 54\r\n16 13 13 10 9 2\r\n35 33 30 26 24\r\n80 78 74 71 68 65 67\r\n67 65 62 58 56 54 54\r\n21 20 16 13 11 7\r\n40 38 36 34 32 28 26 21\r\n50 48 43 42 41 39\r\n31 29 23 20 21\r\n83 80 77 72 70 70\r\n56 53 51 48 45 42 36 32\r\n84 81 78 76 70 63\r\n85 86 85 82 79\r\n72 74 71 69 72\r\n67 70 69 67 65 64 62 62\r\n25 26 24 23 22 19 18 14\r\n75 77 74 73 71 69 67 62\r\n80 81 80 79 81 80 78\r\n45 46 45 42 45 42 43\r\n93 96 95 98 98\r\n17 20 18 19 17 13\r\n23 26 23 22 23 18\r\n23 26 26 25 23 21 19 17\r\n56 58 57 55 52 52 54\r\n37 39 36 36 34 34\r\n35 38 36 34 31 28 28 24\r\n50 51 51 49 47 45 38\r\n57 60 59 57 56 52 51\r\n47 48 46 43 39 42\r\n13 14 11 9 7 3 1 1\r\n40 43 40 37 35 31 30 26\r\n32 34 32 31 30 28 24 17\r\n58 60 53 51 48 45\r\n15 17 10 9 6 5 4 6\r\n42 45 43 37 37\r\n79 81 80 73 72 68\r\n63 64 63 62 59 56 49 42\r\n12 12 9 6 5 3 2\r\n13 13 11 9 10\r\n23 23 21 20 18 17 17\r\n27 27 25 22 20 16\r\n75 75 73 72 65\r\n87 87 90 88 85 83 81 80\r\n29 29 26 25 26 24 25\r\n38 38 39 38 35 32 32\r\n70 70 73 70 67 66 62\r\n57 57 60 57 56 50\r\n49 49 49 47 45 44\r\n29 29 26 26 25 27\r\n22 22 22 20 18 15 14 14\r\n77 77 77 76 72\r\n23 23 20 20 14\r\n54 54 53 50 48 47 43 41\r\n14 14 12 9 5 4 3 5\r\n23 23 21 19 17 13 13\r\n73 73 71 67 66 62\r\n98 98 94 93 92 91 86\r\n60 60 54 51 48 45 44\r\n98 98 92 89 86 84 82 84\r\n43 43 36 35 32 31 29 29\r\n49 49 48 46 44 39 36 32\r\n49 49 47 45 43 41 36 31\r\n24 20 19 18 15 14 13 10\r\n71 67 65 63 66\r\n36 32 29 28 26 25 24 24\r\n77 73 70 69 66 62\r\n44 40 37 35 33 28\r\n44 40 37 40 38 36 34\r\n10 6 5 2 5 2 3\r\n29 25 26 24 24\r\n79 75 78 77 73\r\n96 92 89 92 86\r\n11 7 7 6 3 2 1\r\n19 15 13 11 10 8 8 9\r\n32 28 25 25 25\r\n70 66 64 64 61 57\r\n69 65 65 62 61 56\r\n79 75 73 69 68 65 63\r\n97 93 89 87 90\r\n57 53 50 49 45 43 43\r\n59 55 51 50 47 43\r\n49 45 44 43 41 40 36 31\r\n72 68 66 59 56 54\r\n87 83 82 81 80 73 74\r\n95 91 89 87 82 82\r\n55 51 50 48 41 37\r\n64 60 59 56 50 43\r\n67 62 61 58 57 56 54 51\r\n24 17 15 14 12 14\r\n76 69 68 66 64 62 62\r\n47 42 41 40 39 38 36 32\r\n62 57 54 51 50 45\r\n73 66 63 65 63\r\n32 26 24 26 27\r\n44 39 36 34 31 32 31 31\r\n91 85 88 87 85 83 79\r\n85 80 82 79 73\r\n87 81 78 77 75 75 74\r\n25 20 19 19 18 19\r\n41 35 33 31 31 31\r\n80 75 74 71 69 69 68 64\r\n62 57 54 54 53 47\r\n48 41 37 35 34 32\r\n40 33 31 28 24 21 19 20\r\n18 13 10 6 6\r\n66 61 58 54 50\r\n68 61 58 56 52 50 45\r\n68 61 58 56 49 46 45 42\r\n79 74 68 66 63 65\r\n19 13 10 3 2 2\r\n84 78 72 69 65\r\n84 78 76 75 70 64\r\n3 4 5 8 9 8\r\n64 67 69 72 75 78 81 81\r\n10 12 13 15 19\r\n66 68 70 72 78\r\n56 58 61 58 61 64 65 67\r\n77 79 82 84 82 80\r\n17 20 23 26 25 27 27\r\n57 59 61 63 60 62 63 67\r\n59 60 58 59 65\r\n65 66 68 69 70 70 71\r\n85 86 87 87 89 90 89\r\n36 37 39 40 40 40\r\n40 41 44 44 46 50\r\n6 7 7 8 10 12 15 22\r\n63 66 69 73 74\r\n22 25 27 31 33 35 38 35\r\n22 23 27 29 30 31 31\r\n6 8 10 12 15 19 23\r\n57 58 59 63 65 67 72\r\n43 45 47 50 55 56 58\r\n75 77 79 84 81\r\n71 72 77 80 81 81\r\n44 45 46 47 53 55 57 61\r\n15 17 22 24 27 30 37\r\n88 86 88 90 91 94\r\n74 72 74 75 76 78 80 79\r\n60 57 60 63 63\r\n24 23 26 27 30 33 35 39\r\n49 48 51 54 57 64\r\n46 43 40 43 44 45 48\r\n43 41 42 43 41 42 40\r\n55 54 55 56 59 60 57 57\r\n64 62 64 67 70 68 72\r\n42 41 38 40 43 46 53\r\n86 85 87 87 89\r\n84 81 83 83 80\r\n72 69 70 73 76 76 76\r\n65 64 64 65 67 71\r\n71 69 71 71 73 75 81\r\n6 5 9 12 15\r\n46 45 48 51 55 54\r\n70 69 72 76 76\r\n30 28 30 33 37 40 41 45\r\n70 69 71 72 73 77 79 84\r\n53 51 52 54 61 62\r\n42 39 41 46 48 51 50\r\n16 14 17 19 24 26 27 27\r\n74 72 75 77 84 85 89\r\n65 63 69 71 78\r\n81 81 84 85 86 87\r\n81 81 84 87 88 91 88\r\n26 26 27 30 32 35 35\r\n18 18 21 22 24 26 29 33\r\n21 21 22 23 26 27 29 36\r\n61 61 64 63 66\r\n36 36 37 40 41 38 40 39\r\n68 68 69 67 67\r\n51 51 48 50 54\r\n4 4 2 3 5 7 10 17\r\n51 51 54 57 57 58\r\n54 54 57 57 54\r\n62 62 64 64 65 65\r\n64 64 66 66 70\r\n84 84 87 89 89 95\r\n4 4 5 7 9 13 16 17\r\n1 1 4 6 7 9 13 11\r\n30 30 34 35 35\r\n54 54 57 60 64 66 67 71\r\n58 58 59 60 63 64 68 73\r\n90 90 91 96 99\r\n48 48 54 55 56 57 58 56\r\n25 25 27 34 37 38 38\r\n54 54 55 61 64 67 71\r\n8 8 10 13 14 15 22 27\r\n16 20 21 24 27 29 31\r\n38 42 44 46 47 50 47\r\n41 45 46 49 52 54 54\r\n41 45 47 49 51 53 57\r\n76 80 83 84 90\r\n63 67 69 70 68 69\r\n10 14 16 19 21 19 22 21\r\n43 47 49 46 46\r\n66 70 67 68 72\r\n36 40 43 40 46\r\n81 85 86 86 88 90 92\r\n66 70 70 71 73 76 73\r\n37 41 41 42 44 46 46\r\n4 8 8 9 12 14 18\r\n53 57 59 60 60 62 68\r\n80 84 85 89 90 93\r\n64 68 71 75 76 77 79 78\r\n25 29 33 35 36 39 39\r\n74 78 79 82 86 87 91\r\n26 30 33 37 44\r\n69 73 78 80 82\r\n70 74 80 83 86 84\r\n23 27 28 34 37 37\r\n55 59 61 64 70 73 75 79\r\n32 36 38 40 42 48 51 57\r\n63 68 71 73 76 77\r\n62 68 69 71 72 69\r\n82 87 88 89 92 93 95 95\r\n51 56 59 61 62 63 66 70\r\n19 24 25 27 29 36\r\n56 61 62 59 62\r\n57 64 65 63 61\r\n46 51 53 56 54 56 56\r\n70 76 78 81 78 82\r\n11 17 19 21 22 20 26\r\n26 33 35 35 37 38 39\r\n79 85 86 89 90 91 91 89\r\n89 94 96 98 98 98\r\n35 40 40 42 43 45 47 51\r\n67 74 76 76 78 84\r\n23 30 31 32 36 39 41 44\r\n33 39 42 45 49 47\r\n50 57 59 63 64 64\r\n71 77 80 81 85 87 88 92\r\n46 53 54 58 65\r\n50 55 58 61 62 67 68\r\n9 14 17 22 21\r\n74 80 83 86 91 92 93 93\r\n35 41 48 49 52 53 57\r\n54 60 62 64 67 73 75 82\r\n75 74 71 69 67 64 67\r\n31 29 28 25 25\r\n60 58 55 54 53 52 49 45\r\n29 26 25 23 16\r\n90 88 85 86 83 80 78 77\r\n9 6 3 6 7\r\n12 9 8 7 9 6 6\r\n97 95 92 94 90\r\n89 87 84 87 84 82 79 74\r\n67 65 63 60 58 58 57\r\n54 51 48 48 45 46\r\n93 90 87 85 85 85\r\n36 34 34 31 30 26\r\n86 85 84 84 79\r\n42 40 38 35 31 30 27 24\r\n32 29 26 22 23\r\n39 37 34 30 27 24 23 23\r\n85 83 79 76 74 72 68\r\n67 64 62 60 56 55 54 47\r\n97 94 93 91 88 87 80 79\r\n67 65 64 59 57 59\r\n43 40 38 36 31 29 29\r\n22 20 18 13 10 7 3\r\n49 47 45 42 40 34 28\r\n75 78 75 73 70\r\n7 8 6 4 7\r\n95 97 95 94 94\r\n36 37 36 33 29\r\n96 98 95 93 92 86\r\n3 5 6 3 2\r\n33 36 34 31 32 35\r\n13 16 13 14 14\r\n45 46 48 45 43 42 38\r\n36 37 34 36 29\r\n27 30 30 28 27\r\n91 92 89 86 83 83 85\r\n80 83 83 82 82\r\n33 35 34 32 31 31 28 24\r\n93 95 92 92 87\r\n41 44 43 39 36 34\r\n17 20 16 15 16\r\n92 94 93 90 88 87 83 83\r\n55 58 57 54 50 46\r\n44 45 43 41 37 31\r\n95 97 94 93 90 83 81 80\r\n96 99 92 91 88 90\r\n38 41 40 39 37 32 31 31\r\n30 33 27 24 23 22 18\r\n22 25 23 16 14 7\r\n20 20 18 15 12\r\n47 47 44 41 42\r\n39 39 38 35 32 29 27 27\r\n84 84 83 81 79 77 73\r\n89 89 86 83 80 78 71\r\n71 71 68 69 67\r\n66 66 64 66 69\r\n67 67 64 63 66 66\r\n56 56 55 52 51 50 51 47\r\n62 62 59 62 59 57 56 51\r\n75 75 72 72 69 66 64 62\r\n81 81 80 80 82\r\n72 72 69 69 69\r\n43 43 42 41 41 38 34\r\n39 39 37 37 35 32 27\r\n24 24 20 19 16 15 13 11\r\n18 18 14 11 12\r\n18 18 14 13 11 10 10\r\n82 82 80 79 76 72 71 67\r\n71 71 70 67 63 62 59 53\r\n91 91 84 81 78\r\n46 46 43 37 40\r\n14 14 8 7 7\r\n47 47 42 39 36 33 32 28\r\n19 19 14 12 10 9 7 2\r\n75 71 69 67 64 63\r\n88 84 81 80 77 75 74 76\r\n80 76 75 74 71 70 70\r\n79 75 74 72 68\r\n44 40 37 36 34 28\r\n50 46 44 47 46\r\n51 47 49 48 47 44 42 45\r\n35 31 33 30 28 25 23 23\r\n19 15 14 11 13 12 11 7\r\n49 45 44 43 44 39\r\n23 19 18 18 15 14 12\r\n53 49 48 48 50\r\n56 52 52 51 51\r\n70 66 64 64 63 62 58\r\n75 71 69 66 66 63 57\r\n59 55 53 49 46\r\n94 90 86 85 83 86\r\n90 86 82 81 81\r\n51 47 43 41 37\r\n63 59 56 54 50 45\r\n75 71 68 65 60 57 54\r\n25 21 18 13 10 8 9\r\n95 91 85 84 84\r\n96 92 89 86 81 77\r\n42 38 36 34 28 27 25 20\r\n52 45 43 41 39 38\r\n61 56 54 52 51 53\r\n90 83 82 79 77 76 76\r\n99 94 92 89 88 84\r\n50 45 43 41 39 38 35 29\r\n10 5 8 7 6\r\n68 63 62 59 61 64\r\n89 82 79 82 79 77 77\r\n15 8 9 8 5 1\r\n22 17 14 17 12\r\n22 17 16 13 10 10 9 8\r\n31 24 21 20 17 17 15 16\r\n60 55 54 54 54\r\n59 54 52 51 49 46 46 42\r\n95 88 86 86 81\r\n57 52 49 46 45 41 40 39\r\n46 41 38 36 32 33\r\n31 26 24 21 19 17 13 13\r\n58 52 50 46 45 43 42 38\r\n40 35 34 30 29 23\r\n93 88 87 82 81 78\r\n84 78 75 72 66 69\r\n58 52 47 46 46\r\n21 15 13 12 7 5 1\r\n60 54 53 48 41\r\n43 45 52 54 55 55\r\n62 58 55 52 55 54 50\r\n27 26 23 20 18 20 16\r\n21 19 21 19 18 16 14 12\r\n5 12 15 21 22 21\r\n43 36 34 37 36 35 37\r\n49 50 47 46 47 45 45\r\n53 53 49 46 43 42 40 40\r\n52 51 49 52 49 44\r\n29 35 38 40 42 41 43 47\r\n68 69 68 66 65 58\r\n84 84 87 89 90 91 93 94\r\n18 18 16 15 17\r\n2 2 4 6 8 8\r\n52 52 54 52 53 57\r\n84 88 89 96 95\r\n30 32 35 37 39 42 46 45\r\n34 27 25 18 15 8\r\n48 44 43 41 34 33 29\r\n32 32 33 32 33\r\n96 96 96 94 92 85\r\n97 94 92 90 88 87 83\r\n36 32 35 33 32 29 27 28\r\n35 28 27 22 18\r\n41 45 47 44 47 49 47\r\n48 51 52 53 56 60 62\r\n88 82 80 77 78 72\r\n39 41 44 51 55\r\n17 17 21 22 26\r\n59 61 63 66 67 65\r\n93 89 91 88 85 82 75\r\n89 85 84 81 78 79\r\n23 18 16 15 18 16\r\n19 15 16 15 15\r\n20 20 21 23 30 37\r\n82 75 74 71 69 67 70\r\n12 12 16 18 24\r\n60 60 59 56 49 49\r\n68 68 70 73 74 80 81 78\r\n20 23 25 22 20 18\r\n26 26 27 30 30 33 34 32\r\n89 84 79 78 78\r\n32 31 29 31 33 36\r\n12 9 11 13 15 19\r\n21 28 30 31 32 35 37 37\r\n77 77 76 73 71 68 67\r\n84 83 80 80 75\r\n76 73 71 69 68 69\r\n47 40 34 31 29 27 24 26\r\n27 33 34 38 40 41 42 45\r\n60 59 60 62 63 66 64 64\r\n59 63 64 65 67 69 70 74\r\n15 8 10 8 8\r\n56 56 55 53 51 47 42\r\n69 68 67 64 63 59 58 54\r\n71 68 69 67 70 72 78\r\n66 69 66 64 61 59 55 57\r\n13 13 10 9 6 6 4 1\r\n94 89 87 85 82 80 76 73\r\n18 23 23 26 28\r\n19 19 18 17 15 14 10 13\r\n18 22 23 20 24\r\n36 32 31 24 22 20\r\n39 41 39 36 35 35\r\n73 70 67 68 71 72 73 77\r\n20 18 18 21 21\r\n89 91 94 95 96 95 97 97\r\n62 58 57 55 52 51 51\r\n96 96 95 93 92 90 87 80\r\n56 57 57 55 54 51 49\r\n22 18 17 16 13\r\n40 44 45 42 45 46 46\r\n96 92 89 89 84\r\n84 83 81 76 75 75\r\n23 24 27 29 32 32 35\r\n88 90 90 89 87 89\r\n89 82 78 76 72\r\n11 9 13 16 18 22\r\n70 67 66 64 62 58 51\r\n78 78 77 76 71 68 65\r\n70 70 72 75 78 80 83 90\r\n37 31 31 28 27 27\r\n4 4 6 9 10 11 15 18\r\n11 11 13 13 17\r\n53 59 62 64 61 62 62\r\n77 81 80 81 82 84 89\r\n2 7 12 15 16 19 20 23\r\n58 58 61 64 67 64 66 68\r\n3 6 9 12 15 16 16\r\n46 45 45 47 49 46\r\n65 66 63 61 60 55 53 56\r\n39 33 31 27 27\r\n26 30 31 35 37 37\r\n51 55 57 59 59\r\n97 97 96 95 96 95\r\n96 89 87 84 85 81\r\n9 13 15 15 17 20 24\r\n37 30 28 25 24 23 22 17\r\n41 35 35 32 35\r\n43 45 43 46 47\r\n62 62 60 58 55 53 53\r\n10 14 17 21 24 26 29\r\n93 93 90 89 85\r\n77 77 84 86 88\r\n90 88 88 91 98\r\n98 95 92 91 90 90 87 87\r\n71 72 76 79 83\r\n27 27 25 24 20 18 17\r\n45 51 52 54 56 59 61 59\r\n20 20 20 19 16 18\r\n32 28 28 26 24 23 22\r\n30 33 34 39 41 43 50\r\n33 32 29 27 22\r\n28 26 28 31 35 36\r\n63 66 59 58 56 53 51\r\n66 70 72 76 80\r\n62 62 66 67 70 72 72\r\n66 67 67 64 63 60 59 53\r\n23 27 29 30 31 36\r\n87 80 79 78 75 71\r\n97 98 97 96 95 90 86\r\n75 72 75 81 82 85 89\r\n36 31 28 28 26 23 21 14\r\n32 37 44 45 48 48\r\n50 54 55 57 59 62\r\n73 76 75 72 70 67 60 54\r\n64 68 69 71 69 72 74 75\r\n57 64 66 68 72 73 75 75\r\n87 87 86 87 85 81\r\n74 80 84 87 92\r\n99 95 94 91 88 81 81\r\n41 38 40 38 38\r\n30 34 37 40 43 49 49\r\n28 26 28 31 32 33 39\r\n61 65 65 67 68 70 72 75\r\n59 60 64 67 74\r\n44 46 46 47 47\r\n30 26 25 24 22 18\r\n18 20 23 25 28 29 34\r\n66 66 67 68 69 69 71 76\r\n82 83 84 86 88 88 85\r\n37 33 31 30 29 26 20\r\n11 11 11 10 7 7\r\n58 59 61 59 62 64 68\r\n38 39 36 34 32 29 25\r\n50 56 59 61 63 65 71\r\n33 36 37 34 39\r\n39 35 32 30 26 27\r\n20 26 28 29 26 29\r\n38 37 39 45 45\r\n1 2 5 8 8 15\r\n54 54 56 58 63 65 66 66\r\n29 34 36 37 40\r\n89 85 82 81 80 76 75 74\r\n37 41 46 48 51 55\r\n98 94 94 93 91 90 86\r\n6 3 5 8 10 12 12\r\n20 27 24 27 32\r\n38 33 27 24 23 22\r\n59 60 57 55 53 51 52\r\n19 25 26 26 31\r\n83 83 85 82 84 85 84\r\n44 45 44 44 44\r\n6 11 14 16 22 24 25 30\r\n9 7 10 7 6 9\r\n74 75 72 68 67 63\r\n64 57 56 53 51 49 49\r\n33 31 31 29 27 24 22 18\r\n74 71 70 67 63 62 65\r\n25 21 17 16 12\r\n18 22 25 28 28 30 33 33\r\n88 86 82 79 76 74 71 70\r\n21 25 28 29 36 43\r\n82 83 87 89 90 90\r\n62 62 61 60 59 58 52 54\r\n87 88 85 86 83 81 77\r\n65 59 57 57 53\r\n77 70 69 66 63\r\n42 38 37 35 32 26 19\r\n47 47 46 43 40 37 31 26\r\n4 4 6 5 2 2\r\n78 78 75 74 71 67 63\r\n85 84 78 75 73 67\r\n38 37 38 40 43 46 43\r\n40 35 35 34 32\r\n5 5 7 9 12 16\r\n70 66 64 60 59 57 54 49\r\n62 63 61 62 57\r\n37 37 38 37 36 34 28\r\n38 43 43 44 46 47 46\r\n84 83 82 78 78\r\n27 24 27 30 31 35 42\r\n82 83 84 85 92 94\r\n74 77 78 81 79 80 77\r\n80 80 77 70 67 65 64 60\r\n40 44 46 49 51 51 48\r\n43 47 48 54 56\r\n20 16 14 12 8 8\r\n57 55 57 60 63 60 58\r\n91 94 93 92 90\r\n14 21 24 25 26 27 27 27\r\n76 76 83 84 86 90\r\n54 57 58 60 66 64\r\n21 22 24 21 22 25 27\r\n17 16 14 11 9 7 7\r\n78 74 73 72 71 68 62 65\r\n91 91 92 94 96 99 98\r\n55 55 54 55 60\r\n85 81 80 78 76 76 73 73\r\n56 60 62 64 66 68 72 78\r\n37 44 46 50 52 54 56 60\r\n32 33 32 30 26 20\r\n61 66 67 68 70 70 71 75\r\n47 44 42 42 39 38 36 34\r\n9 8 10 17 20 21 24\r\n78 72 68 65 62 60 53\r\n31 29 32 39 45\r\n48 46 49 50 53 54 56 57\r\n20 24 25 26 29 30 28\r\n86 84 89 92 94 97 95\r\n11 11 12 14 14 17 18 18\r\n20 24 25 29 31 33 30\r\n51 53 55 57 58 60 62\r\n15 13 11 9 7 4\r\n63 64 65 68 71 73\r\n31 33 36 38 40 43 45 48\r\n60 58 56 55 54 51\r\n2 4 6 9 12 13 15 16\r\n13 16 19 20 22 24 27\r\n69 70 73 75 77 79\r\n31 32 34 36 38 39 41\r\n18 21 22 24 26\r\n7 8 11 13 15 18 20 23\r\n52 50 47 46 43\r\n40 37 34 32 31 29\r\n24 26 27 29 32 34 37\r\n33 30 28 25 22 19 17\r\n13 10 7 6 5 3 2\r\n24 22 20 18 16 14 11\r\n69 66 64 62 60 59 58\r\n33 32 30 29 28 27\r\n94 93 90 87 86\r\n38 35 32 30 27\r\n63 65 66 67 68 70\r\n55 57 60 62 65 66 68\r\n54 57 58 60 63 66\r\n30 29 27 24 23\r\n17 16 15 12 10 7 5 3\r\n58 57 54 53 51 49 47\r\n17 19 21 24 27\r\n74 76 78 81 84 85 88 89\r\n75 73 72 70 67 64 62\r\n52 53 56 59 62\r\n36 33 31 29 26 23\r\n81 84 87 88 91\r\n89 87 84 83 82 79 76\r\n30 33 34 36 38 41 42 44\r\n37 36 34 33 32 29 28\r\n97 96 95 92 91 89\r\n26 29 30 31 34 37 38\r\n47 46 43 41 39 36\r\n14 16 19 20 23 26 29\r\n67 68 71 74 77 80\r\n67 65 63 61 60 57 54\r\n17 18 21 24 27 30 33\r\n93 92 89 86 85\r\n50 53 55 57 59\r\n45 47 50 51 54 57\r\n56 58 59 60 62 65 67\r\n84 82 80 79 76 74 71 70\r\n47 44 41 39 37\r\n54 56 57 60 61 64\r\n64 61 59 56 55\r\n34 36 37 38 39\r\n57 56 53 51 48 46 43\r\n76 73 71 68 65 62 60\r\n27 29 32 33 34 37 40\r\n57 59 61 63 66 68\r\n40 39 38 37 34 33\r\n44 43 40 37 35 32 31 29\r\n37 36 35 34 31 29 26\r\n28 26 25 24 22 19 17\r\n67 68 70 73 75 77\r\n47 44 41 39 36 35 34\r\n89 87 86 85 82\r\n35 37 39 40 42\r\n77 75 72 71 69 66\r\n44 43 41 40 38\r\n60 61 63 64 66 69\r\n20 17 16 15 13 12\r\n10 9 6 5 2\r\n95 93 92 89 88 86\r\n36 33 31 30 27 25\r\n81 80 77 74 72\r\n63 64 66 68 70\r\n30 33 36 39 41 44 45 46\r\n66 69 70 72 73 76 77 79\r\n86 89 92 93 95\r\n52 53 56 58 59 62 65 66\r\n42 39 38 35 33 32 29\r\n11 12 14 15 16\r\n31 34 36 38 40 41\r\n57 60 61 63 65 66\r\n27 24 21 18 17 15 12 10\r\n57 56 55 53 50 48\r\n25 22 20 18 15\r\n70 67 64 62 61\r\n21 23 24 26 28\r\n12 9 6 4 3\r\n76 77 80 82 85 88 89 92\r\n56 53 50 49 46 44 41 40\r\n85 88 90 93 95 96 98\r\n71 73 76 79 81 83\r\n46 47 50 52 54 55 56\r\n70 71 72 74 77\r\n53 51 48 46 44 43 42 39\r\n2 4 6 9 10 12 13\r\n58 56 54 53 52 51\r\n65 68 71 72 75\r\n85 84 81 80 78 77 74\r\n19 20 22 25 26 29 32 35\r\n6 8 10 13 15 18 20\r\n62 59 57 55 54\r\n21 20 19 16 15\r\n17 15 12 10 8\r\n88 90 91 92 93 95 96\r\n37 36 34 32 31\r\n77 79 82 85 86 87\r\n78 81 84 86 88 89\r\n44 43 42 39 37 34 31 28\r\n55 52 49 46 44 41 40 38\r\n86 87 88 90 93 94 95 97\r\n69 67 66 64 61\r\n30 31 34 37 39\r\n74 75 77 80 82 83 84\r\n46 49 50 52 55 56\r\n80 77 76 75 74\r\n58 61 64 67 69 72 74\r\n85 87 88 90 93 94 96 97\r\n79 82 84 87 89 90 92 94\r\n12 15 17 19 22\r\n30 29 27 26 25\r\n39 38 35 34 32\r\n57 56 55 54 53 50 47 44\r\n63 61 58 55 54 52 50\r\n93 92 91 88 87\r\n45 47 49 50 51\r\n69 67 66 64 61 58 56\r\n55 53 52 51 48 45 44\r\n64 63 61 58 57\r\n73 74 75 77 78 79\r\n9 6 4 3 1\r\n19 22 24 26 27 29\r\n24 23 21 19 17 14\r\n82 80 78 75 72 71\r\n22 24 25 28 31\r\n59 60 63 64 66\r\n22 23 26 27 30\r\n67 65 64 61 60 59\r\n22 23 25 26 28 30 33 36\r\n34 35 37 38 40 43 44 47\r\n71 70 69 66 64 61\r\n44 41 40 37 36\r\n32 33 34 37 39 42 45 47\r\n37 38 39 41 44 47\r\n56 53 52 50 49 48\r\n75 74 71 69 67 64 61 58\r\n93 92 89 88 86 84 83\r\n16 14 11 9 8 7 6 4\r\n42 45 47 50 52\r\n85 86 89 90 93\r\n79 82 83 84 86 89 90\r\n40 38 37 34 32 29\r\n40 43 44 46 48 49\r\n86 85 83 82 81 80\r\n91 88 86 85 82 81\r\n49 50 52 54 56 58 60\r\n55 56 57 58 60\r\n83 81 79 76 73 70 68 66\r\n43 42 40 39 37 36 33\r\n57 58 59 60 63\r\n48 50 51 54 57 58\r\n36 37 38 40 43 45 46 49\r\n37 38 39 42 43 46\r\n72 71 69 66 63 60 59\r\n56 55 53 50 49 47 44\r\n56 58 59 62 63\r\n35 37 38 41 44 46 49 51\r\n30 28 27 25 24\r\n71 70 69 68 67\r\n68 66 65 63 62 60 57 54\r\n60 61 63 64 65 66 67\r\n1 4 5 6 9 10\r\n30 27 25 22 20 19 17 15\r\n60 59 58 57 55 52\r\n53 54 56 57 59 62 63 64\r\n93 91 88 87 86 84 83 81\r\n96 93 92 89 87 85 83 82\r\n65 63 61 58 55 54 53 51\r\n10 13 16 18 19 22 25 26\r\n26 27 29 32 35 37 40 42\r\n90 87 84 82 80 79 77\r\n55 57 58 59 62 65\r\n38 41 42 45 48 51\r\n12 13 15 17 19 22 23\r\n61 59 58 55 53 52\r\n2 3 5 8 11 13 16 18\r\n60 62 64 67 68 71 74 76\r\n13 10 9 8 7 6 3 1\r\n66 69 70 73 75 76 79\r\n67 66 65 62 60 57\r\n87 84 82 80 77 75 72\r\n78 80 82 85 86 88 91 93\r\n39 36 34 32 29 26\r\n24 22 21 20 18\r\n41 38 35 32 29 28 27 25\r\n86 87 88 90 92 95\r\n96 95 93 90 88\r\n37 40 42 44 47\r\n36 39 41 44 47 48 50 51\r\n89 90 93 94 95 96\r\n19 16 15 14 12 10 9\r\n66 67 68 69 70 72 73 76\r\n87 85 84 82 79 76 73 71\r\n50 53 55 56 57\r\n31 33 35 37 38 40 41 44\r\n63 60 59 57 56 54\r\n14 16 19 20 21 22\r\n82 81 78 75 74\r\n53 55 57 59 60 62 64\r\n88 91 93 94 96 97\r\n62 64 65 67 69 70 72 75\r\n14 12 11 9 8\r\n23 22 21 18 17 14 12 11\r\n85 82 79 78 77\r\n49 52 55 58 60 61\r\n66 67 70 72 75 78 81\r\n76 79 81 84 87 90 92\r\n38 40 42 43 44 47\r\n45 42 39 36 33 32 31\r\n53 56 59 62 63 66 68 71\r\n77 76 73 70 68 66\r\n42 40 37 36 35 33 30 28\r\n4 7 9 12 13 16 17\r\n84 87 88 89 91\r\n33 34 37 38 40\r\n13 15 17 20 23 26 29 31\r\n63 62 61 58 57\r\n12 9 7 6 5 4 2 1\r\n86 87 88 90 91\r\n88 85 84 83 80 77\r\n12 11 10 7 6\r\n58 59 61 62 63 65 67 69\r\n55 52 51 48 46 43 42\r\n64 61 59 56 54 52 50\r\n93 90 89 87 85 84 81\r\n40 41 43 46 49\r\n65 63 62 60 59 56 55\r\n87 86 83 80 78 76\r\n34 36 39 40 43\r\n24 25 28 31 34 37 38 39\r\n30 27 24 22 21\r\n26 25 24 23 21 19 16 13\r\n47 45 42 41 40 39\r\n35 34 33 31 29\r\n24 23 20 18 17 16 15 14\r\n82 80 77 74 71\r\n16 18 21 24 27 30 33\r\n61 58 57 56 55\r\n40 39 37 35 32\r\n70 72 75 78 80 83 86 89\r\n68 65 63 62 61 59\r\n91 89 87 85 82 81 80\r\n5 6 8 11 13\r\n24 26 29 32 34\r\n46 47 48 49 50 53 56\r\n69 71 73 76 79 81 84\r\n2 4 6 9 12 15 17\r\n64 65 66 67 68\r\n68 67 64 63 61\r\n38 36 35 33 32 29 28\r\n22 21 20 19 18 15\r\n61 60 57 54 51\r\n15 13 11 10 7 4\r\n5 7 9 12 14 17 18 20\r\n89 86 85 84 81 80 77\r\n31 34 36 39 42 43\r\n95 92 90 89 88\r\n74 75 76 78 81 82 85 86\r\n6 7 10 13 14 15 17 19\r\n75 77 79 81 82\r\n52 53 54 55 56 58\r\n43 40 39 38 37 36 35\r\n54 51 50 49 46\r\n70 73 74 76 78 80\r\n67 66 65 62 59 58 57\r\n31 33 34 35 37 39\r\n56 58 59 62 63 66 69 70\r\n24 22 21 20 18 16 15\r\n22 23 24 25 27\r\n82 83 84 87 88\r\n41 43 45 46 49 52\r\n24 22 21 19 16 15 13 12\r\n61 64 66 69 71 72 75 77";

            int[][] result = data
    .Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries) 
    .Select(row => row
        .Split(' ')
        .Select(int.Parse) 
        .ToArray())
    .ToArray(); 


            return result;
        }
    }
}