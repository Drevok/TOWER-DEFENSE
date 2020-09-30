using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TURRETS : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]
    public float fireRate = 1f;
    private float fireCountDown = 0f;
    public float range =10f;
    public int damageNumber = 10;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";
    public Transform partToRotate;
    public float turnSpeed = 10f;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.2f);
    }

    void UpdateTarget ()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountDown <= 0f)
        {
            Shoot();
            fireCountDown = 1f / fireRate;

            
        }
        fireCountDown -= Time.deltaTime;
    }

    void Shoot()
    {
        Debug.Log("Pew");
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
