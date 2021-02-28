using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascript : MonoBehaviour
{
    public Transform target;
    public float minHeight, maxHeight;
    public Transform farBg, midBg;
    private float lastXPos;
    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float amountToMoveX = transform.position.x - lastXPos;
        farBg.position = farBg.position + new Vector3(amountToMoveX, 0f, 0f);
        midBg.position = midBg.position + new Vector3(amountToMoveX * 0.5f, 0f, 0f);
        lastXPos = transform.position.x;



        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y,minHeight,maxHeight), transform.position.z);
    }
}
