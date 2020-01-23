using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Dropdown dropMenu;
    public GameObject printText;
    public int s;

    public void showSpeed(){
        int index = dropMenu.GetComponent<Dropdown>().value;

        //dawrf:
        if(index == 2) {
            s = 25;
        }
        
        //gnome:
        else if(index == 4){
            s = 25;
        }

        //halfling:
        else if(index == 7){
            s = 25;
        }

        //everything else:
        else{
            s = 30;
        }

    printText.GetComponent<Text>().text = "" + s;
    }
        
    }
