using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelscript : MonoBehaviour
{
    public Text guiText;
    public Transform targetPoint; // Целевая точка, куда должен добраться игрок
    public float closeEnoughDistance = 1.0f; // Дистанция, на которой игрок считается достигшим цели

    void Update()
    {
        // Проверяем, достиг ли игрок цели
        if (Vector3.Distance(transform.position, targetPoint.position) <= closeEnoughDistance)
        {
            // Если игрок достиг цели, вызываем функцию CompleteQuest
            CompleteQuest();
        }
    }

    void CompleteQuest()
    {
        // Здесь можно добавить код, который будет выполняться при выполнении задания
        Debug.Log("Задание выполнено!");
        // Выводим сообщение на экран
        StartCoroutine(ShowMessage("Кот:Я ушёл спать в дупло, а на утро выхожу, а цепи нет. Я незнаю что делать " +
            "Русалка: Я видела, но просто так не скажу, принеси мне морской камень(аквамарин) и я скажу кто это сделал" +
            "Вы: Давай я помогу тебе найти цепь", 2));
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        // Выводим сообщение на экран
        guiText.text = message;
        guiText.enabled = true;
        yield return new WaitForSeconds(delay);
        guiText.enabled = false;
    }
}