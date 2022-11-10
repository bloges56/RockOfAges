using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject GreenRock;

    [SerializeField]
    GameObject WhiteRock;

    [SerializeField]
    GameObject RedRock;

    float elapsedTime;

    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0f;
        timer = gameObject.GetComponent<Timer>();
        timer.Duration = 20f;
        timer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Running)
        {
            Debug.Log("Timer Running");
            if(elapsedTime >= 1f)
            {
                int rng = (int)Random.Range(0,3);
                GameObject rockToSpawn;
                switch(rng) 
                {
                    case 0:
                        rockToSpawn = GreenRock;
                        break;
                    case 1:
                        rockToSpawn = WhiteRock;
                        break;
                    default:
                        rockToSpawn = RedRock;
                        break; 
                }
                Instantiate(rockToSpawn, new Vector3(0f, 0f, 0f), Quaternion.identity);
                elapsedTime = 0f;
            }
            else
            {
                elapsedTime += Time.deltaTime;
            }
        }
    }
}