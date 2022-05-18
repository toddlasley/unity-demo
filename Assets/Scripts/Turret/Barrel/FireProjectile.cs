using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{

    public Rigidbody projectilePrefab;
    public float fireTimeInterval;

    private float timeSinceLastFire;

    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastFire = fireTimeInterval;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeSinceLastFire >= fireTimeInterval)
        {
            Rigidbody clone;
            clone = Instantiate(projectilePrefab, transform, false);
            clone.velocity = transform.parent.transform.parent.forward * 10;
            timeSinceLastFire = 0.0f;
        }
        else
        {
            timeSinceLastFire += Time.deltaTime;
        }
        
    
        
    }
}
