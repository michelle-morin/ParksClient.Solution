using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ParksClient.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Agency { get; set; }
    public string State { get; set; }
    public string Description { get; set; }
    public bool Campsites { get; set; }

    public static List<Park> GetParks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
      return parkList;
    }

    public static List<Park> Search(string name, string agency, string state, bool? campsites)
    {
      var apiCallTask = ApiHelper.Search(name, agency, state, campsites);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

      return parkList;
    }

    public static Park GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());
      return park;
    }

    public static void Post(Park park)
    {
      string jsonPark = JsonConvert.SerializeObject(park);
      var apiCallTask = ApiHelper.Post(jsonPark);
    }

    public static void Put(Park park)
    {
      string jsonPark = JsonConvert.SerializeObject(park);
      var apiCallTask = ApiHelper.Put(park.ParkId, jsonPark);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}