﻿namespace RealEstate_Api.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public DateTime AdvertisementDate { get; set; }
        //public int EmployeeID { get; set; }
        //public string CoverImage { get; set; }
        //public string Address { get; set; }
        //public string Description { get; set; }
    }
}
