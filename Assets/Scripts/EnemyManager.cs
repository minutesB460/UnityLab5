using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameRestart()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<EnemyMovement>().GameRestart();
        }
    }

    // void  Awake(){
	// 	Debug.Log("awake called");
	// 	// other instructions that needs to be done during Awake
    //     GameManager.instance.gameRestart.AddListener(GameRestart);
	// }
}
