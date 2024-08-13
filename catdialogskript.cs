using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class catdialogskript : MonoBehaviour
{
	public RawImage guiText;
  public GameObject imageObject; // Ссылка на объект с картинкой
    public float delayInSeconds = 15f; // Промежуток времени в секундах

   


    void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            Quest();
        }
    }
    private void Quest()
    {

        	guiText.enabled = true;
            In2();

      }  

        public void In2(){


        			StartCoroutine(TurnOffImageAfterDelay());
        	TurnOffImageAfterDelay();	
        }
        
       
        


     IEnumerator TurnOffImageAfterDelay()
    {
        // Ждем заданный промежуток времени
        yield return new WaitForSeconds(delayInSeconds);

        // Выключаем картинку
        imageObject.SetActive(false);
    }

}
