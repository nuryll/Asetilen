using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buton3 : MonoBehaviour
{
    public GameObject ok, ımage3,model3, buton1, buton2,buton3,model4,ımage4,frame3, frame1;
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

            model3.SetActive(false);
            ımage3.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            model4.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model4.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model4.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            model4.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            model4.SetActive(true);
            ımage4.SetActive(true);

            yield return new WaitForSeconds(3);

         

            frame3.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            frame1.SetActive(true);
            ok.SetActive(true);


            buton1.SetActive(true);

            yield return new WaitForSeconds(0.1f);
            buton3.SetActive(false);

        

        }




    }


}