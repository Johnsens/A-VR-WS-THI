using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using menu = GameMenuManager;





public class Inventory : MonoBehaviour
{

    public int plantCount = 0;

    public GameObject firstPlant;

    public GameObject secondPlant;

    public GameObject ThirdPlant;

    public GameObject EndOverlay;

    public GameObject[] plantsList;

    public Transform XRRigPosition;
    public float spawnDistance = 2;

    void Start()
    {

    }

    void Update()
    {
        if (plantsList.Length == 2)
        {
            showEndPopUp();
        }

    }

    public void pickupPlant()
    {
        firstPlant.SetActive(!firstPlant.activeSelf);
        //plantsList.add(plant);

    }


    void showEndPopUp()
    {
        EndOverlay.SetActive(!EndOverlay.activeSelf);
        EndOverlay.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        EndOverlay.transform.LookAt(new Vector3(XRRigPosition.position.x, EndOverlay.transform.position.y, XRRigPosition.position.z));
        //flipping the menu around, as it was backwards
        EndOverlay.transform.forward *= -1;
    }
}

