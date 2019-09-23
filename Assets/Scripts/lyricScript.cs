using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lyricScript : MonoBehaviour
{
    Camera cam;
    GameObject lyricObject;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        lyricObject = (GameObject)Resources.Load("Prefabs/Lyric");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Putlyric(string lyricText)
    {
        Vector3 position = cam.transform.position + cam.transform.forward * 1.5f;
        lyricObject.GetComponent<TextMesh>().text = lyricText;
        lyricObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        Instantiate(lyricObject, position, cam.transform.rotation);
    }
}
