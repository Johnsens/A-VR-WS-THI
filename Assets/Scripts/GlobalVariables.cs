using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GlobalVariables : MonoBehaviour
{

    public static int plantCounter;
    public static int poisonPlantCounter;


    //Unused variables
/* 
    public GameObject levelfinishedPopUp;

    public Transform XRRigPosition;

    private float spawnDistance = 2;

    private bool stopUpdate = false; */



    // Start is called before the first frame update
    void Start()
    {       
        plantCounter = 0;
        poisonPlantCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {        
    }
}
