using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buton2 : MonoBehaviour
{
    public GameObject  model1, ımage1, model2, ımage2, frame2, buton2,model3,ımage3, frame3,buton3;
    public bool acik = false;

    // Start is called before the first frame update
    void Start()
    {



    }



    public void openPanel()
    {

        StartCoroutine("yanipsönme");



    }


    public IEnumerator yanipsönme()
    {



        acik = !acik;
        if (acik)
        {
            model1.SetActive(false);
            ımage1.SetActive(false);
            model2.SetActive(false);
            ımage2.SetActive(false);
           
            yield return new WaitForSeconds(0.5f);
            model3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model3.SetActive(true);
            ımage3.SetActive(true);

            yield return new WaitForSeconds(3);

            frame2.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            frame3.SetActive(true);
            yield return new WaitForSeconds(0.5f);


            buton3.SetActive(true);

            yield return new WaitForSeconds(0.1f);
            buton2.SetActive(false);

        }
      



    }


}