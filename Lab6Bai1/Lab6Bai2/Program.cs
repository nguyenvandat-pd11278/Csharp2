using System;
public class PhoneLab6
{
    public int ID;
    public int shop_ID;
    public string Name;
    public int price;
    public string des;
    public PhoneLab6(int id, int shop_id, string name, int price, string des)
    {
        this.ID = id;
        this.shop_ID = shop_id;
        this.Name = name;
        this.price = price;
        this.des = des;
    }
}
public class ShopLab6
{
    public int ID;
    public string City;
    public string Districs;
    public ShopLab6 (int id, string  city, string districs)
    {
        this.ID = id;
        this.City = city;
        this.Districs = districs;
    }
}
class Program
{
    static void Main()
    {
        List<ShopLab6> listshop = new List<ShopLab6>();
        listshop.Add(new ShopLab6(1, "HCM", "Quan 12"));
        listshop.Add(new ShopLab6(2, "Ha Noi", "Quan nam tu lien"));
        listshop.Add(new ShopLab6(3, "Da Nang", "Quan hai chau"));

        List<PhoneLab6> listPhone = new List<PhoneLab6>();
        listPhone.Add(new PhoneLab6(1, 1, "IP15", 100, "DOC LA BINH DUONG"));
        listPhone.Add(new PhoneLab6(2, 2, "IP16", 1000, "DOC LA BINH DUONG"));
        listPhone.Add(new PhoneLab6(3, 3, "IP17", 10000, "DOC LA BINH DUONG"));
        listPhone.Add(new PhoneLab6(4, 1, "IP18", 100000, "DOC LA BINH DUONG"));

        var Query = from phone in listPhone
                    join shop in listshop on phone.shop_ID equals shop.ID
                    select new { shopName = shop.City, PhoneName = phone.Name };
        foreach (var item in Query)
        {
            Console.WriteLine($"shopName:{item.shopName},PhoneName:{item.PhoneName}");
        }
        Console.WriteLine("--------------------");
        var groupJoin = listshop.GroupJoin(
            listPhone,
            shop => shop.ID,
            phone => phone.shop_ID,
            (shop, phoneGroup) => new { shopName = shop.City, Phones = phoneGroup }
            );
        foreach(var shopGround in groupJoin)
        {
            Console.WriteLine($"shopName:{shopGround.shopName}");

            foreach (var phone in shopGround.Phones)
            {
                Console.WriteLine($"phoneName:{phone.Name}");
                Console.WriteLine($"phonePrice:{phone.price}");
            }
            Console.WriteLine("------------");
        }

    }
}
