using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class A950_CommonBL
    {
        private string m_displayid;
        private string m_displayname;
        private string m_menunameleft;
        private string m_menunameright;
        private bool m_menulefthide;
        private bool m_menurighthide;
        private bool m_menuleftenab;
        private bool m_menurightenab;
        private string m_url;
        private string m_ISBN;
        private string m_BookTitle;
        private string m_Price;

        public string DisplayId
        {
            get { return m_displayid; }
            set { m_displayid = value; }
        }
        public string DisplayName
        {
            get { return m_displayname; }
            set { m_displayname = value; }
        }
        public string MenuNameLeft
        {
            get { return m_menunameleft; }
            set { m_menunameleft = value; }
        }
        public string MenuNameRight
        {
            get { return m_menunameright; }
            set { m_menunameright = value; }
        }
        public bool MenuLeftHide
        {
            get { return m_menulefthide; }
            set { m_menulefthide = value; }
        }
        public bool MenuRightHide
        {
            get { return m_menurighthide; }
            set { m_menurighthide = value; }
        }
        public bool MenuLeftEnab
        {
            get { return m_menuleftenab; }
            set { m_menuleftenab = value; }
        }
        public bool MenuRightEnab
        {
            get { return m_menurightenab; }
            set { m_menurightenab = value; }
        }
        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

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