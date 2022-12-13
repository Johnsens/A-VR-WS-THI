using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigPosition : MonoBehaviour
{
    public Transform XRRigPosition;


    void Start()
    {
        //XRRigPosition.transform.position = new Vector3(Random.Range(-6, 6), 0.1f, Random.Range(-6, 6));
        //Fixed position for the start for XRRig
        XRRigPosition.transform.position = new Vector3(Random.Range(230,232), 38, Random.Range(93,94));

    }

}
