using System;
using System.Collections.Generic;
 
 class Product
        {
            private string _name;
            private string _productId;
            private double _price;
            private int _quantity;

            public Product(string name, string productID, double price, int quantity)
            {
                _name = name;
                _productId = productID;
                _price = price;
                _quantity = quantity;
            }

            public double GetTotalCost()
            {
                return _price * _quantity;

            }

            public string GetName() => _name;
            public string GetProductId() => _productId;
        }