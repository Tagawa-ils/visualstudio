using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormStudy.A950_BL
{
    public class A950_CommonBL
    {
        private string m_ISBN;
        private string m_BookTitle;
        private string m_Price;


        public string ISBN
        {
            get { return m_ISBN; }
            set { m_ISBN = value; }
        }
        public string BookTitle
        {
            get { return m_BookTitle; }
            set { m_BookTitle = value; }
        }
        public string Price
        {
            get { return m_Price; }
            set { m_Price = value; }
        }
    }
}