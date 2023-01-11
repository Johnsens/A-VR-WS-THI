using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GlobalVariables : MonoBehaviour
{

    public static int plantCounter;
    public static int poisonPlantCounter;

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
      /*   if(blueberry.SetActive(false) && blueberryfound = false){
            counter = counter + 1;
        }
        if (counter == 5)
            {
                levelfinishedPopUp.SetActive(!levelfinishedPopUp.activeSelf);
                levelfinishedPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x,0,XRRigPosition.forward.z).normalized * spawnDistance;
                Debug.Log(plantPopUp.transform.position);
                Debug.Log("EndConditionMet");
                levelfinishedPopUp.transform.LookAt(new Vector3 (XRRigPosition.position.x, levelfinishedPopUp.transform.position.y, XRRigPosition.position.z));
                Debug.Log(plantPopUp.transform.position);
                levelfinishedPopUp.transform.forward *= -1;
                Debug.Log("EndConditionMet");
            } */
            
    }
}
