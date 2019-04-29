using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScroll : MonoBehaviour
{
    public float speed1;
    Vector3 startPos1;
    // Use this for initialization
    void Start()
    {
        startPos1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((new Vector3(-1, 0, 0)) * speed1 * Time.deltaTime);
        if (transform.position.x < 1921)
            transform.position = startPos1;

    }
}
