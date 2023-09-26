using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public int coinValue;
    public TextMeshPro valueText;
    public SpriteRenderer sr;
    public float coinSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        //sr = GetComponent<SpriteRenderer>();

        //ChangeCoinColor(Random.ColorHSV());
        //ChangeCoinValue(Random.Range(1, 9));
        
     
        
    }

    private void Update()
    {
        transform.Translate(0,Time.deltaTime * coinSpeed,0);
    }

    public void ChangeCoinColor(Color c)
    {
        sr.color = c;

    }

    public void ChangeCoinValue(int v)
    {
        coinValue = v;
        valueText.text = coinValue.ToString();
    }



}
