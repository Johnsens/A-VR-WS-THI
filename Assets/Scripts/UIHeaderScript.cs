using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHeaderScript : MonoBehaviour

{
    [SerializeField] 
    private TextMeshProUGUI title;

    
    void Update()
    {
        title.text = GlobalVariables.plantCounter + "/5 Plants found!";
        Debug.Log(title.text);
    }
}





