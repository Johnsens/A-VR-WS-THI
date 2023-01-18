using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIHeaderScript : MonoBehaviour

{
    [SerializeField] 
    private TextMeshProUGUI title;

    int counter = 10;

    
    void update()
    {
        if(counter <= 10) {
            counter = counter - 1;
            title.text = GlobalVariables.plantCounter.ToString() + "/5 Plants found!";
            Debug.Log(title.text + "Is the plant counter");
        }
    }
}





