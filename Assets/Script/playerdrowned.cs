using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdrowned : MonoBehaviour
{
    killSounds sounds;

    // Start is called before the first frame update
    void Start()
    {

        sounds = GameObject.FindGameObjectWithTag("sound").GetComponent<killSounds>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            sounds.Playsound("soundPlayerDrowned");
          //  Destroy(GameObject.FindWithTag("Player"));
          //  SceneManager.LoadScene("EndGame", LoadSceneMode.Single);

            StartCoroutine("Wait1second");
        }
    }


    IEnumerator Wait1second()
    {

        yield return new WaitForSeconds(0.8f);// giống như delay 1s 

        Destroy(GameObject.FindWithTag("Player"));
        SceneManager.LoadScene("EndGame", LoadSceneMode.Single);

    }
}
