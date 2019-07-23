using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundHandler : MonoBehaviour
{
    public Sprite[] sprites;

    private int size_of_array;

  

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine("DoCheck");

        size_of_array = sprites.Length;

        this.GetComponent<Image>().preserveAspect = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DoCheck() {
    for(;;) {

         // execute block of code here
         SwapBackground();
         
         yield return new WaitForSeconds(15f);

        }
    }

    private void SwapBackground()
    {
        int random_number = Random.Range(0, size_of_array);


        this.GetComponent<Image>().sprite = sprites[random_number];

    }
    
}
