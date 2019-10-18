using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    private GameObject target;
    public Vector3 Offset;
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 200)
        transform.position = new Vector3(target.transform.position.x,0,target.transform.position.z) + Offset;
    }
}
