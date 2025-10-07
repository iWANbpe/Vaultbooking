using System.Collections.Generic;

public class Customer 
{
    public string name;
    public int customer_id;
    public Contacts contacts;
    public HouseAdress adress;

    public Flat flat;
}

public class Flat 
{
    public int flat_id;
    public int rooms_count;

    public List<Furniture> furnitureInFlat;
    public List<Customer> residents;
}

public class Furniture 
{
    public int furniture_id;
    public FurnitureType type;
    public float price;
}

public class Vault 
{
    public int vault_id;
    public Location vault_location;

    public List<Flat> vaultFlats;
}

public class Contacts 
{
    public string phone_number; 
    public string email;
    public List<string> otherContacts;
}

public class HouseAdress 
{
    public string city;
    public string street;
    public int house_number;
}

public class Location 
{
    public string latitude;
    public string longitude;
}

public enum FurnitureType 
{ 
    Chair,
    Desk,
    Electronics,
    Decoration,
    Other
}