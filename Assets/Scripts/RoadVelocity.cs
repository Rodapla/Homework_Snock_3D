using UnityEngine;

public class RoadVelocity : MonoBehaviour
{
    public Vector3 Velocity;
    public Rigidbody Rigidbody;

    private void Start()
    {
        Rigidbody.velocity = Velocity;
    }
}
