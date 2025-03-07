﻿using LogisticsTrackingApp.Core.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsTrackingApp.Core.Models
{
	public class Order :BaseEntity
	{
		public string OrderNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal TotalAmount { get; set; }
		public string CustomerName { get; set; }
		public string CustomerEmail { get; set; }
		public string ShippingAddress { get; set; }
		public string BillingAddress { get; set; }


		public ICollection<OrderItem> OrderItems { get; set; }
		public ICollection<Shipment> Shipments { get; set; }


	}
}
