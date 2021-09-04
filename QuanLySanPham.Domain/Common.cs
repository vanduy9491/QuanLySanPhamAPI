using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPham.Domain
{
    public static class Common
    {
        public static class Message
        {
            public static string Fail = "Something went wrong, please try again";
            public static class Category
            {
                public static string Create = "Category has been created successful";
                public static string Exist = "Category has been existed";
                public static string Update = "Category has been updated successful";
                public static string NotFound = "Category has been not found";
                public static string Delete = "Category has been deleted successful";
                public static string Restore = "Category has been restored successful";
            }
        }
    }
}
