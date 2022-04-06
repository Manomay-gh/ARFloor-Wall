using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{

    public GameObject tutPanel;
    public GameObject helpButton;


    // Start is called before the first frame update
    void Start()
    {
        tutPanel.SetActive(true);
        helpButton.SetActive(false);
        StartCoroutine(DisableTut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisableTut()
    {
        yield return new WaitForSeconds(5);
        tutPanel.SetActive(false);
        helpButton.SetActive(true);
    }

    public void HelpButtonPressed()
    {
        helpButton.SetActive(false);
        tutPanel.SetActive(true);
        StartCoroutine(DisableTut());

    }
}
