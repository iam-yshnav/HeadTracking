using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTracking : MonoBehaviour
{
    public UDPReceive uDPReceive;
    public GameObject cameraObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = uDPReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length-1, 1);
        
        string[] points = data.Split(',');

        print(points[0]);

        float x = (float.Parse(points[0])-320) / 100;
        float y = float.Parse(points[1]) / 100;

        Vector3 cameraPos = cameraObject.transform.localPosition;
    
       
       
        cameraObject.transform.localPosition = new Vector3(-17.47f-x, cameraPos.y ,cameraPos.z);
        
        
        
    }
}
