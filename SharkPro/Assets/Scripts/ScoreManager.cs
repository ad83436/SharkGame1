using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance = null;

    public int score;
    public int sharkHP;


    private void Awake()
    {
        if(instance == null)
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
        score = 0;

        //change this to get the actual shark hp
        sharkHP = 3;

    }

    // Update is called once per frame
    void Update()
    {
        if(sharkHP <= 0)
        {

            SceneManager.LoadScene(0);
        }
    }
}
