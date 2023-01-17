using UnityEngine;

public class DestroyObjectOnCollide : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        other.GetComponent<CarMovement>().engineForce += 500f;
    }
}