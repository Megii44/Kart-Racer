using UnityEngine;

public class TurboBoost : MonoBehaviour
{
    public float speedMultiplier = 2.0f;
    public float boostDuration = 10.0f;

    private float originalSpeed;
    private float boostTimer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Turbo"))
        {
            originalSpeed = GetComponent<Rigidbody>().velocity.magnitude;
            boostTimer = boostDuration;

            GetComponent<Rigidbody>().velocity *= speedMultiplier;
        }
    }

    private void Update()
    {
        if (boostTimer > 0)
        {
            boostTimer -= Time.deltaTime;
        }
        else
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * originalSpeed;
        }
    }
}