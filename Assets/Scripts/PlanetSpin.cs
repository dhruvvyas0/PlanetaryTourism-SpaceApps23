using UnityEngine;

public class PlanetSpin : MonoBehaviour
{
    public float rotationSpeed = 7f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed*Time.deltaTime);
    }
}