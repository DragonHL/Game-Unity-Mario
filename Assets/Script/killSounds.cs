using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killSounds : MonoBehaviour
{

    public AudioClip mushRoom;
    public AudioClip player;
    public AudioClip playerD;
    public AudioClip marioJump;


    public AudioSource adisrc;
    // Start is called before the first frame update
    void Start()
    {
        mushRoom = Resources.Load<AudioClip>("Sounds/killMushRoom");
        player = Resources.Load<AudioClip>("Sounds/Kick");
        playerD = Resources.Load<AudioClip>("Sounds/Punch");
        marioJump = Resources.Load<AudioClip>("Sounds/MarioJump");
        adisrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Playsound(string clip)
    {
        switch (clip)
        {
            case "soundmushroom":
                adisrc.clip = mushRoom;
                adisrc.PlayOneShot(mushRoom, 1f);
                break;

            case "soundPlayer":
                adisrc.clip = player;
                adisrc.PlayOneShot(player, 1f);
                break;

            case "soundPlayerDrowned":
                adisrc.clip = playerD;
                adisrc.PlayOneShot(playerD, 1f);
                break;
            
            case "soundMarioJump":
                adisrc.clip = marioJump;
                adisrc.PlayOneShot(marioJump, 1f);
                break;

        }
    }
}
