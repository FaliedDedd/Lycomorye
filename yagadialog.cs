using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yagadialog : MonoBehaviour
{  public Text guiText; 
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
        StartCoroutine(ShowMessage("Я: Ты зачем сюда пришёл? Г: Мне нужна трава-мураву Я: Хорошо, только сначала принеси мне листья с дуба, с самой верхушки и золотой жёлудь Г: Я пришёл от Лешёго, он сказал что ты должна ему травы Я: Вот чёрт, ладно, бери Г: Спасибо", 10));
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
