using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    void OnCollisionEnter2D(Collision2D other) {
        dustParticles.Play();
    }
    void OnCollisionExit2D(Collision2D other) {
        dustParticles.Stop();
    }
}
