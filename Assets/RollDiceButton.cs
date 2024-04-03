using System;
using UnityEngine;

public class RollDiceButton : MonoBehaviour
{
    private int[] arr={3,9,4,0,10};
    private int[] bucket={0,0,0,0,0};
    private void Start()
    {
        // int longOfArr = arr.Length;
        // for (int i = 0; i < longOfArr; i++)
        // {
        //     for (int j = i+1; j < longOfArr; j++)
        //     {
        //         if (arr[i] > arr[j])
        //         {
        //             var temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }
        // }
        // foreach (var VARIABLE in arr)
        // {
        //     print(VARIABLE);
        // }
        foreach (var VARIABLE in arr)
        {
            bucket[VARIABLE]++;
        }

        for (int i = 0; i < bucket.Length; i++)
        {
            if (bucket[i] > 0)
            {
                print(i);
                bucket[i]--;
            }
        }
    }
}
