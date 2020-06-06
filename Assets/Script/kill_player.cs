using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class kill_player : MonoBehaviour
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

        if (collision.gameObject.tag == "kill_middle_mushroom" || collision.gameObject.tag == "kill_middle_mushroom1"
            || collision.gameObject.tag == "kill_middle_mushroom2" || collision.gameObject.tag == "kill_middle_mushroom3")
        {

            sounds.Playsound("soundPlayer");
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene("EndGame", LoadSceneMode.Single);
        }
        else if (collision.gameObject.tag == "kill_top_mushroom")
        {

            sounds.Playsound("soundmushroom");
            Destroy(GameObject.Find("Mushroom"));

        }

        else if (collision.gameObject.tag == "kill_top_mushroom1")
        {
            sounds.Playsound("soundmushroom");
            Destroy(GameObject.Find("Mushroom1"));

        }
        else if (collision.gameObject.tag == "kill_top_mushroom2")
        {
            sounds.Playsound("soundmushroom");
            Destroy(GameObject.Find("Mushroom2"));

        }
        else if (collision.gameObject.tag == "kill_top_mushroom3")
        {
            sounds.Playsound("soundmushroom");
            Destroy(GameObject.Find("Mushroom3"));

        }


    }



}













