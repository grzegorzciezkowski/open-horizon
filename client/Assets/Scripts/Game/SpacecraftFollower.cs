using UnityEngine;

public class SpacecraftFollower : MonoBehaviour
{
    public GameObject spacecraft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = spacecraft.transform.position;
    }
}
