using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
public class TextureSelect : MonoBehaviour
{

    public ARPlaneManager aRPlaneManager;
    public Button[] buttons;
    public Material[] floorMaterials;


    //public List<Renderer> renderers = new List<Renderer>();
    public GameObject[] planeobjs;

    public int buttonNo=0;

    // Start is called before the first frame update
    void Start()
    {
       foreach(Button button in buttons)
        {
            button.onClick.AddListener(delegate { buttonpressed(button); });
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        planeobjs = GameObject.FindGameObjectsWithTag("ARPlanePrefab");

       // foreach(GameObject obj in planeobjs)
       // {
       //     if(!renderers.Contains(obj.GetComponent<Renderer>()))
       //     renderers.Add(obj.GetComponent<Renderer>());
       // }

        foreach(ARPlane plane in aRPlaneManager.trackables)
        {
            plane.gameObject.GetComponent<MeshRenderer>().material = floorMaterials[buttonNo];
        }
        
    }

    void buttonpressed(Button button)
    {
        
            buttonNo = int.Parse(button.gameObject.name);
        
    }
}
