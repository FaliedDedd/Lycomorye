using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stonefinal : MonoBehaviour
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
        Debug.Log("RUSALKA3 OK XXX-123маа34");
        // ������� ��������� �� �����
        StartCoroutine(ShowMessage("Возвращайтесь к русалке", 10));
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
