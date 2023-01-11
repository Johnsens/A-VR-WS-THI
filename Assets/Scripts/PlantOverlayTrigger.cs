using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GrabberPool = HTC.UnityPlugin.Utility.ObjectPool<Draggable.Grabber>;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlantOverlayTrigger : MonoBehaviour
{

    public GameObject plantPopUp;
    public GameObject plant;
    public GameObject levelfinishedPopUp;
    public Transform XRRigPosition;
    public float spawnDistance = 2;
    //This counter would be for different plants of the same type
    //public int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (counter == 1)
        //{
/*             levelfinishedPopUp.SetActive(!levelfinishedPopUp.activeSelf);
            levelfinishedPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x,0,XRRigPosition.forward.z).normalized * spawnDistance;
            Debug.Log(plantPopUp.transform.position);
            Debug.Log("EndConditionMet");
            levelfinishedPopUp.transform.LookAt(new Vector3 (XRRigPosition.position.x, levelfinishedPopUp.transform.position.y, XRRigPosition.position.z));
            Debug.Log(plantPopUp.transform.position);
            levelfinishedPopUp.transform.forward *= -1;
            Debug.Log("EndConditionMet"); */
        //}
    }


    public void plantShown() {
                plantPopUp.SetActive(!plantPopUp.activeSelf);
                Debug.Log("Plant pop up shown");
                //plantPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x,0,XRRigPosition.forward.z).normalized * spawnDistance;
                //Debug.Log(plantPopUp.transform.position);
                //plantPopUp.transform.LookAt(new Vector3 (XRRigPosition.position.x, plantPopUp.transform.position.y, XRRigPosition.position.z));
                //Debug.Log(plantPopUp.transform.position);
                //plantPopUp.transform.forward *= -1;
                //Debug.Log(plantPopUp.transform.position);

                plant.SetActive(!plant.activeSelf);
                Debug.Log("Plant disappeared");
                //This counter would be for different plants of the same type
                countPlants();
    }


    public void countPlants() {
        GlobalVariables.plantCounter = GlobalVariables.plantCounter + 1;
        Debug.Log("The PlantCounter is " + GlobalVariables.plantCounter);
        if (plant.CompareTag("Poisonous")){
            GlobalVariables.poisonPlantCounter = GlobalVariables.poisonPlantCounter +1;
            Debug.Log("The PoisonousPlantCounter is " + GlobalVariables.poisonPlantCounter);
        }

    }

}
