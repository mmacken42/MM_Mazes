# MM_Mazes

A simple maze generator/solver made in Unity/C# for practice. 

Maze generation: It uses the randomized Depth-first Search algorithm (a.k.a. recursive backtracking). The maze generation is deliberately slowed down inside a coroutine so you can see how the algorithm works. The color orange is used to indicate a cell that's been visited once. The color blue is used to indicate a cell that is complete and will not be visited again. 

Maze solving: It uses Breadth-first Search algorithm to find the shortest path through the maze. Start of every maze is lower left and end of every maze is upper right. 

Extra features: Inside Unity, the script supports mazes of any size and the camera will automatically reposition itself based on maze size (the web build uses a fixed 18x18 maze size). Also in Unity editor, users can choose to forgo the animation and simply have the maze generated/solved instantly, but I think it looks cool slowed down.

Try the web build at https://mmacken42.github.io/MM_Mazes/
