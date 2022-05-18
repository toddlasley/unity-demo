using UnityEngine;

public class CharacterTracking : MonoBehaviour
{
    private GameObject character;

    private void Awake()
    {
        character = GameObject.Find("Character");

        if (character == null)
        {
            throw new MissingReferenceException("Character could not be found for tracking.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(character.transform);

    }

}
