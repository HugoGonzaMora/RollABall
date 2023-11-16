using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManage : MonoBehaviour
{
    public GameObject coin;
    public int objectNumber;
    public Vector3 maxPosition;


    // Start is called before the first frame update
    void Start()
    {
        GenerateCoins();
    }

    private void GenerateCoins()
    {
        for (int i = 0; i < objectNumber; i++)
        {

            Vector3 initialPosition = new Vector3(
                Random.Range(-9, maxPosition.x),
                Random.Range(1, maxPosition.y),
                Random.Range(-9, maxPosition.z)
                );
            //Add an object to the Game
            Instantiate(coin, initialPosition, Quaternion.identity);
        }
    }
}
