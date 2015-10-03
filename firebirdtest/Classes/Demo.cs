using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

public class Merchant
{
    private List<Product> m_products;

    public Merchant()
    {
        m_products = new List<Product>();
        m_products.Add(new Product("Pen", 25));
        m_products.Add(new Product("Pencil", 30));
        m_products.Add(new Product("Notebook", 15));
    }

    public List<Product> GetProducts()
    {
        return m_products;
    }
}

public class Product
{
    public string m_name { get; set; }
    public int m_price { get; set; }

    public Product(string name, int price)
    {
        m_name = name;
        m_price = price;
    }
}