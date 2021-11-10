using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(/**Bucket**/ )
    {
        //Randomize ints to use as values
        int rojo = Random.Range(0, 256);
        int verde = Random.Range(0, 256);
        int azul = Random.Range(0, 256);

        //Convert ints to color
        try
        {
            byte red = (byte)rojo;
            byte green = (byte)verde;
            byte blue = (byte)azul;
            Color forRound = new Color32(red, green, blue, 255); //255 is alpha value
        }
        catch (System.OverflowException)
        {
            Debug.Log("At least one color is outside of byte conversion range");
        }

        //Set bucket color to color
        //Bucket.set
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
