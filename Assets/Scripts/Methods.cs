using UnityEngine;

public class Methods : MonoBehaviour
{
    public void Print2DArray<T>(T[,] matrix)
    {
        string text = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                text += matrix[i, j] + "\t";
            }

            text += "\n";
        }

        Debug.Log(text);
    }
}
