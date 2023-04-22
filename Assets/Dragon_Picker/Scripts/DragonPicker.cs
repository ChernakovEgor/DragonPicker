using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonPicker : MonoBehaviour
{
    [SerializeField] private GameObject energyShield;
    [SerializeField] private int energyShieldsCount = 3;
    [SerializeField] private float energyShieldBottomY = -6f;
    [SerializeField] private float energyShieldRadius = 1.5f;

    private void Start()
    {
        for (int i = 1; i <= energyShieldsCount; i++)
            SpawnShield(i);
            
    }

    private void SpawnShield(int i)
    {
        GameObject shield = Instantiate(energyShield);
        shield.transform.position = new Vector3(0, energyShieldBottomY, 0);
        shield.transform.localScale = new Vector3(i, i, i);
    }

}
