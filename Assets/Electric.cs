using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electric : MonoBehaviour
{
    public Transform rightHand;
    public Transform leftHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(rightHand.position, leftHand.position);


        transform.localScale = new Vector3(0.1f, 0.1f, distance);
        transform.position = (rightHand.position + leftHand.position) / 2;
        transform.LookAt(leftHand);
    }
}
