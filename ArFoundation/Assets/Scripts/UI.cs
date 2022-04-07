using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadARWall()
    {
        SceneManager.LoadScene("ARWall", LoadSceneMode.Single);
    }

    public void LoadARFloor()
    {
        SceneManager.LoadScene("ARFloor", LoadSceneMode.Single);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("UI", LoadSceneMode.Single);
    }
}
