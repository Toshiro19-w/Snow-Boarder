using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 0.25f;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] AudioClip crashSound;
    bool hasCrashed = false;

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground" && !hasCrashed){
            hasCrashed = true;
            GetComponent<PlayerController>().DisableControls();
            crashParticles.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("reloadScene", reloadDelay);
            Debug.Log("You Crashed!");
        }
    }
    void reloadScene(){
        SceneManager.LoadScene(0);
    }
}
