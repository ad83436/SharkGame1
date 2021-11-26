using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{

    [SerializeField]
    public bool isBiting;

    int sharkHP;
    // Start is called before the first frame update

    void Start()
    {
        isBiting = false;
        sharkHP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void takeDamage(int damage)
    {
        sharkHP -= damage;
    }

    // move this to shark
    private void OnTriggerStay(Collider other)
    {
        // check if the other gameobject is of type fish 
        if (other.gameObject.GetComponent<Fish>())
        {
            //assign it to a fish object eaiser to call 
            Fish fish = other.gameObject.GetComponent<Fish>();

            //check if the shark is biting 
            if (isBiting)
            {
                //if poision take health away
                if (fish.type == Fish.FishType.poision)
                {
                    Destroy(other.gameObject);
                    takeDamage(fish.damageAmount);
                    ScoreManager.instance.sharkHP = sharkHP;
                    
                }
                //if not add points
                else
                {
                    Destroy(other.gameObject);
                    ScoreManager.instance.score += 1;
                }
                SpawnManager.instance.numSpwaned = 0;
             
            }
            // check if the sharke bite the fish delete the fish add a point to the shark UI

        }
    }
}
