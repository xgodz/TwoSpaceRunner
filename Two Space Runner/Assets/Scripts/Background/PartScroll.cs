using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartScroll : MonoBehaviour
{
    public float speed2;
    Vector3 startPos2                               ;
    // Use this for initialization
    void Start()
    {
        startPos2 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((new Vector3(-1, 0, 0)) * speed2 * Time.deltaTime);
        if (transform.position.x < 1916)
            transform.position = startPos2;

    }
}
