using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notif3 : MonoBehaviour
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
        Debug.Log("D1000000X005 OK");
        // ������� ��������� �� �����
        StartCoroutine(ShowMessage("Вернитесь к коту", 5));
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