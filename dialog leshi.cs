using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialogleshi : MonoBehaviour
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
        StartCoroutine(ShowMessage("Г: Леший, ты знаешь где живёт Татарин? Л: Конечно знаю, а зачем он тебе?Г: Он украл цепь с дуба, мне нужно его найти до того как он продаст цепьЛ: Хорошо, я скажу где он живёт Г: Говори скорее! Л: Полегче, сначала принеси мне траву-мураву Г: А где мне её взять? Л: Мне Яга должна была связку травы, так что не беспокойся Г: А где она живёт? Л: На болоте, её единственная изба  Г: Хорошо", 5));
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
