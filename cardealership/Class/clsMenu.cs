using System.Drawing;

namespace cardealership.Class
{
    public class clsMenu
    {
        private string title;
        private Image icon;
        private int level;

        public string Title { get { return this.title; } set { this.title = value; } }
        public int Level { get { return this.level; } set { this.level = value; } }
        public Image Icon { get { return this.icon; } set { this.icon = value; } }


        public clsMenu()
        {

        }

        public clsMenu(string title, Image icon)
        {
            this.title = title;
            this.icon = icon;
        }

        public clsMenu(string title, Image icon, int level)
        {
            this.title = title;
            this.icon = icon;
            this.level = level;
        }

        public void getMenuList()
        {
            // can get a query from database and fill the class
        }
    }
}
