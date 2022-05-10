using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterCollision : MonoBehaviour
{
    private readonly string LAVA_GAME_OBJECT_NAME = "Lava";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name.Equals(LAVA_GAME_OBJECT_NAME)) {
            Debug.Log("You dead");
        }
    }
}
