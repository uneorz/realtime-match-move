using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    Camera cam;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        cube = (GameObject)Resources.Load("Prefabs/Cube");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PutCube()
    {
        // Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 position = cam.transform.position + cam.transform.forward;
        Instantiate(cube, position, Quaternion.identity);
    }
}
