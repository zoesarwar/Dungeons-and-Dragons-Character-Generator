using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusTwoDefault : MonoBehaviour
{
    public GameObject textField;

    public void printPlusTwo(){
        textField.GetComponent<Text>().text = "" + "+2";
    }
        
    }