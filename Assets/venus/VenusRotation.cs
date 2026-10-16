using UnityEngine;

public class VenusRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float orbitSpeed = 35f;

    public float rotationSpeed = -3f;
    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(
                    transform.parent.position,
                    Vector3.up,
                    -orbitSpeed * Time.deltaTime
                );

        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
