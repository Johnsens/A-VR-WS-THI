using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GlobalVariables : MonoBehaviour
{

    public static int plantCounter;
    public static int poisonPlantCounter;

    public GameObject levelfinishedPopUp;

    public Transform XRRigPosition;

    private float spawnDistance = 2;

    private bool stopUpdate = false;



    //public GameObjects[] plants = plant.FindGameObjectsWithTag("Plant");


    // Start is called before the first frame update
    void Start()
    {       
        plantCounter = 0;
        poisonPlantCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (plantCounter == 3 && stopUpdate == false)
            {
                stopUpdate = true;
                levelfinishedPopUp.SetActive(!levelfinishedPopUp.activeSelf);
                levelfinishedPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x -10, 20 ,XRRigPosition.forward.z + 15).normalized * spawnDistance;
                Debug.Log(levelfinishedPopUp.transform.position);
                Debug.Log("EndConditionMet");
                levelfinishedPopUp.transform.LookAt(new Vector3 (XRRigPosition.position.x, levelfinishedPopUp.transform.position.y, XRRigPosition.position.z));
                Debug.Log(levelfinishedPopUp.transform.position);
                levelfinishedPopUp.transform.forward *= -1;
                levelfinishedPopUp.transform.Rotate(0,-45.0f,0.0f);
            } 
            
    }
}
