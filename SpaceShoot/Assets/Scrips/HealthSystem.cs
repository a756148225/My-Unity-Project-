using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour {

    public int Health = 3;
    public GameObject[] HealthBar;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemy")
        {
            Health--;
            Compare();
        }
    }
    void Compare()
    {
        if(Health==2)
        {
            HealthBar[0].SetActive(false);
        }

        if(Health==1)
        {
            HealthBar[1].SetActive(false);
        }
        if(Health==0)
        {
            HealthBar[2].SetActive(false);
        }
        if(Health<0)
        {
            Destroy(this.gameObject);
        }
    }
}
