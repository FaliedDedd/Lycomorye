using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leshidialog : MonoBehaviour
{

    public Text guiText;
    public Transform targetPoint; // ������� �����, ���� ������ ��������� �����
    public float closeEnoughDistance = 1.0f; // ���������, �� ������� ����� ��������� ��������� ����

    void Update()
    {
        // ���������, ������ �� ����� ����
        if (Vector3.Distance(transform.position, targetPoint.position) <= closeEnoughDistance)
        {
            // ���� ����� ������ ����, �������� ������� CompleteQuest
            CompleteQuest();
        }
    }

    void CompleteQuest()
    {
        // ����� ����� �������� ���, ������� ����� ����������� ��� ���������� �������
        Debug.Log("������� ���������!");
        // ������� ��������� �� �����
        StartCoroutine(ShowMessage("������� ��� ����������� �������, ��� ���� � ������, �� ���� � ����, ����� ���, ����� ��� ��� �������, � ������ ��� ���(��� ��� �������� ��.����� - ������)", 2));
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
