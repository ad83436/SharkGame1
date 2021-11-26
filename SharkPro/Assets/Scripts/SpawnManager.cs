using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Shark shark;
    public List<Fish> fish;

    public static SpawnManager instance = null;
    public int numSpwaned = 0;
    Fish spawnedFish;

    float timer;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numSpwaned == 0)
        {
            int RandomNum = Random.Range(0, 3);
            spawnedFish = Instantiate(fish[RandomNum], new Vector3(shark.transform.position.x, shark.transform.position.y, shark.transform.position.z+20), shark.transform.rotation);
            numSpwaned += 1;
        }

        timer += Time.deltaTime;

        if(timer > 4)
        {
            Destroy(spawnedFish);
            numSpwaned = 0;
            timer = 0;
        }
    }
}
