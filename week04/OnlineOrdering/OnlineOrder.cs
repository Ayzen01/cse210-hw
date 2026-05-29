using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

// CLASSE ADDRESS (Endereço)
// ==========================================
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        string _countryLower = _country.ToLower();
        return _countryLower == "usa"   || _countryLower == "united states" || _countryLower == "estados unidos";


    }

    public string GetFullAddress()
    {
        return $"{_street},\n {_city}, - {_state},\n{_country}";
    }

}

    class Customer
    {
        private string _name;
        private Address _address;

        public Customer (string name , Address address)
        {
            _name = name;
            _address = address;
        
        }
        public  bool LivesInUSA()
        {
            return _address.IsInUSA();
        }
        public string GetName()
        {
            return _name;
        }
        public string GetAddressText() 
        {
            return _address.GetFullAddress();
        }
    }
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
    class Order
            {
                private List<Product> _products;
                private Customer _customer;

                public Order(Customer customer)
                {
                    _customer = customer;
                    _products = new List<Product>();
                }
                public void AddProduct(Product product)
                {
                    _products.Add(product);
                }

                public double CalculateTotalOrderPrice()
                {
                    double total = 0;
                    foreach (var product in _products)
                    {
                        total += product.GetTotalCost();
                    }
                   double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
                   return total + shippingCost;

                }

                public string GetPackingLabel()
                {
                    string label = "Packaging Label (Items): \n";
                    foreach (Product product in _products)
                    {
                        label += $" - {product.GetName()}  [ID: {product.GetProductId()}]\n";
                    }
                    return label;

                        
                } 
                
                public string  GetShippingLabel()
                {
                    return $"Shipping Label (Recipient):\nName: {_customer.GetName()}\n{_customer.GetAddressText()}\n";

                }   
            
       

    
    }