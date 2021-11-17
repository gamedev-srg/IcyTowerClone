using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float offsetx;
    [SerializeField]float offsety;
    private GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(cam.transform.position.x+offsetx,cam.transform.position.y+offsety,cam.transform.position.z);
        
    }
}
