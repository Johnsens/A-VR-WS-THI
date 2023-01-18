using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIHeaderScript : MonoBehaviour

{
    [SerializeField] 
    private TextMeshProUGUI title;

    public GameObject popUp;

    
    void update()
    {
        if(popUp.activeSelf == true){
                title.text = GlobalVariables.plantCounter.ToString() + "/5 Plants found!";
                Debug.Log(title.text + "gets shown in UI");}
        }
    }



    






