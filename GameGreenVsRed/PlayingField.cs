using System;
using System.Collections.Generic;
using System.Text;

namespace GameGreenVsRed
{
    public class PlayingField : Field
    {
    private char[,] playingField;
    private char[,] duplicateField;
    int row;
    int col;

    public PlayingField(char[,] playingField, char[,] duplicateField, int row, int col)
    {
        this.playingField = playingField;
        this.duplicateField = duplicateField;
        this.row = row;
        this.col = col;
    }

    //Next generation of the playing Field
    public void generate(char[,] playingField, char[,] duplicateField, int row, int col)
    {

        if (playingField[row, col] == '0')
        {
            int adjacentGreenCells = 0;
            for (int i = Math.Max(0, row - 1); i < Math.Min(row + 2, playingField.GetLength(0)); i++)
            {
                for (int j = Math.Max(0, col - 1); j < Math.Min(col + 2, playingField.GetLength(1)); j++)
                {
                    if (i == row && j == col)
                    {
                        //do nothing
                    }
                    else
                    {
                        if (playingField[i, j] == '1')
                        {
                            adjacentGreenCells++;
                        }
                    }
                    if (adjacentGreenCells == 3 || adjacentGreenCells == 6)
                    {
                        duplicateField[row, col] = '1';
                    }
                    else
                    {
                        duplicateField[row, col] = '0';
                    }
                }
            }
        }
        else if (playingField[row, col] == '1')
        {
            int adjacentGreenCells = 0;
            for (int i = Math.Max(0, row - 1); i < Math.Min(row + 2, playingField.GetLength(0)); i++)
            {
                for (int j = Math.Max(0, col - 1); j < Math.Min(col + 2, playingField.GetLength(1)); j++)
                {
                    if (i == row && j == col)
                    {
                        //do nothing
                    }
                    else
                    {
                        if (playingField[i, j] == '1')
                        {
                            adjacentGreenCells++;
                        }
                    }
                    if (adjacentGreenCells == 3 || adjacentGreenCells == 6 || adjacentGreenCells == 2)
                    {
                        duplicateField[row, col] = '1';
                    }
                    else
                    {
                        duplicateField[row, col] = '0';
                    }
                }
            }
        }
    }
}
}
