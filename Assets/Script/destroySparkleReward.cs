﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySparkleReward : MonoBehaviour
{

    public float aliveTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, aliveTime);
    }


}
