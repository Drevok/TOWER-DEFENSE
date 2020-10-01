using UnityEngine;

public class BuildManager : MonoBehaviour
{
   

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

    private GameObject turretToBuild;
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }
}
