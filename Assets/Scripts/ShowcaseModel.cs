using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseModel : MonoBehaviour
{
  public float minRotationSpeed = 20f;
    public float maxRotationSpeed = 40f;
    public float swayAmount = 0.1f;
    public float swayRotationAmount = 1f;

    private float rotationSpeed;

    void Start()
    {
        // Initialize rotation speed with a random value between min and max
        rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
    }

    void Update()
    {
        // Rotate the GameObject around the y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Add subtle sways to the rotation
        float swayX = Mathf.Sin(Time.time) * swayAmount;
        float swayY = Mathf.Cos(Time.time) * swayAmount;
        float swayRotationX = Mathf.Sin(Time.time) * swayRotationAmount;

        // Apply rotations and translation
        transform.Translate(new Vector3(swayX, swayY, 0) * Time.deltaTime);
        transform.Rotate(new Vector3(swayRotationX, 0, 0) * Time.deltaTime);
    }
}
