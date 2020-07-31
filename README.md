# Game Green vs red (task Mentormate job interview)

# Created by Radostin Gerdzhikov

 
 The game revolves around choosing a target cell by using coordinates and checking in how many generations the cell will remain green
 
 Rules of the game:
 * Green cells are represented by "1"
 * Red cells are represented by "0"
 
 * Each Red cell will become green if surrounded by exactly 3 or 6 Green neighbors
 * Each Green cell will remain Green if surrounded by exactly 2, 3 or 6 Green neighbors
  - Neighbors are adjacent cells: Vertical, Horizontal and Diagonal up to a total of 8 neighbors
  
 How to play:
 * 1st line of input: Size of the grid - width and height
 Example: 3, 3
 
 * 2nd line of input: Lines of Strings representing green and red cells according to the grid size
 Example: 010
          111
          001
          
 * 3rd line of input: Coordinates and number of generations
 Example: 1, 0, 15
 
 Final result will be printed on the console
