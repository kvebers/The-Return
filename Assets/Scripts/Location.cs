using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    // Start is called before the first frame update
    public string locationName;

    [TextArea] public string description;

    public List<Item> items = new List<Item>();
    public Connection[] connections;
    void Start()
    {
        
    }

        // Update is called once per frame
    void Update()
    {
        
    }

    public string GetItemsText()
    {
        if (items.Count == 0) return null;

        string result = "You see ";
        bool first = true;
        foreach (Item item in items)
        {
            if (item.enabled)
            {
                if (first == false)
                    result += " and ";
                first = false;
                result += item.description;
            }
        }
        result += "\n";
        return result;
    }

    public string GetConnectionsText()
    {
        string result = "";
        foreach(Connection connection in connections)
        {
            if (connection.connectionEnabled)
                result += connection.description + "\n";
        }
        return result;
    }

    public Connection GetConnection(string connectionNoun)
    {
        foreach(Connection connection in connections)
        {
            if (connection.connectionName.ToLower() == connectionNoun.ToLower())
                return connection;

        }
        return null;
    }
}
