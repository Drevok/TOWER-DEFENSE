using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TURRETS : MonoBehaviour
{
    public Transform target;
    public float range = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
