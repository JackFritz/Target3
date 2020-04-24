using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{

    //Code found from Unity Thread
    public float min = 1f;
    public float max = 8f;

    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.y;
        max = transform.position.y + 8;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 1, max - min) + min, transform.position.z);
    }
}
