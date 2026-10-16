using UnityEngine;

public class SunRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    public float rotationSpeed = 8f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,-rotationSpeed * Time.deltaTime, 0);
    }
}
