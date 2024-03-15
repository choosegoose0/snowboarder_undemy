using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bonk : MonoBehaviour
{
    [SerializeField] float failDelay=2f;
    [SerializeField] ParticleSystem partical;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Ground"){
            Debug.Log("bonk");
            partical.Play();
            Invoke("Bonk",failDelay);
        }
    }
    void Bonk(){
        SceneManager.LoadScene(0);
    }
}
