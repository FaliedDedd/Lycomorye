using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rusalkafinal : MonoBehaviour
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
        StartCoroutine(ShowMessage("Г: Вот твой камень Р: Хорошо, цепь украл Татарин, но я не знаю где он живёт Г: А кто знает? Р: Леший должен знать, он тут всё знает Г: Спасибо", 10));
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
