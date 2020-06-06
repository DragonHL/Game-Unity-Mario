using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill_duck : MonoBehaviour
{

    public killSounds sounds;
    // Start is called before the first frame update
    void Start()
    {
        sounds = GameObject.FindGameObjectWithTag("sound").GetComponent<killSounds>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "duck_bottom")
        {
            sounds.Playsound("soundPlayer");
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene("EndGame", LoadSceneMode.Single);
        }
        else if (collision.gameObject.tag == "duck_top")
        {

            if (GameObject.Find("duck_bird"))
            {
                sounds.Playsound("soundmushroom");
                Destroy(GameObject.Find("duck_bird"));

            }

        }

    }
}
