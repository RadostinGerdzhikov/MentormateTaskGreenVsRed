using System;
using System.Collections.Generic;
using System.Text;

namespace GameGreenVsRed
{
    public interface Duplicator
    {
        //Duplicate a Playing Field to another one
        char[,] duplicate(char[,] playingField, int row, int col);
    }
}
