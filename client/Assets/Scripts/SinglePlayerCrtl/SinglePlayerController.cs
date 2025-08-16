using UnityEngine;

public class SinglePlayerController : MonoBehaviour
{
    public GameObject Vessel;

    private Spacecraft mSpacecraft;

    void Start()
    {
        mSpacecraft = Vessel.GetComponent<Spacecraft>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            mSpacecraft.Accelerate();
        } else if(Input.GetKey(KeyCode.DownArrow))
        {
            mSpacecraft.Decelerate();
        }

        if(Input.GetKey(KeyCode.A))
        {
            mSpacecraft.TurnLeft();
        } else if( Input.GetKey(KeyCode.D))
        {
            mSpacecraft.TurnRight();
        }

        if(Input.GetKey(KeyCode.S))
        {
            mSpacecraft.PullUp();
        } else if(Input.GetKey(KeyCode.W))
        {
            mSpacecraft.PullDown();
        }
    }
}
