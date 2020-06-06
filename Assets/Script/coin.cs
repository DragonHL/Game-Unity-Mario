using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // biến tạo ánh sáng khi va chạm vào tiền thành công
    public GameObject reward;

    bool collected = false;

    void OnTriggerEnter2D(Collider2D other)
    {

        //print("Enter");
        if (other.tag == "Player" && !collected)
        {
            Instantiate(reward, transform.position, Quaternion.identity);
            other.gameObject.GetComponent<PlayerAddCoinPoints>().AddCoins();
            Destroy(gameObject.transform.root.gameObject);
            collected = true;
        }
    }

}
