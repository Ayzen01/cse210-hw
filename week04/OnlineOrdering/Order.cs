using System;
using System.Collections.Generic; 
 
 
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