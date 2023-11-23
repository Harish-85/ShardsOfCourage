using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ServiceRegister : MonoBehaviour
{
    private void Awake()
    {
        ServiceLocator.RegisterService(this);
    }
}

