using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winCondition : MonoBehaviour
{
    [SerializeField] float winDelay =2f;
    [SerializeField] ParticleSystem partical;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            Debug.Log("gg");
            partical.Play();
            Invoke("Win", winDelay);
        }
    }
    void Win(){
        SceneManager.LoadScene(0);
    }
}

