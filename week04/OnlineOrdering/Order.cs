using System;
using System.Collections.Generic;

public class Order
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

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shipping = 0;

        if (_customer.IsInUSA() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }

        return label;
    }

        public string GetShippingLabel()
        {
            return _customer.GetCustomerInfo();
        }
    }