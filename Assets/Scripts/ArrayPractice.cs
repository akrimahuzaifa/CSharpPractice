using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ArrayPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintArray()
    {
        int[] arr = new int[10];
        int i;


        Debug.Log("Input 10 elements in the array :\n");
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
            Debug.Log("element - {0} : "+ i);
        }

        Debug.Log("\nElements in array are: ");
        for (i = 0; i < 10; i++)
        {
            Debug.Log("{0}  "+ arr[i]);
        }
        Debug.Log("\n");
    }

    public void Question2()
    {
        int[] sumArray = new int[10];
        int sumOfAllElements = 0;

        foreach(int i in Enumerable.Range(0,10))
        {
            sumArray[i] = i;
        }
        foreach(int i in sumArray)
        {
            sumOfAllElements += i; 
        }
        Debug.Log(sumOfAllElements);

    }
    public void Question3()
    {
        int[] sumArray = new int[10];
        

        foreach (int i in Enumerable.Range(1, 10))
        {
            sumArray[i-1] = i;
        }
        for(int i=0; i<sumArray.Length; i++)
        {
            Debug.Log(sumArray[i]);
            
        }
        Debug.Log("-----------------");
        for (int i = sumArray.Length-1; i>=0; i--)
        {
            Debug.Log(sumArray[i]);
        }
    }

    public void Question4()
    {
        int[] array = new int[] { 1, 2, 2, 3, 0, 0, 0, 4, 5, 6, 7, 8, 7, 9 };
        List<int> duplicateHolder = new List<int>();
        //int[] duplicateHolder = new int[100];

        for (int x = 0; x< array.Length; x++)
        {
            for (int y = 0; y<array.Length; y++)
            {
                if(x != y)
                {
                    if (array[x] == array[y])
                    {
                        //for (int z = 0; z < duplicateHolder.Count; z++) ;
                        duplicateHolder.Add(array[x]);
                    }
                }
                
            }
        }
        foreach(int i in duplicateHolder)
        {
            Debug.Log(i);
        }
        
    }

    public void Question6()
    {
        int[] array = new int[] { 1, 2, 2, 1, 3, 0, 0, 3, 4, 5, 4, 6, 7, 8, 7, 8, 9 };
        List<int> duplicateHolder = new List<int>();
        List<int> uniqueHolder = new List<int>();

        for (int x = 0; x < array.Length; x++)
        {
            for (int y = 0; y < array.Length; y++)
            {
                if (x != y)
                {
                    if (array[x] == array[y])
                    {
                        duplicateHolder.Add(array[x]);
                    }
                    else
                    {
                        uniqueHolder.Add(array[x]);
                        //continue;
                        
                    }

                }

            }
        }
        foreach (int i in uniqueHolder)
        {
            Debug.Log(i);
        }

    }

}
