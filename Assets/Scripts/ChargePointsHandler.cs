using UnityEngine;
using System;
using System.Net;

public class ChargePoint
{
    public int ParkingID;
    public string ParkingName;
    public string Address;
    public float Lat;
    public float Lng;
    public int ParkingLevel;
    public int Place;
    public int Vehicle;
    public string ChargeBoxID;
    public bool Schuko;
    public bool Menneke;
    public int Status;
    public string Created;
    public string Updated;
}

public class ChargePointsHandler : MonoBehaviour
{
    private readonly string url = "https://api.bsmsa.eu/ext/api/bsm/chargepoints/v1/chargepoints";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static void CreateGameObject(ChargePoint cp)
    {
        //creamos desde aqui los gameobjects que toquen
        Console.WriteLine(cp.Lat + " " + cp.Lng);
    }

    public void GetPoints()
    {
        var json = new WebClient().DownloadString(url);
        Debug.Log("Loading charge points");
        var array = JsonUtility.FromJson<ChargePoint>(json);

        Action<ChargePoint> action = new Action<ChargePoint>(CreateGameObject);
        //Array.ForEach(array, action);
        //untested

    }
}
