using UnityEngine;
using System.Collections.Generic;

public enum MazeCellGenerationState
{
    Untouched,
    Current,
    Completed,
    StartOfMaze,
    EndOfMaze,
    Solution
}

public class MazeCell : MonoBehaviour
{
    [Tooltip("0 = right, 1 = left, 2 = top, 3 = bottom")]
    public GameObject[] walls = new GameObject[4]; //0 = right, 1 = left, 2 = top, 3 = bottom
    public SpriteRenderer floor; //changes color based on MazeCellGenerationState

    private MazeCellGenerationState myState;

    //Colors of maze floor for different States
    public Color colorUntouched;
    public Color colorCurrent;
    public Color colorCompleted;
    public Color colorStartOfMaze;
    public Color colorEndOfMaze;
    public Color colorOfSolutionPath;

    //Solution variables (used when solving the maze)
    private MazeCell parentOfThisCell;

    public void RemoveWall(int indexOfWallToRemove)
    {
        walls[indexOfWallToRemove].SetActive(false);
    }

    public void SetState(MazeCellGenerationState state)
    {
        myState = state;

        switch (state)
        {
            case MazeCellGenerationState.Untouched:
                floor.material.color = colorUntouched;
                break;
            case MazeCellGenerationState.Current:
                floor.material.color = colorCurrent;
                break;
            case MazeCellGenerationState.Completed:
                floor.material.color = colorCompleted;
                break;
            case MazeCellGenerationState.StartOfMaze:
                floor.material.color = colorStartOfMaze;
                break;
            case MazeCellGenerationState.EndOfMaze:
                floor.material.color = colorEndOfMaze;
                break;
            case MazeCellGenerationState.Solution:
                floor.material.color = colorOfSolutionPath;
                break;
        }
    }

    public MazeCellGenerationState GetState()
    {
        return myState;
    }

    public void SetParent(MazeCell newParent)
    {
        parentOfThisCell = newParent;
    }

    public MazeCell GetParent()
    {
        return parentOfThisCell;
    }
}
