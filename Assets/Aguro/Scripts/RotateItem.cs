﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, -100f * Time.deltaTime));
    }
}
