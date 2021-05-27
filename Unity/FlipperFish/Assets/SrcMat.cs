using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrcMat : MonoBehaviour
{

    [SerializeField]
    [Range(0f, 5f)]
    float speed = 1f;

    private Vector2 offset = Vector2.zero;
    private Renderer renderer;

    private void Start()
    {
        renderer = transform.GetComponent<Renderer>();
    }


    void Update()
    {

        offset = new Vector2(Time.deltaTime * speed,0);

        if (renderer != null)
            transform.GetComponent<Renderer>().material.mainTextureOffset = offset;

    }
}
