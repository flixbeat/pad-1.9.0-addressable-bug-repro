using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        Addressables.LoadSceneAsync("Level1");
    }
}
