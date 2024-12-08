using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineSphere 
{
    public void OnUpdate(){
        DrawDebugSphere(Vector3.zero, 1, Color.red);
    }

    private void DrawDebugSphere(Vector3 position, float radius, Color color, int segments = 12)
    {
        // 経度方向の円（水平）
        for(int i = 0; i < segments; i++)
        {
            float theta1 = (i * Mathf.PI * 2) / segments;
            float theta2 = ((i + 1) * Mathf.PI * 2) / segments;

            Vector3 pos1 = new Vector3(radius * Mathf.Cos(theta1), 0, radius * Mathf.Sin(theta1)) + position;
            Vector3 pos2 = new Vector3(radius * Mathf.Cos(theta2), 0, radius * Mathf.Sin(theta2)) + position;

            Debug.DrawLine(pos1, pos2, color);
        }

        // 緯度方向の円（垂直）
        for(int i = 0; i < segments; i++)
        {
            float theta1 = (i * Mathf.PI * 2) / segments;
            float theta2 = ((i + 1) * Mathf.PI * 2) / segments;

            Vector3 pos1 = new Vector3(0, radius * Mathf.Cos(theta1), radius * Mathf.Sin(theta1)) + position;
            Vector3 pos2 = new Vector3(0, radius * Mathf.Cos(theta2), radius * Mathf.Sin(theta2)) + position;

            Debug.DrawLine(pos1, pos2, color);
        }

        // 斜め方向の円（経線）
        for(int i = 0; i < segments; i++)
        {
            float theta1 = (i * Mathf.PI * 2) / segments;
            float theta2 = ((i + 1) * Mathf.PI * 2) / segments;

            Vector3 pos1 = new Vector3(radius * Mathf.Cos(theta1) * Mathf.Sin(Mathf.PI / 4), radius * Mathf.Cos(theta1) * Mathf.Cos(Mathf.PI / 4), radius * Mathf.Sin(theta1)) + position;
            Vector3 pos2 = new Vector3(radius * Mathf.Cos(theta2) * Mathf.Sin(Mathf.PI / 4), radius * Mathf.Cos(theta2) * Mathf.Cos(Mathf.PI / 4), radius * Mathf.Sin(theta2)) + position;

            Debug.DrawLine(pos1, pos2, color);
        }
    }
}