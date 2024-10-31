using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    void Start()
    {
        int answer;
        for ( int i=1 ; i<= 10 ; i++){
        answer = Multiply5(i,5);
        Debug.Log("|" + i +" × 5 =" +answer + "|");
        }
    }

    int Multiply5(int first, int second){

        return first*second;

    }
}
