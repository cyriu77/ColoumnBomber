using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBomber : MonoBehaviour
{
    public bool ColorActive;
    public GameObject colAnimBomb;
    [SerializeField]public int colorNumT;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator ColAnimAct()
    {
        yield return new WaitForSeconds(0f);
        ColorActive = true;
        yield return new WaitForSeconds(0f);
        //dublAdjs = PlayerPrefs.GetInt("numAdjasshow");
        colAnimBomb.SetActive(true);
        //yield return new WaitForSeconds(0f);
        //isRowBombu = true;
        yield return new WaitForSeconds(5f);
        colAnimBomb.SetActive(false);
        yield return new WaitForSeconds(0f);
        ColorActive = true;
        Debug.Log("false");

    }
    public void ColorActivate()
    {
        if(colorNumT >= 0)
        {
            Debug.Log("zaxodit");
            ColorActive = true;
            StartCoroutine(ColAnimAct());
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        colorNumT = PlayerPrefs.GetInt("numColshow");
        
    }
}
