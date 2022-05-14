using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterCollision : MonoBehaviour
{
    private readonly string LAVA_GAME_OBJECT_NAME = "Lava";

    private readonly Vector3 RESPAWN_POSITION = new Vector3(3.696f, 4.58f, 8.172f);

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name.Equals(LAVA_GAME_OBJECT_NAME)) {
            Debug.Log("Player fell into lava. Respawning...");
            gameObject.transform.position = RESPAWN_POSITION;
            Physics.SyncTransforms();
        }
    }
}
