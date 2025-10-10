using System.Collections.Generic;

public class Customer 
{
    public int customer_id; // PK
    public string name;
    public int flat_id { get { return flat.flat_id; } } // FK
    public int customerAdress_id { get { return customerAdress.customerAdress_id; } } // FK
    public string phone_number { get { return contacts.phone_number; } } // FK

    public Contacts contacts;
    public CustomerAdress customerAdress;
    public Flat flat;
}

public class Flat 
{
    public int flat_id; // PK
    public int rooms_count;
    public int residents_count { get { return residents.Count; } }
    public int vault_id { get { return vault.vault_id; } } // FK

    public Vault vault;
    public List<Furniture> furnitureInFlat;
    public List<Customer> residents;
}

public class Furniture 
{
    public int furniture_id; // PK
    public string name;
    public float price;
    public int flat_id { get { return flat.flat_id; } } // FK

    public Flat flat;
}

public class Vault 
{
    public int vault_id; // PK
    public int location_id { get { return location.location_id; } } // FK

    public List<Flat> flats;
    public Location location;
}

public class Contacts 
{
    public string phone_number; // PK 
    public string email;
    public string otherContacts;

    public Customer customer;
}

public class CustomerAdress
{
    public int customerAdress_id; // PK
    public string city;
    public string street;
    public int house_number;

    public Customer customer;
}

public class Location 
{
    public int location_id; // PK
    public string latitude;
    public string longitude;

    public Vault vault;
}