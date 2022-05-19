using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTimeToLive : MonoBehaviour
{
    private readonly float TIME_TO_LIVE = 30.0f;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, TIME_TO_LIVE);
    }
}
