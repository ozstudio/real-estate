using System;
namespace realEstate.Models
{
    public class RealEstateModel
    {
        //public int RealEstateModelId {get;set;}
        //public double Rooms {get;set;}
        //public double SqMetters {get;set;}
        //public double Price { get; set; }
        //public int Buthrooms {get;set; }
        //public string City {get;set;}
        //public string Image1Path {get;set;}
        //public string Image2Path { get; set; }
        //public string Image3Path { get; set; }
        public int RealEstateModelId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PropertyStatus { get; set; }
        public int Meters { get; set; }
        public string Description { get; set; }
        public int Floor { get; set; }
        public int Rooms { get; set; }
        public int Parking { get; set; }
        public string AC { get; set; }
        public string Elevator { get; set; }
        public int Price { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string image3 { get; set; }


    }
}
