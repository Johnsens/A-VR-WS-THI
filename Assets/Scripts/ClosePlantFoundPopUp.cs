using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePlantFoundPopUp : MonoBehaviour
{

    public GameObject plantPopUp;
    private float spawnDistance = 2;

    public GameObject fireworks;

    private bool stopUpdate = false;

    public GameObject levelfinishedPopUp;

    public Transform XRRigPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closePlantFoundPopUp() {
        if (GlobalVariables.plantCounter <= 4) {
            plantPopUp.SetActive(!plantPopUp.activeSelf);
            Debug.Log("Pop up closed: " + GlobalVariables.plantCounter);
        }
        else {
            plantPopUp.SetActive(!plantPopUp.activeSelf);
            fireworks.SetActive(!fireworks.activeSelf);
            fireworks.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, XRRigPosition.forward.y + 30, XRRigPosition.forward.z).normalized;
            fireworks.GetComponent<Rigidbody>().AddForce (Vector3.up * 15000);
            levelfinishedPopUp.SetActive(!levelfinishedPopUp.activeSelf);
            levelfinishedPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x -5, 30,XRRigPosition.forward.z + 15).normalized * spawnDistance;
            Debug.Log(levelfinishedPopUp.transform.position);
            Debug.Log("EndConditionMet");
            levelfinishedPopUp.transform.LookAt(new Vector3 (XRRigPosition.position.x, levelfinishedPopUp.transform.position.y, XRRigPosition.position.z));
            Debug.Log(levelfinishedPopUp.transform.position);
            levelfinishedPopUp.transform.forward *= -1;
        }
    }
}
