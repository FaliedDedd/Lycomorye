using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogleshi2 : MonoBehaviour
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
        Debug.Log("RUSALKA2 OK XXX-12334");
        // ������� ��������� �� �����
        StartCoroutine(ShowMessage("Г: Вот твоя трава Л: *вхвхвхвхвхвхвхвхвзвхвхвхфхфхыхых* Мммм, вот это травка Г: ... Л: Так вот, Татарин живёт в пещере рядом с деревней Г: Спасибо", 10));
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
