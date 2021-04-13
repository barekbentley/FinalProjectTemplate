/*  ### Final Project Firm Deadline: 5/3/2021 11:59 PM, late submission will NOT be accepted

Grading rubric:
  - This final project has 20 points in total.
  - Grader will run your program at first, if the program could not run successfully, you will lose 5 points at first.
  - Grader will try to debug your program and fix simple errors like (missing symbol or spelling errors); 
  - Three test cases will be applied on your program when grading: including computer win, human win and draw. 
  - Each test case is worth 5 points. Failed test case will lose 5 points. 
  - If you passed all three test cases, you get full 20 points.
  - If you failed all three test cases, you get 0 point.


Before submission please check:
  - Enter all members' Names and WTEmails in the following code cell
  - All your teammates have joined the same group on the WTClass
  - *Each group just need one submission submitted by group leader
  - The program gives expected output without errors
  - If you work in a group, EACH member should submit a Final Project Peer Evaluation Form to WTClass.
  - Submit the replit to the WTClass. If you do it on your computer, just submit this TicTacToe.cs file.
  


 Please enter information of group members below (e.g.: Full Name: WTemail):
    - Member1:
    - Member2:
    - Member3:
    - Member4:
    - Member5:


We have 16 questions, and each question has corresponding Piazza post for Q&A. Please share your questions on the Piazza
Here is the Piazza link: https://piazza.com/class/kgzn6ttpyiwoj
*/

using System;
public class TicTacToe {

    //initialize an 3x3 empty 2d-array as game board
    private char[ , ] board = new char[3,3];

    // declare a variable to indicate current player's marker.
    // it should be initialized when creating object with the class constructor in MainClass.
    // when currentPlayerMark ='x', it represents human player, 
    // when currentPlayerMark ='o', it represents computer player.
    private char currentPlayerMark; 
      
    // initialize an 1d-array used to store the row index and col index of a board cell for moving
    int[] move = new int[2];

    // Set the game board with all empty values (blank space ' ').
    private void initializeBoard() {
        // set all game board values to blank space ' '
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                board[i,j] = ' ';
            }
        }
    }

	/*
      Do NOT change ABOVE code. Your answers goes from here:
  */



    /* 
        Question: Class Constructor TicTacToe
        When creating an object of this class, call initializeBoard() method to initialize the game board with blank space,
        and assign currentPlayerMark value to class variable this.currentPlayerMark 
    */

    public TicTacToe(char currentPlayerMark) {
      // put your answer below


    }
	

    /*
        Question: printBoard
        Print values of 2d array: board in a 3x3 game board, the game board could contain mark 'x' or 'o', or just an empty board (if 2d array board is empty), for example:
                -------------           -------------
                |   |   | o |           |   |   |   |
                -------------           -------------
                |   | x |   |    OR     |   |   |   |
                -------------           -------------   
                |   |   |   |           |   |   |   | 
                -------------           -------------
    */
    public void printBoard() {
      // put your answer below


    }
	


    /*
        Question: isBoardFull
        Check if the game board is full 
            - if the borad is full (no value equal to blankspace), return true
            - else return false
        Hint: iterate values of 2d array: borad; if one of vale equals ' ' (blankspace), return false; else return true
    */ 
    public bool isBoardFull() {
      // put your answer below


    }
	



	  /* 
        Question: checkThreeValues
        Check if all three cells have the same characters (and not empty). Return true if they are same; otherwise return false.
        This method will be used by following checking-for-win methods

        Hint: check if c1, c2, c3 they are equal and they are not blankspace ' '
    */
    private bool checkThreeValues(char c1, char c2, char c3) {
      // put your answer below



    }

	
    /* 
        Question: checkRowForWin
        Iterate all rows in the board to check if there is a win. If there is a win on row (three cells in the same row have the same mark ('x' or 'o')), return true; otherwise, return false. E.g.:
                -------------  
                | x | x | x |  
                -------------  
                |   |   |   |  
                -------------  
                |   |   |   |  
                -------------  
    */
    private bool checkRowForWin() {
       // put your answer below



    }
	
	
    /* 
        Question: checkColForWin
        Iterate all columns in the board to check if there is a win. If there is a win on column (three cells in the same column have the same mark), return true; otherwise, return false. E.g.:

                -------------  
                | x |   |   |  
                -------------  
                | x |   |   |  
                -------------  
                | x |   |   |  
                -------------  
    */
    private bool checkColForWin() {
      // put your answer below



    }
	
	/* 
        Question: checkDiagonalForWin
        Check the two diagonals to see if either is a win. Return true if either wins, else return false. E.g.:

                -------------           -------------
                |   |   | x |           | x |   |   |
                -------------           -------------
                |   | x |   |    OR     |   | x |   |
                -------------           -------------   
                | x |   |   |           |   |   | x | 
                -------------           -------------
    */
    private bool checkDiagonalForWin() {        
      // put your answer below




    }
	

    /* 
        Question: checkForWin
        Check a win condition in game board; Returns true if there is a win on rows, columns or diagonals, false otherwise.
        Hint: This method calls above three win check methods to check the entire board. If one of method return true, this checkForWin method returns true. All three methods are false, this method returns false
    */
    public bool checkForWin() {
      // put your answer below



    }


	
	/* 
        Question: changePlayer
        Change player marks back and forth. This method is used to switch players. 
        After a human player placed a mark, it changes to computer player.
        After a computer player placed a mark, it changes to human player.
    */
    public void changePlayer() {
      // put your answer below




    }
	
    /* 
        Question: movePlayer
        Ask the human player to input the row index and col index from keyboard for placing marker on the game board.
        Check if the value of index is valid ( the index should be within [0,2])
        If valid, save the row index and column into the 1d array: move and return true;
        else, ask human user to input valid index again.
        Hint: use Console.ReadLine() and Convert.ToInt32() to get int value as from keyboard as index
    */    
    public bool movePlayer() {
      // put your answer below


    }


    /* 
        Question: placeMark
        Places a mark for current player at the cell specified by row index and col index saved in 1d array: move.
        Return true after placing a marker.
        Hint: placing marker means: board[row, col] = currentPlayerMark;
    */
    public bool placeMark(int[] move) {
      // put your answer below


    }
    

    
    
    /* 
        Question: moveToBlock
        When computer player make a move, it should check if human player will win in next move.
        if human player will win after placing a marker on a cell in next step
        computer player should return the row/col index of that cell within a 1d-array.
        if computer player can not find cell to stop human player, return null

        E.g: In the follwoing situation, the computer player should place a marker on cell (1,1) to blcok human player's win.
                                    -------------
                                    | x |   |   |
                                    -------------
                                    |   |   |   |
                                    -------------   
                                    | o |   | x | 
                                    ------------- 

        Hint: to check human player's win in next move, you can iterate each empty cell and assume that human player will place the mark on that empty cell. Then use checkForWin to see if human player places a marker on that empty cell will get a win. E.g:

        In the follwoing situation, the computer player iterate empty cell one by one, and put human player's makrer on the empty cell (here marker E indicate the human player's next move). Then run checkForWin and see if human player will win. In this example, we test empty cells from E1 to E4. human player will win until we place a marker on E4. So return the E4's index
                                    -------------
                                    | x |E1 |E2 |
                                    -------------
                                    |E3 |E4 |   |
                                    -------------   
                                    | o |   | x | 
                                    ------------- 

    */

    public int [] moveToBlock(){
      // put your answer below



      // if computer player can not find cell to stop human player, return null
        return null;
    }
    

    
    /* 
      Question: moveToWin
      When computer player make a move, it should check if it will win after placing a marker on an empty cell.
      if computer player will win after placing a marker on a cell, computer player should return the index of that cell within 1d-array; Else, computer player can not find cell to win, return null
  

      E.g: In the follwoing situation, the computer player should place a marker on cell (0,2) to get a win.

      Hint: the logic to find a win move is similiar to the moveToBlock. But in this method, we will test a win with marker of computer player.
                                  -------------
                                  | x |   | E |
                                  -------------
                                  | x | o |   |
                                  -------------   
                                  | o |   | x | 
                                  ------------- 
    */
    public int [] moveToWin(){
      // put your answer below



      // if computer player can not find cell to win, return null
        return null;
    }

    /* 
        Question: moveRandom
        If computer player could not find a move for block or win. Then return the index of the first empty cell as a random move.
        
        E.g: In the follwoing situation, the row/col index of next move for the computer player ('o') should be (0,1). Assign (0,1) to 1d-arrya: move and return it
                                    -------------
                                    | x | E |   |
                                    -------------
                                    |   | o |   |
                                    -------------   
                                    |   |   | x | 
                                    ------------- 
    */
    public int[] moveRandom(){
      // put your answer below

    }
    


    /* 
        Question: moveAI
        Make a move for the computer player. Check the:
            1. moveToWin
            2. moveToBlock
            3. moveRandom
        if moveToWin return index of cell for a win, assign the returned index to 1d-arry: move
        else check moveToBlock for a cell to block human player's win and assign the returned index to 1d-arry: move
        otherwise, use the random move from moveRandom and assign the returned index to 1d-arry: move

        Finally, print index of computer player's move. E.g.: Computer Player (o) moves: 2,0

    */
    public void moveAI(int[] move)
    {
      // put your answer below



    }


    /* 
        Question: Play
        After creating an object of TicTacToe in MainClass, call this Play() method to strat game.
        Follow the code comments to implement this method

    */

    public void Play(){
      // Print initial game board with printBoard()



      // use a loop to keep game running until a player win, or there is a tie (when the board is full and no play wins).
      while(true) 
      {
        // print out which player goes first, 
        // if computer player goes fist, print: === Computer Player (o) ===; and make a move for computer by calling moveAI
        // else: print ## Human Player (x) ## and call movePlayer()
        
        




        // call placeMark to place a marker based on the 1d-array: move
        



        // Print gameboard

   
        // Do we have a winner ?! Call checkForWin to decide a winner
        // if we have a winner, break the loop and stop the game
        // print computer or human player win (based on the value of currentPlayerMark)
         
         



        

        // It is a draw ?! (check if board is full), break the loop and stop the game
        // print  Appears we have a draw!
        
        


        // if No winner or a draw => call changePlayer() to switch players and go next round

      }
    }



}