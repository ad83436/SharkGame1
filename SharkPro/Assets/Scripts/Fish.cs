using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    public  enum FishType
    {
        poision, 
        healthy
    }
    public bool canEat;
    public FishType type;
    public int damageAmount;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        if(type == FishType.poision)
        {
            canEat = false;
            damageAmount = 1;
        }

        else if(type == FishType.healthy)
        {
            canEat = false;
            damageAmount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
