﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

namespace eShopSolution.Data.EntityModels
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
