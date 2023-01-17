using UnityEngine;

public class DestroyObjectOnCollide : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}