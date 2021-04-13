//*** Do NOT change code in this class***
using System;

class MainClass {
  public static void Main (string[] args) {
    // initialize a game object called game and set human player ('x') goes first.
    // when currentPlayerMark ='x', it represents human player, 
    // when currentPlayerMark ='o', it represents computer player.
      TicTacToe game = new TicTacToe(currentPlayerMark:'x');
    // start the game by calling .Play() method.
      game.Play();
   }
}
//*** Do NOT change code in this class***
