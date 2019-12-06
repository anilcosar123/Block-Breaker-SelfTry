using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorUtilities
{
    public static void DrawRect(Rect r, Color c, float waitTime = 100f)
    {
        Debug.DrawLine(new Vector2(r.xMin, r.yMin), new Vector2(r.xMax, r.yMin), c, waitTime);
        Debug.DrawLine(new Vector2(r.xMin, r.yMin), new Vector2(r.xMin, r.yMax), c, waitTime);
        Debug.DrawLine(new Vector2(r.xMax, r.yMax), new Vector2(r.xMax, r.yMin), c, waitTime);
        Debug.DrawLine(new Vector2(r.xMax, r.yMax), new Vector2(r.xMin, r.yMax), c, waitTime);
    }
}
