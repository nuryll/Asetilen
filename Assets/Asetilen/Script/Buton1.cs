using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buton1 : MonoBehaviour
{
    public GameObject ok,model1,ımage1, model2, ımage2,frame1, frame2,buton1,buton2,model4,ımage4;
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
         
            ok.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model1.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model1.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model1.SetActive(true);
            ımage1.SetActive(true);

            yield return new WaitForSeconds(1);

            model2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model2.SetActive(true);
            ımage2.SetActive(true);

            yield return new WaitForSeconds(3);
            frame1.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            frame2.SetActive(true);
            yield return new WaitForSeconds(0.5f);


            buton2.SetActive(true);

            yield return new WaitForSeconds(0.1f);
            buton1.SetActive(false);

        }
        else
        {
            model4.SetActive(false);
            ımage4.SetActive(false);
        }
        



    }


}