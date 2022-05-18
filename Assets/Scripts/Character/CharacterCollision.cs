using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterCollision : MonoBehaviour
{

    private readonly string LAVA_GAME_OBJECT_NAME = "Lava";
    private readonly string PROJECTILE_GAME_OBJECT_NAME = "Projectile";

    private readonly Vector3 RESPAWN_POSITION = new Vector3(3.696f, 4.58f, 8.172f);

    private readonly int MAX_CHARACTER_HEALTH = 100;
    private readonly int PROJECTILE_DAMAGE = 20;

    private int _currentCharacterHealth;

    private void Start()
    {
        _currentCharacterHealth = MAX_CHARACTER_HEALTH;
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        GameObject gameObject = collision.gameObject;

        if (gameObject.name.Equals(LAVA_GAME_OBJECT_NAME)) {
            Debug.Log("Character fell into lava. Respawning...");
            Respawn();
        }
        else if (gameObject.tag.Equals(PROJECTILE_GAME_OBJECT_NAME))
        {
            Debug.Log("Character has been hit by a turret projectile.");
            _currentCharacterHealth -= PROJECTILE_DAMAGE;

            if (_currentCharacterHealth <= 0)
            {
                Debug.Log("Character has sustained maximum amount of damage. Respawning...");
                Respawn();
            }
        }
    }

    private void Respawn()
    {
        _currentCharacterHealth = MAX_CHARACTER_HEALTH;
        transform.position = RESPAWN_POSITION;
        Physics.SyncTransforms();
    }
}
