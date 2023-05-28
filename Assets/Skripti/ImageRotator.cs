using UnityEngine;

public class ImageRotator : MonoBehaviour
{
	public float rotationSpeed = 100f; // rotācijas ātrums

	private void Update()
	{
		transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
		transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
	}
}
