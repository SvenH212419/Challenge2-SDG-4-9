using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerField;

    public TextMeshProUGUI contentField;

    public LayoutElement layoutElement;

    public int characterWrapLimit;

    public RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetText(string content, string header = "")
    {
        if (string.IsNullOrEmpty(header))
        {
            headerField.gameObject.SetActive(false);
        }
        else
        {
            headerField.gameObject.SetActive(true);
            headerField.text = header;
        }

        contentField.text = content;

        int headerLengt = headerField.text.Length;
        int contentLengt = contentField.text.Length;

        layoutElement.enabled = (headerLengt > characterWrapLimit || contentLengt > characterWrapLimit) ? true : false;

    }


    private void Update()

    {
        if (Application.isEditor)
        {
            int headerLengt = headerField.text.Length;
            int contentLengt = contentField.text.Length;

            layoutElement.enabled = (headerLengt > characterWrapLimit || contentLengt > characterWrapLimit) ? true : false;
        }

        Vector2 position = Input.mousePosition;

        float pivotX = position.x / Screen.width;
        float pivotY = position.y / Screen.height;

        rectTransform.pivot = new Vector2(pivotX, pivotY);
        transform.position = position;
    }

}
