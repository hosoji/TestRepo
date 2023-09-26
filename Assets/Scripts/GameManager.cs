using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coinPrefab;

    private float heightValue = 4;
    private float widthValue = 8;

    public Color[] coinColors;


    // Start is called before the first frame update
    void Start()
    {
        //SpawnCoin();

        InvokeRepeating("SpawnCoin", 4, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnCoin()
    {
        float randomXValue = Random.Range(-widthValue, widthValue);
        float randomYValue = Random.Range(-heightValue, heightValue);

        Vector3 pos = new Vector3(randomXValue, randomYValue, 0);
        GameObject coinClone = Instantiate(coinPrefab, pos, Quaternion.identity); // Spawns the coin 


        
        CoinScript coinScript = coinClone.GetComponent<CoinScript>();

        coinScript.coinSpeed = Random.Range(0.1f, 2);



        int rndValue = Random.Range(0, 3);
        coinScript.ChangeCoinValue(rndValue);
        coinScript.ChangeCoinColor(coinColors[rndValue]);

    }
}
