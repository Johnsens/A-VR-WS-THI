using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{

    //menu is Canvas
    public GameObject menu;
    public InputActionProperty showButton;

    //variables needed to keep Menu in front of player
    public Transform head;
    public float spawnDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Activating Menu
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

            //Defining a Vector to place the menu in front of player by using the normalized vector and manipulating the x and z axis
            menu.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
        }

        //Making Sure menu is always facing the player by manipulting the y axis
        menu.transform.LookAt(new Vector3 (head.position.x, menu.transform.position.y, head.position.z));
        //flipping the menu around, as it was backwards
        menu.transform.forward *= -1;
    }
}
