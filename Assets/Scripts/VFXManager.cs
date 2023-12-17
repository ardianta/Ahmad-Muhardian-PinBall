using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxBumperSource;
    public GameObject vfxSwitchSource;

    public void PlayBumperVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxBumperSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitchSource, spawnPosition, Quaternion.identity);
    }
}
