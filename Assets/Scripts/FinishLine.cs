using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 0.75f;
    [SerializeField] ParticleSystem finishParticles;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
            finishParticles.Play();
            GetComponent<AudioSource>().Play();
            Invoke("reloadScene", reloadDelay);
            Debug.Log("You Finished!");
        }
    }
    void reloadScene(){
        SceneManager.LoadScene(0);
    }
}
