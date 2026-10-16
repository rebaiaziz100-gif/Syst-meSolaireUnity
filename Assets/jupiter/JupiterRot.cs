using UnityEngine;

public class JupiterRot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float orbitSpeed = 12f;

    public float rotationSpeed = 50f;

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
