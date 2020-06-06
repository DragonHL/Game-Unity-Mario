using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class playerWin : MonoBehaviour
{
    Animator myAnim;
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }


    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {


            myAnim.SetBool("flagUp", true);
            myAnim.Play("flag_pole_up");


            StartCoroutine("Wait1second");

        }
    }

    IEnumerator Wait1second()
    {

        yield return new WaitForSeconds(0.1f);// giống như delay 

        Time.timeScale = 0;
        SceneManager.LoadScene("WinGame", LoadSceneMode.Single);
        
    }

}
