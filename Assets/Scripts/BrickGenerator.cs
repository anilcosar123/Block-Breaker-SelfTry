using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    public GameObject Bgreen, Bred, Bblue;
    public GameObject backgroundTerrain;
    public LayerMask layermask;

    public int numberOfBlueBricks;
    public int numberOfGreenBricks;
    public int numberOfRedBricks;

    private MeshCollider collider;
    private List<Vector3> usedPoints;

    // Start is called before the first frame update
    void Start()
    {
        usedPoints = new List<Vector3>();
        collider = backgroundTerrain.GetComponent<MeshCollider>();
        GeneratingBricks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateBrick(GameObject go, int amount)
    {
        if (go == null) return;
        for (int i = 0; i < amount; i++)
        {
            GameObject tmp = Instantiate(go);
            Vector3 randomPoint = GetRandomPoint();
            usedPoints.Add(randomPoint);
            tmp.transform.position = new Vector3(randomPoint.x, randomPoint.y);
        }
    }

    void GeneratingBricks()
    {
        GenerateBrick(Bblue, numberOfBlueBricks);
        GenerateBrick(Bred, numberOfRedBricks);
        GenerateBrick(Bgreen, numberOfGreenBricks);
    }

    Vector3 GetRandomPoint()
    {
        int xRandom;
        int yRandom;
        Rect r = new Rect();
        //do
        
        xRandom = (int) Random.Range(collider.bounds.min.x, collider.bounds.max.x);
        yRandom = (int) Random.Range(collider.bounds.min.y, collider.bounds.max.y);
        r.position = new Vector2(xRandom,yRandom);
        r.size = new Vector2(1f,0.32f);
        EditorUtilities.DrawRect(r,Color.red,999f);
        Debug.Log(r);

        Vector3 tmpVector3 = new Vector3(xRandom,yRandom,0f);
        if (usedPoints.Contains(tmpVector3)) return GetRandomPoint();

        //while (Physics2D.OverlapBox(r.position, r.size, layermask));
        return tmpVector3;
    }


}
