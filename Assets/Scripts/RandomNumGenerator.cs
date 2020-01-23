using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumGenerator : MonoBehaviour
{
    public GameObject TextBox;
    public int Number;
    public int SecondNumber;
    public int Sum;
    ArrayList NumberList = new ArrayList();

    public void RandomNumGen(){

        for(int x = 0; x < 5; x++){
            Number = Random.Range(1,7);
            NumberList.Add(Number);
        }
        
        NumberList.Sort();
        NumberList.Reverse();
        NumberList.RemoveAt(4);
        NumberList.RemoveAt(3);

        foreach(int n in NumberList){
            Sum = Sum + n;
        }

        TextBox.GetComponent<Text> ().text = "" + Sum;
        NumberList.Clear();
        Sum = 0;

    }
}
