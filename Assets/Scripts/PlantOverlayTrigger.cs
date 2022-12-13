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
    public Transform XRRigPosition;
    public float spawnDistance = 2;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
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

                Debug.Log("Plant pop up shown");
                plant.SetActive(!plant.activeSelf);
                Debug.Log("Plant disappeared");
    }
}
