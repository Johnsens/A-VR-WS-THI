using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    //public static SceneManager Instance(
    //    
    //);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame() {
        SceneManager.LoadScene("ForestBiome");
    }

    public void EndGame() {
        SceneManager.LoadScene("StartScene");
    }

    public void ExitGame() {
        Application.Quit();
    }
}
