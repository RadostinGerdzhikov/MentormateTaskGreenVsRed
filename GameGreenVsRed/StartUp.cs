using System;
using System.Linq;

namespace GameGreenVsRed
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Read playing field dimensions
            int[] gridSizeDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            //Assign rows and columns to variables for readability and easy access
            int rowNumbers = gridSizeDimensions[1];
            int colNumbers = gridSizeDimensions[0];

            //Initialize and generate Generation Zero of the Playing Field
            char[,] playingField = new char[rowNumbers,colNumbers];
            for (int row = 0; row < rowNumbers; row++)
            {

                var inputChars = Console.ReadLine().ToCharArray();
                for (int col = 0; col < inputChars.Length; col++)
                {
                    playingField[row, col] = inputChars[col];
                }
                
            }

            //Read coordinates of target cell and Generation N and assign them to variables
            int[] coordinatesAndNumberN = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowTargetCoordinate = coordinatesAndNumberN[1];
            int colTargetCoordinate = coordinatesAndNumberN[0];
            int numberN = coordinatesAndNumberN[2];
                        
            //Assign number of generations to variable and check if target cell of Generation Zero is green
            int generationsCount = 0;
            if (playingField[rowTargetCoordinate, colTargetCoordinate] == '1')
            {
                generationsCount++;
            }

            //Duplicate Generation Zero field as to be able to morph it without affecting main field reference
            Duplicator duplicator = new FieldDuplicator();
            char[,] duplicateGenerationPlayingField = duplicator.duplicate(playingField, rowNumbers, colNumbers);


            //Do next generation of the Field
            for (int generations = 0; generations < numberN; generations++)
            {
                for (int duplicateRow = 0; duplicateRow <= Math.Min(duplicateRow + 1, playingField.GetLength(0) - 1); duplicateRow++)
                {
                    for (int duplicateCol = 0; duplicateCol <= Math.Min(duplicateCol + 1, playingField.GetLength(1) - 1); duplicateCol++)
                    {

                        PlayingField field = new PlayingField(playingField, duplicateGenerationPlayingField, duplicateRow, duplicateCol);

                        field.generate(playingField, duplicateGenerationPlayingField, duplicateRow, duplicateCol);
                    }
                }

                //Copy morphed field into Generation Zero Field to follow next generation
                playingField = duplicator.duplicate(duplicateGenerationPlayingField, rowNumbers, colNumbers);

                //Check if target cell is green in current generation
                if (playingField[rowTargetCoordinate, colTargetCoordinate] == '1')
                {
                    generationsCount++;
                }
            }

            //Print result
            Console.WriteLine(generationsCount);
        }
    }
}
