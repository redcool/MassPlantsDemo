using UnityEngine;
using System.Collections;

public class MassPlants : MonoBehaviour
{
    public PlantProfile[] profiles;

    public float size = 50;

    private void Start()
    {
    }

    void Update()
    {

        foreach (var p in profiles)
        {
            if (p.needUpdate)
            {
                p.needUpdate = false;

                p.bounds = new Bounds(transform.position, new Vector3( size,size,size));
                p.Update();
            }

            p.Draw();
        }

    }

    void OnDisable()
    {
        foreach (var p in profiles)
        {
            p.ClearBuffers();
        }
    }
}