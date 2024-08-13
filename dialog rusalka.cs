using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogrusalka : MonoBehaviour
{
  public Text guiText; 
    void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            Quest();
        }
    }
    private void Quest()
    {
        Debug.Log("RUSALKA1 OK XXX-12334");
        // ������� ��������� �� �����
        StartCoroutine(ShowMessage("Г: Русалка, ты тут всегда лежишь? Р: Конечно, а ты что думал? Я по твоему сюда на велосипеде езжу? Г: Ладно. А ты видела кто цепь украл? Р: Видела, но не скажу Г: Почему? Р: Если принесёшь мне аквамарин из реки, то скажу Г: Хорошо", 10));
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        // ������� ��������� �� �����
        guiText.text = message;
        guiText.enabled = true;
        yield return new WaitForSeconds(delay);
        guiText.enabled = false;
    }
}
