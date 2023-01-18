using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Photon.Pun;
using TMPro;

public class PlantOverlayTrigger : MonoBehaviour
{
    public SendSomeOneFoundAllPlants sendSomeOneFoundAllPlants;
    public GameObject plantPopUp;
    public GameObject plant;
    public GameObject levelfinishedPopUp;
    public Transform XRRigPosition;
    public float spawnDistance = 2;
    public int maxPlantCounter = 5;

    public TextMeshProUGUI title;
    //This counter would be for different plants of the same type
    //public int counter = 0;


    // Start is called before the first frame update
    void Start()
    {      
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void Ifinished(){
        Debug.Log("I finished!");
            sendSomeOneFoundAllPlants.IfoundAllPlants();
            //do other stuff for this player
    }


    public void plantShown() {
                countPlants();
                title.text = GlobalVariables.plantCounter.ToString() + "/5 Plants found!";
                Debug.Log(title.text + "gets shown in UI");
                plantPopUp.SetActive(!plantPopUp.activeSelf);
                Debug.Log("Plant pop up shown");
                plant.SetActive(!plant.activeSelf);
                Debug.Log("Plant disappeared");
    }

    //Counts the plants and every plant given a special tag
    public void countPlants() {
        GlobalVariables.plantCounter = GlobalVariables.plantCounter + 1;
        Debug.Log("The PlantCounter is " + GlobalVariables.plantCounter);

        if(GlobalVariables.plantCounter == maxPlantCounter){
        Debug.Log("im plant counter");
            Ifinished();
            }
        if (plant.CompareTag("Poisonous")){
            GlobalVariables.poisonPlantCounter = GlobalVariables.poisonPlantCounter +1;
            Debug.Log("The PoisonousPlantCounter is " + GlobalVariables.poisonPlantCounter);
        }

    }

}
