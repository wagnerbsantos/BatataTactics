﻿using UnityEngine;

namespace Scripts
{
    public class Utils
    {
        public static TextMesh CreateWorldText(string text, Transform parent = null,
            Vector3 localPosition = default(Vector3), int fontSize = 40, Color color = default(Color), 
            TextAnchor textAnchor = default(TextAnchor), TextAlignment textAlignment = default(TextAlignment), int sortingOrder = 1)
        {
            return CreateWorldText(parent, text, localPosition, fontSize, color, textAnchor, textAlignment,
                sortingOrder);
        }
        
        public static TextMesh CreateWorldText(Transform parent, string text, Vector3 localPosition, int fontSize,
            Color color, TextAnchor textAnchor, TextAlignment textAlignment, int sortingOrder)
        {
            var gameObject = new GameObject("World_Text", typeof(TextMesh));
            var transform = gameObject.transform;
            transform.rotation = Quaternion.Euler(90, 0, 0);
            transform.SetParent(parent, false);
            transform.localPosition = localPosition;
            var textMesh = gameObject.GetComponent<TextMesh>();
            textMesh.anchor = textAnchor;
            textMesh.alignment = textAlignment;
            textMesh.text = text;
            textMesh.fontSize = fontSize;
            textMesh.color = color;
            textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
            return textMesh;
        }
    }
}